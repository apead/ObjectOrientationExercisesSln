using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises.Inheritance
{
    internal class Student : Person
    {
        private string _studentId;
        private string _course;

        public Student(string name, int age, string gender, string idNumber, string studentId, string course) : base(name, age, gender, idNumber)
        {
            _studentId = studentId;
            _course = course;
        }

        public bool CanQualifyForCourse()
        {
            if (_age > 18 && _age < 35)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

    }
}
