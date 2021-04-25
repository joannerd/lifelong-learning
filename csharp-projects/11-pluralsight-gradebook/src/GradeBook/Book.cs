using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    // `this` = I am the sender
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public event GradeAddedDelegate GradeAdded;

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;
            return result;
        }

    // Field definition (local state):
    // - can't use implicit typing (var)
    // List<double> grades = new List<double>(); <-- alternative to setting variable in constructor
        private List<double> grades;
        // Public field
        // public string Name;

        // Property member syntax (longhand)
        // private string name;
        // public string Name
        // {
        //     get
        //     {
        //         return name.ToUpper();
        //     }
        //     set
        //     {
        //         if(!String.IsNullOrEmpty(value))
        //         {
        //             name = value; // implicit variable `value` available in all setters
        //         }
        //     }
        // }

        // Auto property (shorthand)
        public string Name { get; set; }

    }
}