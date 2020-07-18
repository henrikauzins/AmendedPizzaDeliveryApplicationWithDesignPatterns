using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // inherits method from IUsertype interface
    public class EmployeeView : IUsertype
    {
        public EmployeeView()
        {

        }

        public void MoveState()
        {
            // when the employee interface is active, this will show
            Console.WriteLine("Employee");
        }
    }

}


