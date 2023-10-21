using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomEnumerable0 customEnumerable0 = new CustomEnumerable0();

            //customEnumerable0.CustomEnumerable();

            //CustomEnumerable customEnumerable = new CustomEnumerable();

            //foreach (var item in customEnumerable)
            //{
            //    Console.WriteLine(item);
            //}

            //Доработайте приложение поиска пути в лабиринте, но на этот раз вам нужно определить сколько всего выходов имеется в лабиринте:

            Homework homework = new Homework();

            int[,] labirynth1 = new int[,]
            {
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {0, 0, 0, 0, 1, 0, 2 },
            {1, 1, 0, 0, 1, 1, 1 },
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 1, 1, 1, 1, 1, 1 }
            };

            homework.HasExit(3, 0, labirynth1);

            Console.ReadKey();
        }
    }
}
