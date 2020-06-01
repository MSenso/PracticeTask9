using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask9
{
    public class Point
    {
        public int Number { get; set; }
        public Point Next;
        public Point()
        {
            Number = 1;
            Next = null;
        }
        public Point(int number)
        {
            Number = number;
            Next = null;
        }
    }
}
