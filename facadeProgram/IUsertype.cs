using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // interface for different user types used for program
    public interface IUsertype
    {
        void MoveState(); // moves between various states that are set up
    }
}
