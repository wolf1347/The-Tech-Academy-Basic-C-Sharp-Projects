using System;

    class Program
    {
    // exception handling
    static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("Pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine("The answer is " + numberThree);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Unable to divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
        


        }
    }

