using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        private List<double> grades;

        double lowGrade = double.MaxValue;
        double highGrade = double.MinValue;
        double result = 0.0;

        public Book() {
            grades = new List<double>();
        }
        public void AddGrade(double grade) {
            grades.Add(grade);
        }

        public void showStatistics() {

            foreach(double grade in grades) {
            
                if(grade > highGrade) {
                    highGrade = grade;
                }
                if(grade < lowGrade) {
                    lowGrade = grade;
                }

                result = result + grade;

            }
            System.Console.WriteLine("Test");
             System.Console.WriteLine($"The average Result is {result/grades.Count}");
             System.Console.WriteLine($"The highest grade is: {highGrade}");
             System.Console.WriteLine($"The lowest grade is: {lowGrade}");
        }
    }
}