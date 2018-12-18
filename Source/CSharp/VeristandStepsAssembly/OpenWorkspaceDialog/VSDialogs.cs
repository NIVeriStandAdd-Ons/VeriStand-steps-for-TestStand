using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Text;
using NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand;
using NationalInstruments.VeriStand.SystemStorage;
using System.Runtime.InteropServices;
using NationalInstruments.VeriStand.RealTimeSequenceDefinitionApi;
using NationalInstruments.VeriStand.Data;
using NationalInstruments.TestStand.Interop.API;
using NationalInstruments.VeriStand.ClientAPI;
using NationalInstruments.VeriStand.SystemStorageUI;
using System.Collections.Concurrent;
using System.Diagnostics;
namespace OpenWorkspaceDialog
{

   public  class VSDialogs
    {
       //For each of the different dialogs create a new thread and pass it the TestStand Sequence Context
       //A new thread is created so we don't lock up the TestStand UI
        //The sequence context lets us edit the active TestStand sequence
        #region Launching of VS Gateway
       private int gatewayHandle = 0;
       Process silentVeriStand;
        private void StartProcess(string filepath)
        {

            System.Diagnostics.Process.Start(filepath);

        }
        public void StartVeristand(bool silent, string installLocation, SequenceContext seqContext)
        {
          //Launching silently works when done from LabVIEW or Visual Studio but does not work from TestStand.  
            if (silent == false)
            {
                //Launch Veristand
                PropertyObject termMonitor=seqContext.Execution.InitTerminationMonitor();
               StartProcess(installLocation + "\\NI Veristand.exe");
                Factory myFactory = new Factory();
                for (int i = 0; i < 1000; i++)
                {
                    if (seqContext.Execution.GetTerminationMonitorStatus(termMonitor))
                    {
                        break;  //If sequence is terminating exit the loop
                    }
                    try
                    {
                        myFactory.GetIWorkspace2();
                        break;
                    }
                    catch (Exception ex)
                    {
                    }

                    System.Threading.Thread.Sleep(500);
                }
            }
            else
            {
                //Just launch the gateway in the background
             silentVeriStand=   Process.Start(installLocation + "\\SilentVeriStand.exe");
           
                /*
                 * This code works when called from C# or LabVIEW but does not work when called from TestStand so instead a compiled LabVIEW executable is called 
                SetCurrentDirectory(GetVSDLLPath());
                gatewayHandle=LaunchGateway();
               
                RestoreCurrentDirectory();
               */
            }
           
        }
        public int StopVeristandGateway()
        {//For StopVeristandGateway to work the same instance of VSDialogs must be used in TestStand
            silentVeriStand.Kill();
            return 0;

            /* Code works when called from c# or LabVIEW but not TestStand
            SetCurrentDirectory(GetVSDLLPath());
            int returnValue=StopGateway(gatewayHandle);
            RestoreCurrentDirectory();
            return returnValue;
             * */
        }
        public unsafe class NativeMethods
        {
            //int32_t StartVeriStandGateway(int32_t *ref);
            [DllImport(VSDLL, CharSet = CharSet.Auto,CallingConvention=CallingConvention.Cdecl)]
            public extern static Int32 StartVeriStandGateway(int* handle);

