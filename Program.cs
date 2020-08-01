using System;

namespace _5_2_Lab_Enum_to_do_List
{
    class Program
    {
        // defining enum - days of the week
        public enum WeekDays { 
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Create a list to hold tasks
            List<string> tasklist = new List<string>();
            //Loop through each week day so user can enter task
            foreach (WeekDays   day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task for " + day);
                string task = day + " : " + Console.ReadLine();
                tasklist.Add(task);
            }
            //Print out to screen the task list.
            foreach (string task in tasklist)
            {
                Console.WriteLine(task);
            }

        }
    }
}
