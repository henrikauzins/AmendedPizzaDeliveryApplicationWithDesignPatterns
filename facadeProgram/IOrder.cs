using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // observer interface and methods
   public interface IOrder
    {
      
        // observer subject methods

        void PlaceOrder(ICustomer customer); // places customer order
        void DeleteOrder(ICustomer customer); // deletes customer order
        void NotifyCurrentCustomers(); // notifies customers when order is ready

        
    }
}
