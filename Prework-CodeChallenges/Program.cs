using System;
using System.Linq;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter the number of rows");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the number of columns");
            int columns = int.Parse(Console.ReadLine());

            System.Random random = new System.Random();
            int[,] newArray = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int y = 0; y < columns; y++)
                {
                    int number = random.Next(0, 10);

                    newArray[i, y] = number;

                }
            }
            Console.WriteLine(string.Join(",",newArray.Cast<int>()));

            int[] sum = new int [rows];
            for (int x = 0; x < rows; x++)
            {
                for (int a = 0; a < columns; a++)
                {
                    sum[x] += newArray[x,a];
                }
            }

            Console.WriteLine(string.Join("," ,sum));

           
        }
    }
}
