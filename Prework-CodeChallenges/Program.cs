using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = new int[3];

            Console.WriteLine("Please input  numbers. Press 'ENTER' after each number.");
            var sum = 0;
            var mult = 1;

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = Convert.ToInt32(Console.ReadLine());
                sum += newArray[i];
                mult = mult * newArray[i];

            }

            if (sum == mult)
            {
                Console.WriteLine("the array you entered  is a perfect array");
            }

            else
            {
                Console.WriteLine("the array you entered is not a perfect array");
            }

            

            
            Console.ReadLine();


        }


    }
}
