using System;
using System.Collections.Generic;
using System.Text;

namespace FindFile
{
    public class Error
    {
        private static string errorMsg = "";
        private static bool isError = false;

        public static bool IsError()
        {
            return Error.isError == true ? true : false;
        }

        public static void SetError(string msg)
        {
            Error.isError = true;
            Error.errorMsg = msg;
        }

        public static void RemoveError()
        {
            Error.isError = false;
            Error.errorMsg = "";
        }

        public static string GetErrorMsg()
        {
            return Error.errorMsg;
        }
    }
}
