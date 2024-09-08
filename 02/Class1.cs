using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Humanity
{
    class Person
    {
        private string name;
        private string lastname;

        public Person(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

    }


    class Student : Person
    {
        private int numFac;

        public Student(string name, string lastname, int numFac)
            : base (name, lastname)
        {
            
        }

        
    }

    class Employee : Person
    {
        private float salary;
        private int WorkCount;

        public Employee(string name, string lastname, float salary, int WorkCount) 
            : base(name, lastname)
        {
            this.salary = salary;
            this.WorkCount = WorkCount;
        }

        public float Salaryperhour()
        {
            float total = 0.0f;
            float CountOfWeek = WorkCount * 5;
            total = (salary /  CountOfWeek);
            return total;
        }

    }
}
