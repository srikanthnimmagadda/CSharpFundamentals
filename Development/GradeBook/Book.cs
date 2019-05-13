using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        /// <summary>
        /// 
        /// </summary>
        private List<double> _grades;
        public string Name;

        /// <summary>
        /// 
        /// </summary>
        public Book(string name)
        {
            _grades = new List<double>();
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grade"></param>
        public void AddGrade(double grade)
        {
            _grades.Add(grade);
        }

        /// <summary>
        /// 
        /// </summary>
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            foreach (var grade in _grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= _grades.Count;
            return result;
        }
    }
}
