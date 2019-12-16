using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FindFile
{
    public class CheckErrors
    {
        public static bool isPathExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Error.SetError("Path doesn't exists");
                return false;
            }

            return true;
        }
    }
}
