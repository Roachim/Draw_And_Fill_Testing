using System;

namespace Draw_And_Fill_Testing
{
    class Program
    {
        //Make TDD of a program that fills out an empty figure, by finding a point inside the figure an filling out from that point.
        static void Main(string[] args)
        {
            string[,] expectedResult = new string[10, 10];
            for (int x = 0; x < 10; x++)
            {

                for (int y = 0; y < 10; y++)
                {
                    if (x == 0 || x == 9)
                    {
                        expectedResult[x, y] = "B";
                    }
                    else if (y == 0 || y == 9)
                    {
                        expectedResult[x, y] = "B";
                    }
                    else
                    {
                        expectedResult[x, y] = " ";
                    }


                }
            }

            for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(expectedResult[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            
        }
    }
}
