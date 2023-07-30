using System;

namespace project
{
    class programm
    {
        static void Main(string[] args)
        {

            void WriteArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] / 10 <= 0)
                            Console.Write($" {array[i, j]} ");

                        else Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            void Sort(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1) - 1; k++)
                        {
                            if (array[i, k] < array[i, k + 1])
                            {
                                int temp = array[i, k + 1];
                                array[i, k + 1] = array[i, k];
                                array[i, k] = temp;

                            }
                        }
                    }
                }
            }
            int Vvod(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }
            void task1()
            {
                int a = Vvod("Введите количество строк ");
                int b = Vvod("Введите количество столбцов ");
                int[,] CreateArray = new int[a, b];
                Random rand = new Random();
                int i, j;
                for (i = 0; i < CreateArray.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (j = 0; j < CreateArray.GetLength(1); j++)
                    {
                        CreateArray[i, j] = rand.Next(1, 10);
                        Console.Write($"  {CreateArray[i, j]} ");
                    }
                    Console.WriteLine();
                }

                Sort(CreateArray);

                Console.WriteLine("\n Отсортированный массив: ");

                for (i = 0; i < CreateArray.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (j = 0; j < CreateArray.GetLength(1); j++)
                    {
                        Console.Write($"  {CreateArray[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            //task1();

            void task2()  //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            {
                int a = Vvod("Введите количество строк ");
                int b = Vvod("Введите количество столбцов ");

                int[,] CreateArray = new int[a, b];

                Random rand = new Random();
                int i, j;
                for (i = 0; i < CreateArray.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (j = 0; j < CreateArray.GetLength(1); j++)
                    {
                        CreateArray[i, j] = rand.Next(1, 10);
                        Console.Write($"  {CreateArray[i, j]} ");
                    }
                    Console.WriteLine();
                }


                int SummLine(int[,] CreateArray, int i)
                {
                    int sum = CreateArray[i, 0];
                    for (int j = 1; j < CreateArray.GetLength(1); j++)
                    {
                        sum += CreateArray[i, j];
                    }
                    return sum;
                }
                int min = 1;
                int sum = SummLine(CreateArray, 0);
                for (int k = 1; k < CreateArray.GetLength(0); k++)
                {
                    if (sum > SummLine(CreateArray, k))
                    {
                        sum = SummLine(CreateArray, k);
                        min = k + 1;
                    }


                }
                Console.WriteLine($"\n Строка c наименьшей суммой элементов: {min}");



            }
            // task2();

            void task3()
            {
                int n = 4;
                int[,] CreateArray = new int[n, n];
                int temp = 1;
                int i = 0;
                int j = 0;
                while (temp <= CreateArray.GetLength(0) * CreateArray.GetLength(1))
                {
                    CreateArray[i, j] = temp;
                    temp++;
                    if (i <= j + 1 && i + j < CreateArray.GetLength(1) - 1)
                        j++;
                    else if (i < j && i + j >= CreateArray.GetLength(0) - 1)
                        i++;
                    else if (i >= j && i + j > CreateArray.GetLength(1) - 1)
                        j--;
                    else
                        i--;
                }

                WriteArray(CreateArray);
            }
            task3();






        }
    }
}