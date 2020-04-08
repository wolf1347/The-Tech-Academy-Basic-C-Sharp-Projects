using System;

class Assignment3
{
    static void Main()
	{

		// startup line
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine(Environment.NewLine);

            //person 1
            Console.WriteLine("Please enter the details for Person 1");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("What is their Hourly Rate");
            double p1HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many Hours do they work per week");
            double p1HoursPerWeek = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Environment.NewLine);

            //person 2
            Console.WriteLine("Please enter the details for Person 2");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("What is their Hourly Rate");
            double p2HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many Hours do they work per week");
            double p2HoursPerWeek = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Environment.NewLine);

            //Comparison
            double p1total = p1HourlyRate * p1HoursPerWeek * 52;
            double p2total = p2HourlyRate * p2HoursPerWeek * 52;
            bool salaryCompare = p1total > p2total;
            Console.WriteLine("Annual Salary of Person 1:" + Environment.NewLine + p1total);
            Console.WriteLine("Annual Salary of Person 2:" + Environment.NewLine + p2total);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Does person 1 make more than person 2?" + Environment.NewLine + salaryCompare);
            Console.ReadLine();
	}
}