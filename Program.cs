using System.Security.Cryptography.X509Certificates;

namespace Uppgift_1
{
    internal class Program
    {
        public class Employee
        {
            private string _employeeName;
            private decimal _employeeSalary;

            public Employee(string employeeName, decimal employeeSalary)
            {
                _employeeName = employeeName;
                _employeeSalary = employeeSalary;
            }

            public string Name
            {
                get { return _employeeName; }
                set { _employeeName = value; }
            }

            public decimal Salary
            {
                get { return _employeeSalary; }
                set { _employeeSalary = value; }
            }
        }
        static void Main(string[] args)
        {
            //Skapa en lista och lagra alla anställda
            List<Employee> employees = new List<Employee>();

            // Välkomna användaren
            Console.WriteLine("Hej och välkommen till 'Lägg till Anställd' i Personalregistret");

            // Skapa anställda i personalregistrer
            while (true)
            {
                // Be om uppgifter på den anställde
                Console.WriteLine("Vem vill du lägga till?");
                Console.Write("Namn:");
                string employeeName = Console.ReadLine();
                Console.Write("Lön: ");
                string salaryInput = Console.ReadLine();

                // Konvertera lönen till en decimal
                decimal employeeSalary;
                while (!decimal.TryParse(salaryInput, out employeeSalary))
                {
                    Console.Write("Ogiltig inmatning. Ange en giltig lön: ");
                    salaryInput = Console.ReadLine();
                }

                // Skapa en anställd med namn och lön.
                Employee employee = new Employee(employeeName, employeeSalary);
                Console.WriteLine($"Namn: {employee.Name}, Lön: {employee.Salary}");

                // Fråga om användaren vill lägga till fler anställda eller skriva ut registret.
                Console.Write("Vill du lägga till fler anställda? (j/n)");
                string response = Console.ReadLine().ToLower();
                if (response != "j")
                {
                    break;
                }
            }

            Console.WriteLine("Anställda i registret:");
            foreach (var Employee in employees)
            {
                Console.WriteLine($"Namn {Employee.Name}, Lön: {Employee.Salary}");
            }
        }
    }
}