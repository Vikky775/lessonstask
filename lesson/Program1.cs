using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)/*найти два максимальных элемента массива*/
        {
            Console.WriteLine("Задайте динамиескую размерность массива: ");
            int arLength = int.Parse(Console.ReadLine());

            int[] massiv = new int[arLength];

            for (int a = 0; a < massiv.Length; a++)
            {
                Console.WriteLine("Введите число " + (a + 1) + ": ");
                massiv[a] = int.Parse(Console.ReadLine());
            }
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] > max1)
                {
                    max1 = massiv[i];
                }
            }
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] > max2 && massiv[i] < max1)
                {
                    max2 = massiv[i];
                }
            }
            Console.WriteLine("Первое максимальное число равно " + max1 + " , второе максимальное число - " + max2 + ".");
        }
    }
}
