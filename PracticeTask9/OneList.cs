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
        public OneList()
        {
            list = new Point();
            Length = 1;
        }
        public OneList(Point point)
        {
            this.list = point;
            Length = 1;
        }
        public OneList(int size)
        {
            if (size >= 1)
            {
                list = new Point(1);
                for (int i = 2; i <= size; i++)
                {
                    Point current_point = new Point(i);
                    Add(current_point, list);
                    list = current_point;
                }
                Length = size;
            }
        }
        void Add(Point base_point, Point derived_point)
        {
            if (base_point != null)
            {
                base_point.Next = derived_point;
            }
        }
        public void Add(Point point)
        {
            if (point.Number < list.Number)
            {
                Point current_point = this.list.Next;
                Point previous_point = this.list;
                for (int i = 1; i <= Length && current_point != null; i++)
                {
                    if (point.Number < previous_point.Number && point.Number > current_point.Number)
                    {
                        point.Next = current_point;
                        previous_point.Next = point;
                        Length++;
                        break;
                    }
                    else
                    {
                        current_point = current_point.Next;
                        previous_point = previous_point.Next;
                    }
                }
            }
            else
            {
                Add(point, list);
                list = point;
                Length++;
            }
        }
        public bool Remove(Point point)
        {
            if (list != null)
            {
                Point current_point = list;
                if (point.Number == current_point.Number)
                {
                    list = list.Next;
                    Length--;
                    return true;
                }
                else
                {
                    for (int i = 1; i <= Length && current_point != null; i++)
                    {
                        if (current_point.Next != null)
                        {
                            if (point.Number == current_point.Next.Number)
                            {
                                current_point.Next = current_point.Next.Next;
                                Length--;
                                return true;
                            }
                        }
                        else return false;
                        current_point = current_point.Next;
                    }
                    return false;
                }
            }
            else return false;
        }
        public bool Remove(int index)
        {
            if (list != null)
            {
                if (index > 0 && index <= Length)
                {
                    if (index == 1)
                    {
                        list = list.Next;
                        Length--;
                        return true;
                    }
                    else
                    {
                        Point current_point = list;
                        for (int i = 1; i < index - 1 && current_point != null; i++)
                        {
                            current_point = current_point.Next;
                        }
                        current_point.Next = current_point.Next.Next;
                        Length--;
                        return true;
                    }
                }
                else return false;
            }
            else return false;
        }
        public int Search(Point point)
        {
            int index = -1;
            if (list != null)
            {
                Point current_point = list;
                if (point.Number == current_point.Number)
                {
                    index = 1;
                }
                else
                {
                    for (int i = 1; i <= Length && current_point != null; i++)
                    {
                        if (current_point.Next != null)
                        {
                            if (point.Number == current_point.Next.Number)
                            {
                                index = i + 1;
                                return index;
                            }
                        }
                        current_point = current_point.Next;
                    }
                }
            }
            return index;
        }
        public Point Search(int index)
        {
            Point point = null;
            if (list != null)
            {
                if (index > 0 && index <= Length)
                {
                    Point current_point = list;
                    for (int i = 1; i <= Length && current_point != null; i++)
                    {
                        if (index == i)
                        {
                            point = current_point;
                            return point;
                        }
                        current_point = current_point.Next;
                    }
                }
            }
            return point;
        }
        public string Show()
        {
            string output = "Список:";
            Point current_point = list;
            do
            {
                output += " " + current_point.Number.ToString();
                current_point = current_point.Next;
            } while (current_point != null);
            return output;
        }
    }
}
