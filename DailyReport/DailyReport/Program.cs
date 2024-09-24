using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {//Title of assignment
            Console.WriteLine("Academy of Learning Career College \nStudent Daily Report");

        //What is your name?
            Console.WriteLine("What is your name?");
        //String data type to answer question
            string name = Console.ReadLine();

        //What course are you on?
            Console.WriteLine("What course are you on?");
        //String data type to answer question
            string course = Console.ReadLine();

        //What page number are you on?
            Console.WriteLine("What page number are you on?");
        //Int data type to enter numerical answer
            int page = Convert.ToInt32(Console.ReadLine());

        //Do you need help?
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        //Bool data type to enter true or false answer
            string help = Console.ReadLine();
            bool helpBool = bool.Parse(help);

        //Positive experience you'd like to share?
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        //String data type to answer question
            string experiences = Console.ReadLine();

        //Any other feedback?
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        //String data type to answer question
            string feedback = Console.ReadLine();

        //How many study hours today?
            Console.WriteLine("How many hours did you study today?");
        //Int data type for numerical answer
            int studyHours = Convert.ToInt32(Console.ReadLine());

        //Thanks for your time!
            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
