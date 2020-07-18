using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // this class creates a pizza topping object
    public class PizzaToppings
    {
        private string toppName;
        public PizzaToppings(string ToppName)
        {
            toppName = ToppName;
        }

        // returns the name of the pizza topping
        public string GetTopping()
        {
            return toppName;
        }
    }
}
