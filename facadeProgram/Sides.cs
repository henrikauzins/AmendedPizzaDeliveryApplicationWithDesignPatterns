using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // this class creates a sides object

    public class Sides
    {
        // declaration of variables for sides class
        private string sidesName;
        public Sides(string SidesName)
        {
            sidesName = SidesName;
        }

        // returns the name of the sides
        public string GetSides()
        {
            return sidesName;
        }
    }
}
