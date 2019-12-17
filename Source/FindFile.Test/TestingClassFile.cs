using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindFile;

namespace Testing
{
    [TestClass]
    public class Class_File
    {
        [TestMethod]
        public void GetAndSetMethods()
        {
            File file3 = new File("DreamTeam.txt");
            file3.SetContent("Sun and moon");
            file3.SetLength((UInt64)100000);
            Assert.AreEqual(file3.GetName(), "DreamTeam.txt");
            Assert.AreEqual(file3.GetLength(), (UInt64)100000);
            Assert.AreEqual(file3.GetContent(), "Sun and moon");
        }


    }
}
