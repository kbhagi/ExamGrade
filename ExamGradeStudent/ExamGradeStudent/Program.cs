using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamGradeStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the percentage of Marks:");
            int grade = int.Parse(Console.ReadLine());
            if (grade >= 80 & grade < 100)
                Console.WriteLine("Your grade is A");
            else if (grade >= 60 & grade < 80)
                Console.WriteLine("Your grade is B");
            else if (grade >= 40 & grade < 60)
                Console.WriteLine("You are fail");
            Console.ReadLine();
        }
    }
}
