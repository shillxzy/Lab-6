using Humanity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Humanity
{
    class Student : Person
    {
        private int numFac;

        public Student(string name, string lastname, int numFac)
            : base(name, lastname)
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
}
