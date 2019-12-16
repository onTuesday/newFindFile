using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindFile;
using System.IO;

namespace VisualTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl = new Client();
            cl.Find(@"C:\Users\User\Desktop\Repos\newFindFile\Source\FindFile.Test\TestFolder2", "Content~'Anime'");
            foreach (var elem in Result.result)
            {
                Console.WriteLine(elem);
            }
            Result.result.Clear();
            cl.Find(@"C:\dev", "Content ~ Anime31");
            foreach (var elem in Result.result)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine(Error.GetErrorMsg());
            
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
