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

        }

    }
}