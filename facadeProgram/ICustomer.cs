using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    
    public interface ICustomer
    {
       

        // observer pattern methods

        void Update(Order myOrder);
        
    }
}
