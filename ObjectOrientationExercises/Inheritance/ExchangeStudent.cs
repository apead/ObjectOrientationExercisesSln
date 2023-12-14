using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises.Inheritance
{
    internal class ExchangeStudent : Student
    {
        private string _countryOfOrigin;
        public ExchangeStudent(string name, int age, string gender, string idNumber, string studentId, string course, string countryOfOrigin) : base(name, age, gender, idNumber, studentId, course)
        {
            _countryOfOrigin = countryOfOrigin;
        }
    }
}
