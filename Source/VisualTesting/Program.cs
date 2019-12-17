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
<<<<<<< HEAD
            Client cl = new Client();
            cl.Find(@"C:\Users\User\Desktop\Repos\newFindFile\Source\FindFile.Test\TestFolder2", "Content~'Anime'");
            foreach (var elem in Result.result)
            {
                Console.WriteLine(elem);
            }
            Result.result.Clear();

            FindFile.File fl = new FindFile.File(@"C:\dev\02\index.php");
            fl.SetContentAndLenFromFile();
            Console.WriteLine((string)fl);
            
=======
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
>>>>>>> 98f5092b6652f5978e8341155bf52f41df94e72e
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