            //int32_t StopVeriStandGateway(int32_t *ref);
            [DllImport(VSDLL, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
            public extern static Int32 StopVeriStandGateway(int* handle);
        }

       

        const string VSDLL = "Data/NationalInstruments.VeriStand.Gateway.dll";
        
        public static string GetVSDLLPath()
        {
            return null;
  //          return NationalInstruments.VeriStand.WindowsRegistry.GetInstallationDirectory() ; //this call is not working with VeriStand 2012
        }

        private static string _savedCurrentDirectory;
        public static void SetCurrentDirectory(string dirname)
        {
            if (_savedCurrentDirectory == null)
            {
                _savedCurrentDirectory = Environment.CurrentDirectory;
                Environment.CurrentDirectory = dirname;
            }
        }
        public static void RestoreCurrentDirectory()
        {
            if (_savedCurrentDirectory != null)
            {
                Environment.CurrentDirectory = _savedCurrentDirectory;
                _savedCurrentDirectory = null;
            }
        }

        public unsafe int LaunchGateway()
        {
            int x = 1;
            int* _handle= &x;
            try
            {
                Int32 error = NativeMethods.StartVeriStandGateway(_handle);
                if (error != 0)
                {
                    throw new ExternalException("StartVeriStandGateway call failure: 0x" + error.ToString("X"));
                }
                if (*_handle == 0)
                {
                    throw new ExternalException("StartVeriStandGateway no handle");
                }

            }
            finally
            {
            }
            return *_handle; 
            
          
        }

        public unsafe int StopGateway(int _handle)
        {
                try
                {
                    Int32 error = NativeMethods.StopVeriStandGateway(&_handle);
                  
                 }
                finally
                {
                }

                return _handle;
        }
    
#endregion
        #region Dialogs
       //Commenting out threaded methods in favor of modal dialogs
      /*  public  void ConfigureGatewayDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(() => ProjectThreadProc(seqContext)));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }*/
        public void TreeBrowserDialogTest()
        {
            Application.Run(new VSChannelBrowserTest());
        }
        public void ConfigureGatewayDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {        
            Application.Run(new ConfigureGateway(seqContext));
        }
        public void ConfigureSequenceNameDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            Application.Run(new ConfigureSequenceName(seqContext));
        }
        public void ConfigureLegacyStimulusProfileDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            Application.Run(new ConfigureLegacyStimulusProfile(seqContext));
        }
        public SequenceCallInfo[] ConfigureRealTimeSequenceDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            ConcurrentQueue<SequenceCallInfo[]> cq = new ConcurrentQueue<SequenceCallInfo[]>();
            SequenceCallInfo[] seqCallInfo;
            Application.Run(new ConfigureRTSequence(seqContext, cq));
            bool elementFound = cq.TryDequeue(out seqCallInfo);
            return seqCallInfo; 
        }
        public void NativeConfigureRealTimeSequenceDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            Application.Run(new ConfigureRTSequenceNative(seqContext));
        }
        public void ConfigureRealTimeSequenceNumericLimitDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            Application.Run(new ConfigureRTSequenceNumericLimit(seqContext));
        }
        public void ConfigureSystemDefinitionDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            Application.Run(new ConfigureSystemDefinition(seqContext,true));
        }
        public void ConfigureStimulusProfileDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            Application.Run(new StimulusProfileDialog(seqContext));
        }
        public void ConfigureUndeploySystemDefinitionDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            Application.Run(new ConfigureSystemDefinition(seqContext, false));
        }
        public void ConfigureChannelNameDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext, NativeChannelSelectionDialog.ChannelType channelType)
        {
            Application.Run(new NativeChannelSelectionDialog(seqContext,channelType));
        }
        public static void ChannelNameThreadProc(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext,bool ModelList)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChannelSelectionDialog(seqContext,ModelList));
        }
        public void ShowWarningDialog(string output)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(() => ShowWarningThreadProc(output)));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public static void ShowWarningThreadProc(string output)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WarningForm(output));
        }
        public void ShowUpdateModelParametersFromFileDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            Application.Run(new ModelParametersFromFile(seqContext));
        }
        public static void ShowUpdateModelParametersFromFileProc(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ModelParametersFromFile(seqContext));
        }
        public void ShowAlarmStateDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {
            Application.Run(new ConfigureAlarm(seqContext));
        }
        public void ConfigureLoggingDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext, ConfigureLoggingFile.ChannelType channelType)
        {
            Application.Run(new ConfigureLoggingFile(seqContext,channelType));
        }
        public void GetMultipleChannelsDialog(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext, GetChannelsDialog.ChannelType channelType)
        {
            Application.Run(new GetChannelsDialog(seqContext, channelType));
        }
        public void SetMultipleChannelsDialogDGV(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext, SetMultipleChannelsDialogDGV.ChannelType channelType)
        {
            Application.Run(new SetMultipleChannelsDialogDGV(seqContext, channelType));
        }
