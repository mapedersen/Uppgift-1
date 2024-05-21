using System.Security.Cryptography.X509Certificates;

// Vilka klasser bör ingå i programmet?

/* Det räcker med en klass i detta program och det är den för de anställda */

// Vilka attribut och metoder bör ingå i dessa klasser?

/* Klassen bör ha attribut för namn och lön. I detta program använder jag egenskaper i klassen för att hämta namn och lön.*/

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

                //Läser in och validerar namnet
                string employeeName;
                do
                {
                    Console.WriteLine("Vem vill du lägga till?");
                    Console.Write("Namn: ");

                    employeeName = Console.ReadLine();

                    if (string.IsNullOrEmpty(employeeName))
                    {
                        Console.WriteLine("Namnet kan inte vara tomt, försök igen");
                    }
                    else if (employeeName.Any(char.IsDigit))
                    {
                        Console.WriteLine("Namnet kan inte innehålla siffror");
                    }
                } while (string.IsNullOrEmpty(employeeName) || employeeName.Any(char.IsDigit));
                
                // Läser in lön
                Console.Write("Lön: ");
                string salaryInput = Console.ReadLine();

                // Validerarar och konvertera stringen till typen decimal
                decimal employeeSalary;
                while (!decimal.TryParse(salaryInput, out employeeSalary))
                {
                    Console.Write("Ogiltig inmatning. Ange en giltig lön: ");
                    salaryInput = Console.ReadLine();
                }

                // Skapa en anställd med namn och lön.
                Employee employee = new Employee(employeeName, employeeSalary);
                Console.WriteLine($"Namn: {employee.Name}, Lön: {employee.Salary}");

                // Lägg till anställd i listan
                employees.Add(employee);

                // Fråga om användaren vill lägga till fler anställda eller skriva ut registret.
                string response;
                do
                {
                    Console.WriteLine("Vill du lägga till fler anställda? (j/n)");
                    Console.Write("Svar: ");
                    response = Console.ReadLine().Trim().ToLower();

                    if (response != "j" && response != "n")
                    {
                        Console.WriteLine("Ange ett giltigt svar.");
                    }
                } while (response != "j" && response != "n");

                if (response == "n")
                {
                    break;
                }
            }

            // Skriv ut anställda i listan
            Console.WriteLine("Anställda i registret:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Namn: {employee.Name}, Lön: {employee.Salary}");
            }
        }
    }
}