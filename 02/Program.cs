namespace Humanity
{
    class Program
    {
        static void Main()
        {
            try
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
                Console.WriteLine("---------------------------");

                student.Display();

                Console.WriteLine();

                employee.Display();

                Console.Write("Salary per hour: $");
                total = (float)Math.Round(total, 2);
                Console.WriteLine(total);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

        }


        
    }
}