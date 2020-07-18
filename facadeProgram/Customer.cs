using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // inherits ICustomer methods for observer pattern
    public  class Customer: ICustomer
    {
        public string customerName;
        public string location;
       
        public Customer(string cusName, string Location)
        {
            customerName = cusName;
            location = Location;
            
        }

        public string GetCustomerName()
        {
            // gets name of customer
            return customerName;
        }

        public string GetLocation()
        {
            // gets location of customer
            return location;
        }

        public Customer()
        {
        }

        
     

        // observer pattern methods


        public void placeOrder(Order myOrder)
        {
            //places customer order
            myOrder.PlaceOrder(this);
        }

        public void deleteOrder(Order myOrder)
        {
            //deletes customer order
            myOrder.DeleteOrder(this);
        }

      
        //updates customer order status
        public void Update(Order myOrder) 
        {
            Console.WriteLine("Order is completed and ready to go to be delivered!");

        }

    }

   
}
