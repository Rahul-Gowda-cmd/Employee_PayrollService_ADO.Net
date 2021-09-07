using System;

namespace EmployeePayrollService_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll!");
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();
            employee.EmployeeName = "Rahul";
            employee.Department = "Tech1";
            employee.PhoneNumber = "6677355245";
            employee.Address = "Gadag";
            employee.Gender = 'M';
            employee.BasicPay = 10000.00M;
            employee.Deductions = 1500.00;
            employee.StartDate = Convert.ToDateTime("2021-09-07");

            //repo.AddEmployee(employee);
            repo.GetAllEmployee();
           
        }
    }
}
