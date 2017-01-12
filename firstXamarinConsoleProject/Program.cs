using System;

namespace firstXamarinConsoleProject
{
	class MainClass
	{
		public static void Main()
		{
			int expressionChoice;

			Console.WriteLine("\nPlease choose what type equation you'd like to complete\n1.) Addition");
			Console.WriteLine("\n2.) Subtraction");
			Console.WriteLine("\n3.) Multiplication");
			Console.WriteLine("\n4.) Division\n");
			expressionChoice = Convert.ToInt32(Console.ReadLine());

			if (expressionChoice == 1)
			{
				int num01;
				int num02;
				int finalNum;
				Console.Write("\nEnter First Number: ");
				num01 = Convert.ToInt32(Console.ReadLine());
				Console.Write("\nEnter Second Number: ");
				num02 = Convert.ToInt32(Console.ReadLine());
				finalNum = num01 + num02;
				Console.WriteLine(num01 + " + " + num02 + " equals: " + finalNum);
			}
			else if (expressionChoice == 2)
			{
				int num01;
				int num02;
				int finalNum;
				Console.Write("\nEnter First Number: ");
				num01 = Convert.ToInt32(Console.ReadLine());
				Console.Write("\nEnter Second Number: ");
				num02 = Convert.ToInt32(Console.ReadLine());
				finalNum = num01 - num02;
				Console.WriteLine(num01 + " - " + num02 + " equals: " + finalNum);
			}
			else if (expressionChoice == 3)
			{
				int num01;
				int num02;
				int finalNum;
				Console.Write("\nEnter First Number: ");
				num01 = Convert.ToInt32(Console.ReadLine());
				Console.Write("\nEnter Second Number: ");
				num02 = Convert.ToInt32(Console.ReadLine());
				finalNum = num01 * num02;
				Console.WriteLine(num01 + " * " + num02 + " equals: " + finalNum);
			}
			else if (expressionChoice == 4)
			{
				int num01;
				int num02;
				int finalNum;
				Console.Write("\nEnter First Number: ");
				num01 = Convert.ToInt32(Console.ReadLine());
				Console.Write("\nEnter Second Number: ");
				num02 = Convert.ToInt32(Console.ReadLine());
				finalNum = num01 / num02;
				Console.WriteLine(num01 + " / " + num02 + " equals: " + finalNum);
			}

			char again;
			Console.Write("\nWould you like to solve another equation? (y/n) ");
			again = Convert.ToChar(Console.ReadLine());
			if (again == 'y')
			{
				firstXamarinConsoleProject.MainClass.Main();
			}
			else
			{
				Console.WriteLine("\nThanks for using Ben's Calculator! Please come back soon!");
				Environment.Exit(0);
			}
		}
	}
}
