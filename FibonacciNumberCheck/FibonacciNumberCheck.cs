using System;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciNumberCheck
{
    class FibonacciNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the nth number");
            int some = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter 1 to print nth number in fibonacci series, 2 to find if the number is fibonacci or not.");
			int choose = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(fibonacci(some, choose));
        }

		public static string fibonacci(int f, int option)
		{

			bool Yes = false;

			int a = 0;
			int b = 1;
			int next;
			int closestNumb = 0;

			int totalLoop;

			List<int> FbList = new List<int>();

			//As we are creating a fibonacci series list with the index int we received. 
			//Hence, if the user input is less than 5, the list would not be enough to search the given number.
			//so having an if condition would make sure the list is atleast 5 index long.
			if (f < 5)
			{
				totalLoop = 5;
			}
			else
			{
				totalLoop = f;
			}


			//Generating fibonacci series and adding it to the Fblist.
			for (int i = 0; i <= totalLoop; i++)
			{
				FbList.Add(a);
				next = a + b;
				a = b;
				b = next;
			}

			//creating an int with the difference of given number from the first element of the list
			int closer = Math.Abs(FbList[0] - f);

			//looping through the list and comparing if given number is present in the list, if it is then return true as a fibonacci
			//if it is not present in the list, finding the absolute difference between the given number and the one in the list.
			//the minimal difference would help to find the closest number.
			foreach (int j in FbList)
			{
				if (j == f)
				{
					Yes = true;
				}
				else
				{
					int ab = Math.Abs(j - f);
					if (ab < closer)
					{
						closer = ab;
						closestNumb = j;
					}

				}

			}

			if (option == 1)
			{
				Console.WriteLine("The nth number in the fibonacci sequence is "+ FbList[f]);

			}
			else if (option == 2)
			{
				if (Yes == true)
				{
					Console.WriteLine("It is a Fibonacci number");
				}
				else
				{

					//finding the index of the closest number and displaying to the ui.
					int index = FbList.IndexOf(closestNumb);
					Console.WriteLine("It is not a Fibonacci number. But its closest Fibonacci number's index is  " + index);
				}

			}
			else
            {
				Console.WriteLine("Invalid Option!!!");
            }

			

			return "";

		}



	}
}
