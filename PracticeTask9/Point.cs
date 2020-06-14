using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask9
{
    public class Point
    {
        public int Number { get; set; } // Информационное поле – число
        public Point Next; // Адресное поле – ссылка на следующий элемент
        public Point(int number) // Создание элемента списка
        {
            Number = number;
            Next = null;
        }
    }
}
