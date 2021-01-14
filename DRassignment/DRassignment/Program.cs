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
            Console.WriteLine("The Tech Academy \nStudent Daily Report\nPlease press enter to continue\n");
            Console.ReadLine();

            Console.WriteLine("What is your name?"); // string
            string your_name = Console.ReadLine();
            Console.WriteLine("\nYour name is " + your_name + "\n\n");

            Console.WriteLine("What course are you on?"); // string
            string course_name = Console.ReadLine();
            Console.WriteLine("\nYour course is " + course_name + "\n\n");

            Console.WriteLine("What page number?\nPlease use numbers only"); // int
            int page_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour page number is " + page_number + "\n\n");
            
            Console.WriteLine("Do you need help with anything?\nPlease answer \"true\" or \"false\""); // bool
            bool help_tf = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\nYou said you need assistance " + help_tf + "\n\n"); 

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics"); // string
            string experiences = Console.ReadLine();
            Console.WriteLine("\nYour positive experiences were " + experiences + "\n\n");

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific"); // string
            string feedback = Console.ReadLine();
            Console.WriteLine("\nYour feedback is " + feedback + "\n\n");

            Console.WriteLine("How many hours did you study today?\nPlease use numbers only"); // int
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour total hours studied is " + hours + "\n\n"); 

            Console.WriteLine("\"Thank you for your answers. An Instructor will respond to this shortly. Have a great day!\" This is the end of the program");
            Console.ReadLine();
        }
    }
}
