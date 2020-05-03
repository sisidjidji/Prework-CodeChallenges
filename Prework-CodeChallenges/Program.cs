using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = new int[5];

            Console.WriteLine("Please input 5 numbers. Press 'ENTER' after each number.");

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please Enter the number that you want to check");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for (int x=0;x<5;x++)
            {
              

                if (newArray[x] == num)
                {
                    count++;
                }
                
            }

            var result = num * count;

            Console.Write("the result is " +result);
            Console.ReadLine();


        }


    }
}
