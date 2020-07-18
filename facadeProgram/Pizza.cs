using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    
    // class will create a pizza object
    public class Pizza
    {
        // declared variables for pizza class
        private string pizzaName;
        private string pType;



        public Pizza(string PizzaName, string PType)
        {
            pizzaName = PizzaName;
            pType = PType;
        }

        // returns data to user
        public string getPizza()
        {
            return pizzaName;
        }

        public string getPizzaType()
        {
            return pType;
        }
    }


    public class PizzaType : Pizza
    {

        private string pizzaName;
        private string pType;

        public PizzaType(string PizzaName, string PType): base(PizzaName, PType)
        {
            pizzaName = PizzaName;
            pType = PType;
        }

        // returns type of pizza
        public string GetPizzaType()
        {
            return pType;
        }
    }


}


   

