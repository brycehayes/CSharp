using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

           var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.showStatistics();
            
        //    var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};;
        //    grades.Add(56.1);
           

        //    var result = 0.0;
        //    var highGrade = double.MinValue;
        //    var lowGrade = double.MaxValue;
        //    foreach(var number in grades) {
        //        if(number > highGrade) {
        //            highGrade = number;
        //        }
        //        if (number < lowGrade) {
        //            lowGrade = number;
        //        } 

        //        result = result + number;
        //    }

        //     System.Console.WriteLine($"Average grade is:  {result/grades.Count:N3}");
        //     System.Console.WriteLine("Result of arrays is: " + result);
        //     System.Console.WriteLine("Highest Grade: " + highGrade);
        //     System.Console.WriteLine("Lowest Grade: " + lowGrade);
            
        }
    }
}
