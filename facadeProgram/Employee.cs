using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // creates an employee object
    public class Employee
    {
        private string empName;
        private string employeeType;

        public Employee(string EmpName, string EmployeeType)
        {
            empName = EmpName;
            employeeType = EmployeeType;
        }

        // returns the name of the employee and what their rank is in the pizza delivery branch
        public string GetEmpName()
        {
            return empName;
        }

        public string GetEmployeeType()
        {
            return employeeType;
        }


       
    }

    // inherits from Employee
    public class TeamMember : Employee
    {
        //declared variables for name of employee and their rank
        public string empName;

        public string employeeType;

        // inherits attributes and properties from the employee class
        public TeamMember(string EmpName, string EmployeeType) : base(EmpName, EmployeeType)
        {
            employeeType = EmployeeType;
        }

        // returns the employee rank in the pizza delivery branch

        public string GetEmpType()
        {
            return employeeType;
        }

    }

    public class Manager : Employee
    {
        //declared variables for name of employee and their rank
        public string empName;

        public string employeeType;

        // inherits attributes and properties from the employee class
        public Manager(string EmpName, string EmployeeType) : base(EmpName, EmployeeType)
        {
            employeeType = EmployeeType;
        }


        // returns the employee rank in the pizza delivery branch
        public string GetEmpType()
        {
            return employeeType;
        }

    }

    public class Chef : Employee
    {
        //declared variables for name of employee and their rank
        public string empName;

        public string employeeType;
        // inherits attributes and properties from the employee class
        public Chef(string EmpName, string EmployeeType) : base(EmpName, EmployeeType)
        {
            employeeType = EmployeeType;
        }


        // returns the employee rank in the pizza delivery branch
        public string GetEmpType()
        {
            return employeeType;
        }

    }
}
