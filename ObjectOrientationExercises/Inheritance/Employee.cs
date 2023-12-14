using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises.Inheritance
{
    internal class Employee : Person
    {
        private string _employeeId;
        public Employee(string name, int age, string gender, string idNumber, string employeeId) : base(name, age, gender, idNumber)
        {
            _employeeId = employeeId;
        }
    }
}
