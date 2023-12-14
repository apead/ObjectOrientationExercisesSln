using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises.Inheritance
{
    internal class Person
    {
        protected string _name;
        protected int _age;
        protected string _gender;
        protected string _idNumber;

        public Person(string name, int age, string gender, string idNumber)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _idNumber = idNumber;
        }

        public string GetName()
        {
            return _name;
        }

    }
}
