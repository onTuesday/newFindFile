using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindFile;

namespace Testing
{
    
    [TestClass]
    public class TestingMaskHandler
    {
        [TestMethod]
        public void Test1()
        {
            File file = new File(@"Source\FindFile.Test\TestFolder1\picture.jpg");
            file.SetContentAndLenFromFile();
            MaskHandler maskH = new MaskHandler("Name~'pic*.jpg'");
            bool res = maskH.CompareWithExpression(file);
            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void Test2()
        {
            File file = new File(@"Source\FindFile.Test\TestFolder2\qwer.txt");
            file.SetContentAndLenFromFile();
            MaskHandler maskH = new MaskHandler("Name ~ '*er.txt'");
            bool res = maskH.CompareWithExpression(file);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void Test3()
        {
            File file = new File(@"Source\FindFile.Test\TestFolder2\qwer.txt");
            file.SetContentAndLenFromFile();
            MaskHandler maskH = new MaskHandler("Content ~ 'Anime'");
            bool res = maskH.CompareWithExpression(file);
            Assert.AreEqual(true, res);
        }

    }
}
