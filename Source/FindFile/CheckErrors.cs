using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

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

        public static bool isMaskInRightFormat(string mask)
        {
            Regex maskRegEx1 = new Regex(@"(
                                               ^\^?Name='[^/\:?""|]+$
                                           )
                                           |
                                           (
                                               ^\^?Length=\d+[kKmMgGg]?$
                                           )
                                           |
                                           (
                                                ^\d+[kKmMgGg]? (<=)|(<) Length (<=)|(<) \d+[kKmMgGg]?$
                                           )
                                           |
                                           (
                                                Content~[^~]
                                           )
                                           |
                                           (   ^
                                               \^?( \( Name='[^/\:?""|]+' \) )?
                                               [&|^]?
                                               (
                                                    ( \( Length=\d+[kKmMgGg]?  \) )
                                                    |
                                                    (  \(  ( \d+[kKmMgGg]? (<=)|(<) )? Length ( (<=)|(<) \d+[kKmMgGg]? )? \)  )
                                               )?
                                               [&|^]?
                                               ( \( Content~[^~] \) )?
                                               $
                                           )
                                            ",
                                            RegexOptions.IgnorePatternWhitespace);
            if (!maskRegEx1.IsMatch(mask))
            {
                return false;
            }
            return true;
        }
    }
}
