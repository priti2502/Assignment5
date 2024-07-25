using System;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            EmployeeController controller = new EmployeeController();
            char ch;

            do
            {


                Console.WriteLine("---Welcome---");

                Console.WriteLine("Enter your id");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your name");
                String name = Console.ReadLine();

                Console.WriteLine("Enter name of Reporting manager");
                String managername = Console.ReadLine();

                Console.WriteLine("Who are you 1.ContractBased Employee 2.Payroll Employee");
                byte choice = byte.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter contract date");
                    DateTime contractdate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Enter contract duration");

                    int duration = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter charge per month");

                    double charge = double.Parse(Console.ReadLine());

                    employees.Add(new ContractEmployee(id, name, managername, contractdate, duration, charge));

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter joining date");
                    DateTime JoiningDate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Enter experience in year");

                    int Experience = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter basic salary");

                    double basicSalary = double.Parse(Console.ReadLine());

                    PayrollEmployee payrollEmployee = new PayrollEmployee(id, name, managername, JoiningDate, Experience, basicSalary);
                    controller.calculateNetSalary(payrollEmployee);
                    employees.Add(payrollEmployee);

                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
                Console.WriteLine("Do you want to add employee (y/n)");
                ch = char.Parse(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');


            Console.WriteLine("\n--- Employee Details ---");
            foreach (var employee in employees)
            {
                employee.EmployeeDetails();
                Console.WriteLine();
            }
            Console.WriteLine($"Total number of employees: {employees.Count}");
        }
    }
}

