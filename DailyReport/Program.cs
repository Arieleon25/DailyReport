using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            string ttA = "The Tech Academy";
            Console.WriteLine(ttA);

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is: " + yourCourse);

            int pageNum = 0;
            Console.WriteLine("What page number?");
            pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your page number is: " + pageNum);

            bool needHelp = true;
            Console.WriteLine("Do you need help with anthing? Please answer \" true \" or \"false\"");
            string needHelpstatus = Convert.ToString(needHelp);
            Console.WriteLine("Your answer is: " + needHelp);

            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("You responded: " + positiveExp);

            Console.WriteLine("Is the any feedback you'd like to provide? Please be specific");
            string feedBack = Console.ReadLine();
            Console.WriteLine("You responded: " + feedBack);

            int stuHours = 0;
            Console.WriteLine("How many hourse did you study today?");
            stuHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You studied: " + stuHours);

            string tnks = "Thank you for you answers. An Instructor will respond to this shortly. Have a great day!";
            Console.WriteLine(tnks);

            Console.ReadLine();

      
        }
    }
}
