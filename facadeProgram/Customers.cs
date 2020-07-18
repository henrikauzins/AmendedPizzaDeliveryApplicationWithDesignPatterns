using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // used for bridge pattern to provide different access interfaces to the user
    public class Customers: UserTypes
    {
        public Customers()
        {

        }

        // moves to current interface that is active
        public override void MoveToCurrentState()
        {
            Console.Write("Active Interface: ");
            state.MoveState();
        }
    }
}
