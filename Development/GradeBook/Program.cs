using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("New Book");
            book.AddGrade(50);
            book.AddGrade(60.50);
            book.AddGrade(70.90);
            book.AddGrade(80.50);
            book.AddGrade(90.10);

            var statistics = book.GetStatistics();
            Console.WriteLine($"The Average Grade is: {statistics.Average:N2}");
            Console.WriteLine($"The Lowest Grade is: {statistics.Low}");
            Console.WriteLine($"The Highest Grade is: {statistics.High}");

            //Console.WriteLine("Enter grades seperated by comma(,)");
            //string userInput = Console.ReadLine();
            //List<double> gradesList = new List<double>();

            //foreach (var item in userInput.Split(',').ToList())
            //{
            //    gradesList.Add(Convert.ToDouble(item));
            //}

            //Grade grade = new Grade(gradesList);
            //Console.WriteLine($"Total: {grade.Total()}");
            //Console.WriteLine($"Average: {grade.Average():N2}");
            //Console.WriteLine($"Min: {grade.MinGrade()}");
            //Console.WriteLine($"Max: {grade.MaxGrade()}");
            Console.ReadLine();
        }
    }
}
