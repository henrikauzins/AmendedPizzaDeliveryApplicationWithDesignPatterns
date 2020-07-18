using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // used for bridge pattern to provide different access interfaces to the user
    public class Employees: UserTypes
    {
        public Employees()
        {

        }

        // moves tothe current interface that is active in the program
        public override void MoveToCurrentState()
        {
            Console.Write("Active Interface: ");
            state.MoveState();
        }

    }
}
