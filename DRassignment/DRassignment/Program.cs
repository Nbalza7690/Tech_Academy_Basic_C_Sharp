using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string your_name = Console.ReadLine();
            Console.WriteLine("Your name is " + your_name);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course_name = Console.ReadLine();
            Console.WriteLine("Your course is " + course_name);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string page_number = Console.ReadLine();
            Console.WriteLine("Your page number is " + page_number);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help_tf = Console.ReadLine();
            Console.WriteLine("Do you need any help? " + help_tf);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
            string experiences = Console.ReadLine();
            Console.WriteLine("Your positive experiences were " + experiences);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("Your feedback is " + feedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            Console.WriteLine("Your total hours studied is " + hours);
            Console.ReadLine();

            Console.WriteLine("\"Thank you for your answers. An Instructor will respond to this shortly. Have a great day!\" This is the end of the program");
            Console.ReadLine();
        }
    }
}
