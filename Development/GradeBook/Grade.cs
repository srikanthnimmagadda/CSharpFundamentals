using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    internal class Grade
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly List<double> _grades;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grades"></param>
        public Grade(List<double> grades)
        {
            _grades = grades;
        }

        public double Total()
        {
            var result = 0.0;

            foreach (var grade in _grades)
            {
                result += grade;
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double Average()
        {
            var total = Total();
            return total / _grades.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double MinGrade()
        {
            return _grades.Min();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double MaxGrade()
        {
            return _grades.Max();
        }
    }
}
