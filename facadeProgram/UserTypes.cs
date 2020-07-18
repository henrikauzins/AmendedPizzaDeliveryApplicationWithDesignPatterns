using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryProgram
{
    public abstract class UserTypes
    {
        //uses an interface datatype for a class variable
        public IUsertype state;
        
        // returns the state of the current access interface
        public IUsertype getState()
        {
            return state;
        }

        // sets the current state of the access viewpoint
        public void setState(IUsertype inputState)
        {
            this.state = inputState;
        }

        // when an user interface is active, this will go to the correct one
        public abstract void MoveToCurrentState();

    }
}

