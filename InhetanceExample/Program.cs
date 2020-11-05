using System;
using System.Diagnostics.Contracts;

namespace InhetanceExample
{
    class Branch
    {
        int Branchcode, Passcode;
        string Branchname, BranchAddress;
        public void Getbranchdetail()
        {
            Console.WriteLine("First Enter the security Pin :");
            Passcode = Convert.ToInt32(Console.ReadLine());
            if (Passcode == 1234)
            {
                Console.WriteLine("Great Permission Granted :");
                Console.WriteLine("Enter the Branch Details:");
                Console.WriteLine("Enter the Branch Name :");
                Branchname = Console.ReadLine();
                Console.WriteLine("Enter the Branch Address :");
                BranchAddress = Console.ReadLine();
                Console.WriteLine("Enter the Branch Code :");
                Branchcode = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Sorry You enter wrong passcode!!");
            }
        }
        public void PrintBranchdetail()
        {
            Console.WriteLine("Branch name is: " + Branchname);
            Console.WriteLine("Branch Address is: " + BranchAddress);
            Console.WriteLine("Branch Code is: " + Branchcode);

        }
    }
       class Employee : Branch
    {
        int EmployeeId, EmployeeAge;
        string EmployeeName, EmployeeAdress;
        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter the details of Employee :");
            Console.WriteLine("Enter the Employee ID :");
            EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Age :");
            EmployeeAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name :");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter the Employee Address:");
            EmployeeAdress = Console.ReadLine();
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID is :" + EmployeeId);
            Console.WriteLine("Employee Age is :" + EmployeeAge);
            Console.WriteLine("Employee Name is :" + EmployeeName);
            Console.WriteLine("Employee Address is :" + EmployeeAdress);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            a.Getbranchdetail();
            a.GetEmployeeDetails();
            a.PrintBranchdetail();
            a.DisplayEmployeeDetails();
        }
    }
}
