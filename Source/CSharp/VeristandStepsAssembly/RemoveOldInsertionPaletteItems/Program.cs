using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// TestStand Core API 
using NationalInstruments.TestStand.Interop.API;

// TestStand User Interface Controls
using NationalInstruments.TestStand.Interop.UI;

// .net specific functions for use with TestStand APIs (TSUtil)
using NationalInstruments.TestStand.Utility;

namespace RemoveOldInsertionPaletteItems
{       
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Engine engine;
            PropertyObjectFile configFile = null;
            PropertyObject configFileData = null;
            PropertyObject configFileTypeGroups = null;
            PropertyObject niVeriStandObj = null;
            PropertyObject sequenceLevelCommandsSpacesObj = null;
            PropertyObject sequenceLevelCommandsObj = null;
            PropertyObject advancedObj = null;
            PropertyObject guiObj = null;
            PropertyObject modelsObj = null;
            PropertyObject stimulusProfileObj = null;
            PropertyObject alarmsObj = null;
            PropertyObject channelFaultSpacesObj = null;
            PropertyObject veristandTestsObj = null;
            PropertyObject channelsObj = null;
            PropertyObject dataLoggingObj = null;
            PropertyObject rtSequenceObj = null;
            PropertyObject llProjectControlObj = null;
            PropertyObject llStimulusProfileControlObj = null;
            PropertyObject llRTSequenceControlObj = null;
            PropertyObject silentObj = null;
            PropertyObject channelFaultObj = null;
            PropertyObject stimulusProfileSpacesObj = null;
            PropertyObject loggingObj = null;

            System.Windows.Forms.Timer GCTimer = null;

            //List an array of the TypeGroups from TestExec.ini you would like to remove
            string[] typeGroupNames = { "[\"NI VeriStand\"]", "[\"Sequence Level Commands\"]", "[\"SequenceLevelCommands\"]", "[\"Advanced\"]", "[\"GUI\"]", "[\"Models\"]",
                                          "[\"StimulusProfile\"]", "[\"Alarms\"]", "[\"Channel Fault\"]", "[\"VeriStand Tests\"]", "[\"Channels\"]",
                                          "[\"Data Logging\"]", "[\"RT Sequence\"]", "[\"Low-Level Project Control\"]", "[\"Low-Level Stimulus Profile Control\"]",
                                          "[\"Low-Level RT Sequence Control\"]", "[\"Silent\"]", "[\"ChannelFault\"]", "[\"Stimulus Profile\"]", "[\"Logging\"]"};

            //List the corresponding TypeGroup PropertyObjects in the same order as the TypeGroup names array above
            PropertyObject[] typeGroupObjs = { niVeriStandObj, sequenceLevelCommandsSpacesObj, sequenceLevelCommandsObj, advancedObj, guiObj, modelsObj, stimulusProfileObj, 
                                                 alarmsObj, channelFaultSpacesObj , veristandTestsObj, channelsObj, dataLoggingObj, rtSequenceObj, llProjectControlObj,
                                             llStimulusProfileControlObj, llRTSequenceControlObj, silentObj, channelFaultObj, stimulusProfileSpacesObj, loggingObj};

            //Add ApplicationManager to hidden form to allow this Console Application to shutdown the Engine without seeing PropertyObject reference leaks.
            //The ApplicationManager allows us to receive a UI_Msg when everything is finished shutting down
            System.Windows.Forms.Form hiddenForm = new System.Windows.Forms.Form();
            NationalInstruments.TestStand.Interop.UI.Ax.AxApplicationMgr appMgr = new NationalInstruments.TestStand.Interop.UI.Ax.AxApplicationMgr();
            ((System.ComponentModel.ISupportInitialize)(appMgr)).BeginInit();
            hiddenForm.Controls.Add(appMgr);
            ((System.ComponentModel.ISupportInitialize)(appMgr)).EndInit();

            // If this UI is running in a CLR other than the one TestStand uses,
            // then it needs its own GCTimer for that version of the CLR. If it's running in the
            // same CLR as TestStand then the engine's gctimer enabled by the ApplicationMgr
            // is sufficient. See the API help for Engine.DotNetGarbageCollectionInterval for more details.
            if (System.Environment.Version.ToString() != appMgr.GetEngine().DotNetCLRVersion)
            {
                GCTimer.Enabled = true;
            }

            appMgr.LoginOnStart = false; //Do not show the TestStand Login dialog because this is a standalone tool, not a UI.
            appMgr.Start();
            
            engine = appMgr.GetEngine(); //Get the TestStand
            configFile = engine.ConfigFile;

            if (configFile.ReadFile(TypeConflictHandlerTypes.ConflictHandler_Error))
            {
                configFileData = configFile.Data;

                try
                {
                    configFileTypeGroups = configFileData.GetPropertyObject("TypeGroups", 0);
                    if (configFileTypeGroups.Exists("", 0))
                    {
                        for (int i = 0; i < typeGroupNames.Length; i++)
                        {
                            try
                            {
                               typeGroupObjs[i]  = configFileData.GetPropertyObject("TypeGroups" + typeGroupNames[i], 0);
                               if (typeGroupObjs[i].Exists("", 0))
                                {
                                    int n = configFileTypeGroups.GetArrayOffset("", 0, typeGroupNames[i]);
                                    configFileTypeGroups.DeleteElements(n, 1, 0);
                                }
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {
                                //do nothing
                            }
                            catch (System.NullReferenceException ex)
                            {
                                //do nothing
                            }
                            catch (System.IndexOutOfRangeException ex)
                            {
                                //do nothing
                            }
                        }
                    }
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    //do nothing
                }
                catch (System.NullReferenceException ex)
                {
                    //do nothing
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    //do nothing
                }
            }

            try
            {
                configFile.IncChangeCount();
                configFile.SaveFileIfModified(false);
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                //do nothing
            }
            catch (System.NullReferenceException ex)
            {
                //do nothing
            }
            catch (System.IndexOutOfRangeException ex)
            {
                //do nothing
            }
            finally
            {
                if (engine != null)
                {
                    engine.ShutDown(false);
                    while (appMgr.IsShuttingDown == true)
                    {
                        //Wait until ApplicationManager is finished shutdown
                    }
                    engine.ShutDown(true);
                }
            }
        }
        private void GCTimerTick(object sender, System.EventArgs e)
        {
            System.GC.Collect(); // force .net garbage collection		
        }
    }
}
