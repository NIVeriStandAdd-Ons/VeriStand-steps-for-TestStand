using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace OpenWorkspaceDialog
{
    public class StringUtilities
    {

        public static string unparseFilePathString(string filePath)
        {
            filePath = filePath.Replace("\\\\", "\\");
            filePath = filePath.Replace("\"", "");
            return filePath;
        }
        public static string addDoubleQuotesAroundString(string input)
        {
            if (input != "")
            {
                if (input.First() != '"')
                {
                    input = "\"" + input;
                }
                if (input.Last() != '"')
                {
                    input = input + "\"";
                }
            }
            return input;
        }
        public static string removeDoubleQuotesAroundString(string input)
        {
            return input.Replace("\"", "");
        }
        public static string parseFilePathString(string input)
        {
            if (input != "")
            {
                string pattern = @"(?<!\\)(?:((\\\\)*)\\)(?![\\/{])";  //change any single  backslash to a double backslash so it parses correctly in TestStand   
                Regex rgx = new Regex(pattern);

                input = rgx.Replace(input, @"\\");
                if (input.First() != '"')
                {
                    input = "\"" + input + "\"";
                }
            }
            return input;
         
        }
        public static string stringArrayToExpressionArray(string[] input)
        {
            if (input.Length > 0)
            {
                string output = "{";
                foreach (string singleString in input)
                {
                    output += StringUtilities.addDoubleQuotesAroundString(singleString) + ",";
                }
                output = output.Remove(output.Length - 1); //remove the last comma
                output += "}";
                return output;
            }
            else
            {
                return "{\"\"}";
            }
        }
        public static string[] expressionArrayToStringArray(string input)
        {
                       
            if (input != "")
            {
               
                if (input == "{}"||input=="{"||input=="}") //if the array is empty return an empty string
                {
                   return new string[0];
                }
                int numElements = input.Count(x => x == ',') + 1;
                string[] output = new string[numElements];
                input=input.Remove(0, 1); //remove first {
                input=input.Remove(input.Length - 1); //remove trailing }
                for (int i = 0; i < numElements; i++)
                {


                    if (input.IndexOf(",") > 0)
                    {
                        output[i] = input.Substring(0, input.IndexOf(",")); //get the element up to the comma
                        input = input.Remove(0, input.IndexOf(",") + 1); //remove the comma
                    }
                    else
                    {
                        output[i] = input;
                    }
                }
                return output;
            }
            return null;
        }
    }
}
