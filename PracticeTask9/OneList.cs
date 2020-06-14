using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask9
{
    public class OneList
    {
        Point list;
        static Random random = new Random();
        public int Length { get; private set; }
        public OneList(int size)
        {
            list = new Point(1); // Создание первого элемента
            for (int i = 2; i <= size; i++)
            {
                Point current_point = new Point(i); 
                current_point.Next = list; // Ссылка текущего элемента указывает на list
                list = current_point; // list заменяется текущим элементом
            }
            Length = size;

        }
        public void Add(Point point) // Добавление элемента
        {
            if (list == null) // Список пустой
            {
                list = point; // Добавляемый элемент становится первым
                Length++;
            }
            else
            {
                if (point.Number < list.Number) // Значение элемента меньше значения первого элемента
                {
                    Point previous_point = this.list.Next; // Ссылка на предыдущий элемент
                    Point current_point = this.list; // Ссылка на первый элемент
                    for (int i = 1; i <= Length & previous_point != null; i++)
                    {
                        if (point.Number < current_point.Number && point.Number > previous_point.Number) // Значение элемента находится между текущим и предыдущим
                        {
                            point.Next = previous_point; // Ссылка элемента указывает на предыдущий
                            current_point.Next = point; // Ссылка текущего элемента указывает на элемент
                            Length++;
                            break;
                        }
                        if (previous_point.Next != null)
                        {
                            // Перестановка ссылок для прохождения по списку
                            previous_point = previous_point.Next;
                            current_point = current_point.Next;
                        }
                        else
                        {
                            previous_point.Next = point; // Доабвление в конец
                            Length++;
                            break;
                        }
                    }
                }
                else
                {
                    point.Next = list; // Добавление в начало
                    list = point;
                    Length++;
                }
            }
        }
        public bool Remove(Point point) // Удаление по значению
        {
            if (list != null) // Список не пустой
            {
                Point current_point = list;
                if (point.Number == current_point.Number) // Удаление первого элемента
                {
                    list = list.Next;
                    Length--;
                    return true;
                }
                else
                {
                    for (int i = 1; i <= Length & current_point != null; i++)
                    {
                        if (current_point.Next != null) // Впереди не последний элемент
                        {
                            if (point.Number == current_point.Next.Number) // Значение элемента равно значению элемента, следующего за текущим
                            {
                                current_point.Next = current_point.Next.Next; // Удаление ссылки на следующий элемент
                                Length--;
                                return true;
                            }
                        }
                        current_point = current_point.Next; // Прохождение по списку
                    }
                    return false;
                }
            }
            else return false;
        }
        public bool Remove(int index) // Удаление по номеру
        {
            if (list != null) // Список не пустой
            {
                if (index > 0 && index <= Length) // Индекс от 1 до количества элементов в списке
                {
                    if (index == 1) // Удаление первого элемента
                    {
                        list = list.Next;
                        Length--;
                        return true;
                    }
                    else
                    {
                        Point current_point = list; // Ссылка на первый элемент
                        for (int i = 1; i < index - 1 && current_point != null; i++)
                        {
                            current_point = current_point.Next; // Прохождение по списку, пока следующим элементом не станет удаляемый
                        }
                        current_point.Next = current_point.Next.Next; // Удаление ссылки на следующий элемент
                        Length--;
                        return true;
                    }
                }
                else return false;
            }
            else return false;
        }
        public int Search(Point point) // Поиск по значению
        {
            int index = -1;
            if (list != null) // Список не пустой
            {
                Point current_point = list;
                for (int i = 1; i <= Length && current_point != null; i++)
                {
                    if (current_point.Next != null) // Следующий элемент не последний
                    {
                        if (point.Number == current_point.Next.Number) // Значение элемента равно значению следующего за текущим элемента
                        {
                            index = i + 1; // Индекс следующего элемента
                            return index;
                        }
                    }
                    current_point = current_point.Next; // Прохождение по списку
                }
            }
            return index;
        }
        public Point Search(int index) // Поиск по номеру
        {
            Point point = null;
            if (list != null) // Список не пустой
            {
                if (index > 0 & index <= Length) // Индекс от 1 до количества элементов
                {
                    Point current_point = list;
                    for (int i = 1; i <= Length & current_point != null; i++)
                    {
                        if (index == i) // Индекс равен i
                        {
                            point = current_point; // Текущий элемент и есть искомый
                            return point;
                        }
                        current_point = current_point.Next; // Прохождение по списку
                    }
                }
                return point;
            }
            return point;
        }
        public string Show() // Вывод списка
        {
            string output = "Список:";
            Point current_point = list;
            while(current_point != null)
            {
                output += " " + current_point.Number.ToString(); // Добавление значения текущего элемента в выходную строку
                current_point = current_point.Next; // Прохождение по списку
            }
            return output;
        }
    }
}
