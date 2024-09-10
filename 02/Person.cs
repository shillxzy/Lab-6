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

    
}
