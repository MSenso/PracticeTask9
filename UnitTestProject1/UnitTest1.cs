using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeTask9;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OneList list = new OneList(5);
            int index = 0;
            Point point = null;
            point = list.Search(1);
            point = list.Search(5);
            point = list.Search(6);
            point = list.Search(3);
            index = list.Search(new Point(1));
            index = list.Search(new Point(5));
            index = list.Search(new Point(6));
            index = list.Search(new Point(3));
            index = list.Search(new Point(4));
        }
    }
}
