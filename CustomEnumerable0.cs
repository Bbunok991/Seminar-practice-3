using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class CustomEnumerable0
    {
        public void CustomEnumerable() 
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            Stack<int> stack = new Stack<int>();
            foreach (int i in list)
            {
                stack.Push(i);
            }
            Console.WriteLine("Source list: " + string.Join(", ", list));
            list.Clear();

            foreach (int i in stack)
            {
                list.Add(i);
            }
            Console.WriteLine("The resulting list: " + string.Join(", ", list));
        }
    }
}
