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
            


            Console.ReadKey();
        }
    }
}
