namespace Humanity
{
    class Program
    {
        static void Main()
        {
            Console.Write("Student: ");
            string[] input = Console.ReadLine().Split(' ');
            string name = input[0];
            string lastname = input[1];
            int Facnumber = int.Parse(input[2]);
            Student student = new Student(name, lastname, Facnumber);

            Console.Write("Employee: ");
            

            string[] input1 = Console.ReadLine().Split(' ');
            string name1 = input1[0];
            string lastname1 = input1[1];
            float salary = float.Parse(input1[2]);
            int hours = int.Parse(input1[3]);
            Employee employee = new Employee(name1, lastname1, salary, hours);
            float total = employee.Salaryperhour();
            line();


            Console.Write("First name: ");
            Console.WriteLine(name);
            Console.Write("Last name: ");
            Console.WriteLine(lastname);
            Console.Write("Faculty number: ");
            Console.WriteLine(Facnumber);

            Console.WriteLine();

            Console.Write("First name: ");
            Console.WriteLine(name1);
            Console.Write("Last name: ");
            Console.WriteLine(lastname1);
            Console.Write("Week Salary: ");
            Console.WriteLine(salary);
            Console.Write("Hours per day: ");
            Console.WriteLine(hours);
            Console.Write("Salary per hour: ");
            Console.WriteLine(total);

        }


        static void line()
        {
            Console.WriteLine("---------------------------");
        }
    }
}