#endregion
        #region TestStand Helper Methods
        public IStimulusProfileSession StartStimulusProfile(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext,SequenceCallInfo[] seqCallInfoArray,string gatewayIP)
        {
            seqCallInfoArray = Array.FindAll(seqCallInfoArray, isNotNull).ToArray();
            Step activeStep = seqContext.Step;
            string stepID = activeStep.UniqueStepId;
            Sequence selectedTSSequence = seqContext.Sequence;
            PropertyObject stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
                    
            try
            {
                PropertyObject seqContextPO = seqContext.AsPropertyObject();
                Factory vsFact = new Factory();
                string sequenceName;
                try
                {
                    sequenceName = stepPropertyObject.GetValString("Veristand.RTSessionName", 0);
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    sequenceName="CouldNotFindName";
                    VSDialogs dialogs = new VSDialogs();
                    dialogs.ShowWarningDialog("Could not find name of RT Sequence");
                }
                IStimulusProfileSession stimProfSession = vsFact.GetIStimulusProfileSession(gatewayIP, sequenceName, seqCallInfoArray, "Teststand Stimulus Profile Session");   
                bool auto_start;
                try
                {
                    auto_start = stepPropertyObject.GetValBoolean("Veristand.StimProfAutoStart", 0);
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    auto_start = false;
                }
                string sessionName;
                NationalInstruments.VeriStand.Error vsError;
                stimProfSession.Deploy(auto_start, out sessionName, out vsError);
                if (vsError.Code != 0)
                {
                    VSDialogs dialogs2 = new VSDialogs();
                    dialogs2.ShowWarningDialog(vsError.ResolvedErrorMessage);
                }
             
                return stimProfSession;


            }
            catch (NationalInstruments.VeriStand.VeriStandException ex)
            {
                VSDialogs dialogs = new VSDialogs();
                dialogs.ShowWarningDialog(ex.ResolvedErrorMessage + "------" + ex.StackTrace);
            }
            catch (System.InvalidCastException ex)
            {
                VSDialogs dialogs = new VSDialogs();
                dialogs.ShowWarningDialog(ex.Message + "------" + ex.StackTrace);
            }
            return null;
        }
       static void resolveExpressions(ref string[] inputStrings, PropertyObject expSeqContextPO)
        {
         
            int i = 0;
            foreach(string currentInput in inputStrings)
            {
                PropertyObject evaluatedValuePO=expSeqContextPO.EvaluateEx(currentInput, 0);

                inputStrings[i] = evaluatedValuePO.GetValVariant(evaluatedValuePO.GetLocation(evaluatedValuePO), 0).ToString();
                i++;
            }
          }
        public SequenceCallInfo[] ReinitializeSequenceCallInfo(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext,string stepID)
        {
            string paramType = "";
            string paramValue = "";
            string paramName = "";
            PropertyObject seqContextPO = seqContext.AsPropertyObject();
            Step activeStep = seqContext.Step;
            string[] parameterTypes;
            string[] parameterValues;
            string[] parameterNames;
            SequenceCallInfo seqCallInfo;
            SequenceCallInfo[] seqCallInfoArray;
            Sequence selectedTSSequence = seqContext.Sequence;
            PropertyObject stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
            string[] sequenceNames = Array.ConvertAll((object[])stepPropertyObject.GetValVariant("Veristand.SequenceNames", 0), o => o.ToString());
            
            string gatewayIP;
            try
            {

                gatewayIP = seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.GatewayIP", 0);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                gatewayIP = "localhost";
            }
            try
            {
                parameterValues = Array.ConvertAll((object[])stepPropertyObject.GetValVariant("Veristand.ParamValues", 0), o => o.ToString());
                parameterTypes = Array.ConvertAll((object[])stepPropertyObject.GetValVariant("Veristand.ParamTypes", 0), o => o.ToString());
                parameterNames = Array.ConvertAll((object[])stepPropertyObject.GetValVariant("Veristand.ParamNames", 0), o => o.ToString());
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                             
                parameterValues=new string[0];
                parameterTypes = new string[0];
                parameterNames = new string[0];
            }

            int numberofSequences =(int) stepPropertyObject.GetValNumber("Veristand.RTNumSequences", 0);
            seqCallInfoArray=new SequenceCallInfo[numberofSequences];     
            for (int sequenceNumber = 0; sequenceNumber < numberofSequences; sequenceNumber++)
            {
                string[] curParameterValues = StringUtilities.expressionArrayToStringArray(parameterValues[sequenceNumber]);
                string[] curParameterNames = StringUtilities.expressionArrayToStringArray(parameterNames[sequenceNumber]);
                string[] curParameterTypes = StringUtilities.expressionArrayToStringArray(parameterTypes[sequenceNumber]);
              
                int numParameters = curParameterNames.Length;
                if (numParameters > 0)
                {
                    resolveExpressions(ref curParameterValues, seqContextPO);
                }
                SequenceParameterAssignmentInfo[] seqParametersInfo = new SequenceParameterAssignmentInfo[numParameters];
                try
                {
                  
                    for (uint parameterNumber = 0; parameterNumber < numParameters; parameterNumber++)
                    {
                  
                        try
                        {
                            paramValue = curParameterValues[parameterNumber];
                            paramType = curParameterTypes[parameterNumber];
                            paramName = curParameterNames[parameterNumber];
                        }
                        catch (System.Runtime.InteropServices.COMException ex) //We have processed all the sequences
                        {
                        
                        }
                        switch (paramType)
                        {//Initialize the correct type of parameter based on the Users Type setting
                            case "Path":
                                SystemDefinitionChannelResource sysDefChannel = new SystemDefinitionChannelResource(paramValue);
                                seqParametersInfo[parameterNumber] = new SequenceParameterAssignmentInfo(paramName, sysDefChannel);

                                break;
                            case "Boolean":
                                BooleanValue boolVal = new BooleanValue(Convert.ToBoolean(paramValue));
                                seqParametersInfo[parameterNumber] = new SequenceParameterAssignmentInfo(paramName, boolVal);
                                break;
                            case "Double":
                                DoubleValue doubleVal = new DoubleValue(Convert.ToDouble(paramValue));
                                seqParametersInfo[parameterNumber] = new SequenceParameterAssignmentInfo(paramName, doubleVal);
                                break;
                            case "I32":
                                I32Value i32Val = new I32Value(Convert.ToInt32(paramValue));
                                seqParametersInfo[parameterNumber] = new SequenceParameterAssignmentInfo(paramName, i32Val);
                                break;
                            case "I64":
                                I64Value i64Val = new I64Value(Convert.ToInt64(paramValue));
                                seqParametersInfo[parameterNumber] = new SequenceParameterAssignmentInfo(paramName, i64Val);
                                break;
                            case "U32":
                                U32Value u32Val = new U32Value(Convert.ToUInt32(paramValue));
                                seqParametersInfo[parameterNumber] = new SequenceParameterAssignmentInfo(paramName, u32Val);
                                break;
                            case "U64":
                                U64Value u64Val = new U64Value(Convert.ToUInt64(paramValue));
                                seqParametersInfo[parameterNumber] = new SequenceParameterAssignmentInfo(paramName, u64Val);
                                break;
                        }
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    //Parameter numbers don't match up
                    VSDialogs vsdiag = new VSDialogs();
                    vsdiag.ShowWarningDialog("Parameter Import Failed");
                }
               

                
                seqCallInfo = new SequenceCallInfo(sequenceNames[sequenceNumber], "", seqParametersInfo, false, 1000);
                seqCallInfoArray[sequenceNumber] = seqCallInfo;

            }
            seqCallInfoArray = Array.FindAll(seqCallInfoArray, isNotNull).ToArray(); //Get rid of all null entries in the array
            return seqCallInfoArray;
        }
        public SequenceCallInfo[] ReinitializeSequenceCallInfo(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
        {

            PropertyObject seqContextPO = seqContext.AsPropertyObject();
            Step activeStep=seqContext.Step;
            string stepID = activeStep.UniqueStepId;

            return ReinitializeSequenceCallInfo(seqContext,stepID);
        }

       
        private static bool isNotNull(SequenceCallInfo n)
        {
            return n != null;
        }
     
       public void SetAlarmState(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
       {
           //Gets all the current alarm info and modifies the state then sets the alarm data

           //Get TestStand Information
           PropertyObject seqContextPO = seqContext.AsPropertyObject();
           Step activeStep = seqContext.Step;
           string stepID = activeStep.UniqueStepId;

           Sequence selectedTSSequence = seqContext.Sequence;
           PropertyObject stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
           Factory fact = new Factory();
           string alarmName = StringUtilities.removeDoubleQuotesAroundString(stepPropertyObject.GetValString("Veristand.AlarmName", 0));
           string alarmValue = StringUtilities.removeDoubleQuotesAroundString(stepPropertyObject.GetValString("Veristand.AlarmState", 0));
           IAlarm thisAlarm=fact.GetIAlarm(alarmName);
           AlarmInfo alarmData;
          
           Error alarmError1=thisAlarm.GetAlarmData(out alarmData, 5000);

           switch(alarmValue)
           {
               case "Disabled":
                    alarmData.State=NationalInstruments.VeriStand.ClientAPI.AlarmState.Disabled;
                   break;
               case "Enabled":
                   alarmData.State = NationalInstruments.VeriStand.ClientAPI.AlarmState.Enabled;
                   break;
               case "Tripped":
                   alarmData.State = NationalInstruments.VeriStand.ClientAPI.AlarmState.Tripped;
                   break;
               case "Delayed Trip":
                   alarmData.State = NationalInstruments.VeriStand.ClientAPI.AlarmState.DelayedTripped;
                   break;
               case "Indicate":
                   alarmData.State = NationalInstruments.VeriStand.ClientAPI.AlarmState.Indicate;
                   break;


           }
        thisAlarm.SetAlarmData(alarmData);
          
       }
       public string GetAlarmState(NationalInstruments.TestStand.Interop.API.SequenceContext seqContext)
       {
           //Gets all alarm information and returns just the state

           //Get TestStand Information
           PropertyObject seqContextPO = seqContext.AsPropertyObject();
           Step activeStep = seqContext.Step;
           string stepID = activeStep.UniqueStepId;
           Sequence selectedTSSequence = seqContext.Sequence;
           PropertyObject stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
           Factory fact = new Factory();
           string alarmName = StringUtilities.removeDoubleQuotesAroundString(stepPropertyObject.GetValString("Veristand.AlarmName", 0));

         
           IAlarm thisAlarm = fact.GetIAlarm(alarmName);
           AlarmInfo alarmData;
           thisAlarm.GetAlarmData(out alarmData, 5000);
           return alarmData.State.ToString();
       }

    }
        #endregion
}
