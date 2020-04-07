using System;

class SampleApplication
{
    static void Main()
    {
		
            //Have the console ask what course you are on
            Console.WriteLine("What course are you on?");
            string myCourse = Console.ReadLine();
            
            //have the console ask what page number
            Console.WriteLine("What page number are you on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            
            //ask the user if they need help
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            
            //ask the user about their experiences
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string userExperience = Console.ReadLine();
            
            //ask the user about feedback 
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string userFeedback = Console.ReadLine();
            
            //ask the user about hours studied 
            Console.WriteLine("How many hours did you study today?");
            float hoursStudied = Convert.ToInt32(Console.ReadLine());
      
            //write back to the user once all questions are answered
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
    }
}
