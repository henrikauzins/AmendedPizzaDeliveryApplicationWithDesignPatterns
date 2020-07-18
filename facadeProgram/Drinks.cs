using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // this class creates a Drinks object
    public class Drinks
    {
        // declared string for drink name
        private string drinksName;
        public Drinks(string DrinksName)
        {
            drinksName = DrinksName;
        }

        public string GetDrinks()
        {
            // returns name of drink
            return drinksName;
        }
    }
}
