using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Ввведите количество строк:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Ввведите количество столбцов:");
            int x = int.Parse(Console.ReadLine());

            int[,] aMatrix = new int[y, x];
            int[,] bMatrix = new int[y, x];

            Console.WriteLine("Заполните матрицу:");

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    aMatrix[i, j] = int.Parse(Console.ReadLine());
                }           
            }
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("{0}\t", aMatrix[i, j]);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Заполните вторую матрицу:");

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    bMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("{0}\t", bMatrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введите операцию: +, *, *n, ^, t");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "+":
                    int[,] plusMatrix = new int[aMatrix.GetLength(0), aMatrix.GetLength(1)];
                    for (int i = 0; i < aMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < aMatrix.GetLength(1); j++)
                        {
                            plusMatrix[i, j] = aMatrix[i, j] + bMatrix[i, j];
                        }
                    }
                    for (int i = 0; i < plusMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < plusMatrix.GetLength(1); j++)
                        {
                            Console.Write("{0}\t", plusMatrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                    break;

                case "*":
                    int[,] multiMatrix = new int[aMatrix.GetLength(0), bMatrix.GetLength(1)];
                    for (int i = 0; i < aMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < bMatrix.GetLength(1); j++)
                        {
                            for (int k = 0; k < bMatrix.GetLength(0); k++)
                            {
                                multiMatrix[i, j] += aMatrix[i, k] * bMatrix[k, j];                              
                            }
                        }
                    }
                    for (int i = 0; i < multiMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < multiMatrix.GetLength(1); j++)
                        {
                            Console.Write("{0}\t", multiMatrix[i, j]);
                        }
                        Console.WriteLine();
                    }

                    break;

                case "*n":
                    Console.WriteLine("Введите число:");
                    int num = int.Parse(Console.ReadLine());
                    int[,] nMatrix = new int[aMatrix.GetLength(0), aMatrix.GetLength(1)];
                    for (int i = 0; i < aMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < aMatrix.GetLength(1); j++)
                        {
                            nMatrix[i, j] = aMatrix[i, j] * num;
                        }
                    }
                    for (int i = 0; i < nMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < nMatrix.GetLength(1); j++)
                        {
                            Console.Write("{0}\t", nMatrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                    break;

                case "^":

                    break;

                case "t":
                    int[,] tMatrix = new int[aMatrix.GetLength(0), aMatrix.GetLength(1)];
                    for (int i = 0; i < aMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < aMatrix.GetLength(1); j++)
                        {
                            tMatrix[i, j] = aMatrix[j, i];
                            Console.Write("{0}\t", tMatrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine("Неверная операция");
                    break;
            }
        }
    }
}
