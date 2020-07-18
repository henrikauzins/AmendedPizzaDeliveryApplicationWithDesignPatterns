using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{

    // creates an order object
    public class Order : IOrder
    {
        private int orderNumber;
        private string customerName;
        private string pizzaName;
        private string pizzaType;
        private string toppName;
        private string baseType;
        private string sidesName;
        private string drinksName;
        private string location;

        

        // adds customers to a list
        private List<ICustomer> customers = new List<ICustomer>();


       // constructor that takes in above program variables in order to return them

        public Order(int OrderNumber, string CustomerName, string PizzaName, string PizzaType, string ToppName, string BaseType, string SidesName, string DrinksName, string Location)
        {
            orderNumber = OrderNumber;
            customerName = CustomerName;
            pizzaName = PizzaName;
            pizzaType = PizzaType;
            toppName = ToppName;
            baseType = BaseType;
            sidesName = SidesName;
            drinksName = DrinksName;
            location = Location;
        }

        // methods return program variables to user
        public int GetOrderNumber()
        {
            return orderNumber;
        }

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

        // old
        //public void getEmpName()
        //{
        //    // TODO implement here
        //}


        public Order()
        {

        }

    
        // subject i.e order of observer pattern

        // PlacedOrder() and DeletedOrder() check to see if the customer has placed an order or not

        public void PlacedOrder()
        {
            Console.WriteLine("Order has been recieved from customer");

        }
        public void DeletedOrder()
        {
            Console.WriteLine("Customer has withdrawn their order");

        }

        // updates the customer when the order has been recived
        public void FirstUpdate()
        {

            Console.WriteLine("Customer's Order has gone through to the kitchen");
        }

        // places the order
        public void PlaceOrder(ICustomer customer)
        {
            Console.WriteLine("Order is now placed");
            this.customers.Add(customer);
        }

        // deletes the order
        public void DeleteOrder(ICustomer customer)
        {
            Console.WriteLine("Order has been deleted by customer");
            this.customers.Remove(customer);
        }

        // notifys customers about their orders
        public void NotifyCurrentCustomers()
        {
            Console.WriteLine("customer's are being notified about their orders");

            foreach (var cus in customers)
            {
                cus.Update(this);
            }
        }

    }

    


}


