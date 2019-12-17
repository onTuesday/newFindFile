using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindFile;
using System.IO;
using System.Text.RegularExpressions;

namespace VisualTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex maskRegEx1 = new Regex(@"(   ^
                                               ( \( Name='[^/\:?""|]+' \) )?
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
            Console.WriteLine(maskRegEx1.IsMatch("(Name='qq')|(Length=10)&(Content!'qq')"));                           
        }

        public static void RecursivePrint(string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path);
                string[] dirs = Directory.GetDirectories(path);
                foreach (var file in files)
                    Console.WriteLine(file);
                foreach (var dir in dirs)
                    RecursivePrint(dir);
            }
            catch(Exception)
            {}
        }
    }
}
