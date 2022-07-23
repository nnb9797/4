using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗАДАЧИ_К_СЕМИНАРУ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Zadacha25()

            { // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
              // 3, 5-> 243(3⁵)
              // 2, 4-> 16
                Console.Write("Введите число А: ");
                double x = Convert.ToDouble(Console.ReadLine());
                double S = 1;
                Console.Write("Введите число В: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    S *= x;
                }
                Console.WriteLine("Число А в степени В = "+S );                                

                Console.ReadKey();
            }

            void Zadacha27()
            {
                // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
                // 452-> 11
                // 82-> 10
                // 9012-> 12
                Console.Write("Введите число: ");
                int x = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = x; i >= 0; i--)
                {
                    sum += x / (int)Math.Pow(10.0, i);
                    x %= (int)Math.Pow(10.0, i);
                }
                Console.WriteLine("Сумма цифр данного числа = " + sum);

                Console.ReadKey();
            }
            void Zadacha29()
            {
                // Напишите программу, которая задаёт массив из 8 элементов и выводит отсортированный по модулю массив.
                // -2,1, 5, 7, 19-> [1, -2, 5, 7, 19]
                // - 33, 6,1-> [6, 1, -33]

                int [] arr = { -2, 1, 5, 7, 19 };
                for (int i = 0; i < arr.Length; i++)
                {

                    for (int j = i; j < arr.Length; j++)
                    {
                        if (Math.Abs(arr[i]) < Math.Abs(arr[j]))
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }

                    }
                    Console.Write(arr[i] + ",");
                }

                    Console.ReadKey();
            }
            //Zadacha29();
            //Zadacha27();
            //Zadacha25();
        }
    }
}
       

