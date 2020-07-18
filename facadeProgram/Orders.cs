using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // inherits from the Order class
   public abstract class Orders : Order
    {
        private string customerName;
        private string pizzaName;
        private string pizzaType;
        private string toppName;
        private string baseType;
        private string sidesName;
        private string drinksName;
        private string location;
        //private string empName;

            // customers order is stored in here so it can be created 
        public void OrderSpec(Object cusOrder)
        {
            customerName = ((Dictionary<string, string>)cusOrder)["cName"];
            pizzaName = ((Dictionary<string, string>)cusOrder)["pName"];
            pizzaType = ((Dictionary<string, string>)cusOrder)["pType"];
            toppName = ((Dictionary<string, string>)cusOrder)["topp"];
            baseType = ((Dictionary<string, string>)cusOrder)["base"];
            sidesName = ((Dictionary<string, string>)cusOrder)["sName"];
            drinksName = ((Dictionary<string, string>)cusOrder)["dName"];
            location = ((Dictionary<string, string>)cusOrder)["loc"];
            // old variable (do not uncomment)
            //empName = ((Dictionary<string, string>)cusOrder)["emp"];
        }

        // returns data to the screen
        public string GetCustomerName()
        {
            return customerName;
        }

        public string GetPizzaName()
        {
            return pizzaName;
        }

        public string getPizzaType()
        {
            return pizzaType;
        }

        public string GetTopping()
        {
            return toppName;
        }

        public string getbaseType()
        {
            return baseType;
        }

        public string GetSides()
        {
            return sidesName;
        }

        public string GetDrinks()
        {
            return drinksName;
        }

        public string getBranch()
        {
            return location;
        }

        //old function (do not uncomment)

        //public string GetEmp()
        //{
        //    return empName;
        //}

    }

    public class CreatedCustomerOrder : Orders
    {
        public CreatedCustomerOrder(Object cusOrder)
        {
            // adds the inputted data to the order and creates the customer's order
            this.OrderSpec(cusOrder);
        }


        public override string ToString()
        {
            //returns customer's final order
            return GetCustomerName() + ", you have ordered a " + getPizzaType()  + GetPizzaName() + " topped with " + GetTopping() + " on a " + getbaseType() + " base " + " with " + GetSides() + " and a " + GetDrinks() + " your order will be delivered to you from our " + getBranch() + " branch " + " your order was made by the chef of this fine establishment";
        }


    }

   // old variant

    //public class Margherita : Orders
    //{
    //    public Margherita(Object cusOrder)
    //    {
    //        this.OrderSpec(cusOrder);
    //    }

    //    public override string ToString()
    //    {
    //        return "You have ordered a margherita pizza with your order";
    //    }


    //}

    //public class Pepperoni : Orders
    //{
    //    public Pepperoni(Object cusOrder)
    //    {
    //        this.OrderSpec(cusOrder);
    //    }

    //    public override string ToString()
    //    {
    //        return "You have ordered a pepperoni pizza with your order";
    //    }


    //}

    public abstract class OrderCreation
    {

        //abstract method for creating the customer's order
        public abstract Orders CreatedCustomerOrder(string Type, Object cusOrder);

    }

    public class TheKitchen : OrderCreation
    {
        public override Orders CreatedCustomerOrder(string Type, Object cusOrder)
        {
            // old variant 

            //if (Type == "margherita")
            //{
            //    // creates customer order object  
            //    return new Margherita(cusOrder);
            //}

            //if (Type == "peperoni")
            //{
            //    // creates customer order object  
            //    return new Pepperoni(cusOrder);
            //}

            // working version
            if (Type == "pizza")
            {
                // returns newly created customer order object  
                return new CreatedCustomerOrder(cusOrder);
            }


            return new NoOrder();
        }

    }

    public class NoOrder : Orders
    {
        public override string ToString()
        {
            // returns only if an order has not been placed
            return "There is no order placed";
        }
    }

}
