using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeTask9;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OneList list = new OneList(5);
            int index = list.Search(new Point(5));

            list.Add(new Point(1));
            list.Add(new Point(2));
            list.Add(new Point(10));
            list.Add(new Point(6));

            list.Remove(1);
            list.Remove(6);
            list.Remove(10);
            list.Remove(0);
            list.Remove(2);
            list.Remove(3);
            list.Remove(1);
            list.Remove(1);
            list.Remove(2);
            list.Remove(1);
            list.Remove(1);
            list.Remove(1);

            list = new OneList(5);

            list.Add(new Point(1));
            list.Add(new Point(2));
            list.Add(new Point(10));
            list.Add(new Point(6));

            list.Remove(new Point(1));
            list.Remove(new Point(11));
            list.Remove(new Point(10));
            list.Remove(new Point(2));
            list.Remove(new Point(3));
            list.Remove(new Point(4));
            list.Remove(new Point(5));
            list.Remove(new Point(6));
            list.Remove(new Point(1));
            list.Remove(new Point(4));
            list.Remove(new Point(2));
            list.Remove(new Point(1));
            list.Search(new Point(1));
            Point point = list.Search(1);

            list.Add(new Point(2));
            list.Add(new Point(10));
            list.Add(new Point(6));
            list.Add(new Point(1));

            point = list.Search(1);
            point = list.Search(0);
            point = list.Search(10);
            point = list.Search(4);
            point = list.Search(3);

            index = list.Search(new Point(1));
            index = list.Search(new Point(11));
            index = list.Search(new Point(2));
            string output = list.Show();
        }
    }
}
