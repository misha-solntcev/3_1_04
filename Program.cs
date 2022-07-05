using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 4
В одномерном массиве, состоящем из n целых элементов, вычислить:
 номер максимального элемента массива;
 произведение элементов массива, расположенных между первым и вторым нулевыми элементами */

namespace _3_1_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elems = new int[] { 1, 21, 0, 2, 4, 5, 0, 6, 0, 8 };

            // Номер максимального элемента массива:
            int max = elems[0];
            int num = 0;
            for (int i = 0; i < elems.Length; i++)
                if (elems[i] > max)
                {
                    max = elems[i];
                    num = i;
                }
            Console.WriteLine($"max = {max}, num = {num}");

            // Первый нулевой элемент массива:
            int first = 0;
            for (int i = 0; i < elems.Length; i++)
                if (elems[i] == 0)
                {
                    first = i;
                    break;
                }
            Console.WriteLine($"first = {first}");

            // Второй нулевой элемент массива:
            int second = 0;
            for (int i = first + 1; i < elems.Length; i++)
                if (elems[i] == 0)
                {
                    second = i;
                    break;
                }
            Console.WriteLine($"second = {second}");

            // Произведение
            int prod = 1;
            for (int i = first + 1; i < second; i++)
                prod *= elems[i];
            Console.WriteLine($"prod = {prod}");

            Console.ReadKey();
        }
    }
}
