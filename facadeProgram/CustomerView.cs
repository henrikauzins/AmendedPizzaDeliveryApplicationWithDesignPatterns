using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // inherits method from IUsertype interface
    public class CustomerView: IUsertype
    {
        public CustomerView()
        {

        }

        public void MoveState()
        {
            // when the customer interface is active, this will show that the user is on the customer side of operations
            Console.WriteLine("Customer");
        }
    }

}

    
