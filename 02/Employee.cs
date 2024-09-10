using Humanity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Humanity
{
    class Employee : Person
    {
        private float salary;
        private int WorkCount;

        public Employee(string name, string lastname, float salary, int WorkCount)
            : base(name, lastname)
        {
            WeekSalary = salary;
            WorkOfCount = WorkCount;
        }

        public float Salaryperhour()
        {
            float total = 0.0f;
            float CountOfWeek = WorkCount * 5;
            total = (salary / CountOfWeek);
            return total;
        }

        public void Display()
        {
            Console.Write("First name: ");
            Console.WriteLine(Name);
            Console.Write("Last name: ");
            Console.WriteLine(Lastname);
            Console.Write("Week Salary: ");
            Console.WriteLine(WeekSalary);
            Console.Write("Hours per day: ");
            Console.WriteLine(WorkOfCount);
        }

        public float WeekSalary
        {
            get { return salary; }
            set
            {
                if (value < 10)
                {
                    throw new($"Expected value mismatch!Argument: {salary}");
                }
                else

                {
                    salary = value;
                }
            }
        }

        public float WorkOfCount
        {
            get { return WorkCount; }

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new("Expected value mismatch! Argument: workHoursPerDay");
                }
                else
                {
                    WorkCount = (int)value;
                }
            }
        }




    }
}
