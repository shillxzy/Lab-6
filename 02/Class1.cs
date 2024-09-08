using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Humanity
{
    class Person
    {
        private string name;
        private string lastname;

        public Person(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }

        public string Name
        {
            get { return name; }

            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new("Expected upper case letter!");
                }
                else if (value.Length < 3)
                {
                    throw new("Expected length at least 4 symbols!");
                }
                else
                {
                    name = value;
                }
            
            }
        }

        public string Lastname
        {
            get { return lastname; }

            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new("Expected upper case letter!");
                }
                else if (value.Length < 2)
                {
                    throw new("Expected length at least 3 symbols!");
                }
                else
                {
                    lastname = value;
                }
            }
        }

    }


    class Student : Person
    {
        private int numFac;

        public Student(string name, string lastname, int numFac)
            : base (name, lastname)
        {
            FacultyNumber = numFac;
        }

        public void Display()
        {
            Console.Write("First name: ");
            Console.WriteLine(Name);
            Console.Write("Last name: ");
            Console.WriteLine(Lastname);
            Console.Write("Faculty number: ");
            Console.WriteLine(FacultyNumber);
        }

        public int FacultyNumber
        {
            get { return numFac; }
            set
            {
                if (value < 5 && value > 10)
                {
                    throw new("Invalid faculty number! Should be in range [5..10] symbols.");
                }
                else
                {
                    numFac = value;
                }
            }
        }

        
    }

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
            total = (salary /  CountOfWeek);
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
                    throw new ("Expected value mismatch! Argument: workHoursPerDay");
                }
                else
                {
                    WorkCount = (int)value;
                }
            }
        }




    }
}
