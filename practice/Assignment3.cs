using System;

class Assignment3
{
    static void Main()
	{

		// Has the user do multiplication
		Console.WriteLine("Please input a number to multiply by 50");
		int userMultiply = Convert.ToInt32(Console.ReadLine());
		int programMultiply = 50;
		int multiplyAnswer = userMultiply * programMultiply;
		Console.WriteLine("50 * " + userMultiply + " is equal to " + multiplyAnswer);
		Console.ReadLine();

		//Has the user do addition
		Console.WriteLine("Please input a number to add 25 to");
		int userAdd = Convert.ToInt32(Console.ReadLine());
		int programAdd = 25;
		int addAnswer = userAdd + programAdd;
		Console.WriteLine("25 + " + userAdd + " is equal to " + addAnswer);
		Console.ReadLine();

		//Has the user do division with decimals
		Console.WriteLine("Please input a number to divide by 12.5");
		double userDivide = Convert.ToDouble(Console.ReadLine());
		double programDivide = 12.5;
		double divideAnswer = programDivide / userDivide;
		Console.WriteLine("12.5 / " + userDivide + " is equal to " + divideAnswer);
		Console.ReadLine();

		//Has the user check if a number is greater than
		
		Console.WriteLine("Please input a number to see if it is greater than 50");
		int programNumber = 50;
		int userNumber = Convert.ToInt32(Console.ReadLine()); ;
		bool GreaterThan = userNumber > programNumber;
		if (userNumber > programNumber)
		{
			Console.WriteLine("50 is > than " + userNumber + " so the boolean returned is " + GreaterThan);
			Console.ReadLine();
		}
		else
		{
			Console.WriteLine("50 is not > than " + userNumber + " so the boolean returned is " + GreaterThan);
			Console.ReadLine();
		}

		//Has the user divide and print a remainder

		Console.WriteLine("Please enter a number to divide by 7 and return the remainder");
		int userRemainder = Convert.ToInt32(Console.ReadLine());
		int programRemainder = 7;
		int remainderAnswer = programRemainder % userRemainder;
		int numberAnswer = programRemainder / userRemainder;
		Console.WriteLine("7 / " + userRemainder + " is equal to " + numberAnswer + " and leaves us with a remainder of " + remainderAnswer);
		Console.ReadLine();
	}
}