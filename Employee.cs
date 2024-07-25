using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String ReportingManager { get; set; }
        public Employee(int id, string name, string reportingManager)
        {
            Id = id;
            Name = name;
            ReportingManager = reportingManager;
        }
        public virtual void EmployeeDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Reporting Manager: {ReportingManager}");
        }



    }
    class ContractEmployee : Employee
    {
        public DateTime ContractDate { get; set; }
        public int Duration { get; set; }
        public double Charges { get; set; }

        public ContractEmployee(int id, string name, string reportingManager, DateTime contractDate, int duration, double charges)
        : base(id, name, reportingManager)
        {
            ContractDate = contractDate;
            Duration = duration;
            Charges = charges;
        }


        public override void EmployeeDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Reporting Manager: {ReportingManager}, Contract Date: {ContractDate}, Duration: {Duration} years, Charges: {Charges}");
        }
    }
    class PayrollEmployee : Employee
    {
        public DateTime JoiningDate { get; set; }
        public int Experience { get; set; }
        public double BasicSalary { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }

        public double PF { get; set; }
        public double Netsalary { get; set; }

        public PayrollEmployee(int id, string name, string reportingManager, DateTime joiningDate, int experience, double basicSalary)
        : base(id, name, reportingManager)
        {
            JoiningDate = joiningDate;
            Experience = experience;
            BasicSalary = basicSalary;

        }
        public override void EmployeeDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Reporting Manager: {ReportingManager}, Joining Date: {JoiningDate}, Experience: {Experience} months, Salary: {BasicSalary},NetSalary :{Netsalary}");
        }



    }
}
