using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindFile;

namespace VisualTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl = new Client();
            cl.Find(@"C:\Users\User\Desktop\Repos\newFindFile\Source\FindFile.Test\TestFolder2", "Name='qwer.txt'");
            foreach (var elem in Client.result)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
