using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PizzaDeliveryProgram
{

    
    class Program
    {
        static void Main(string[] args)
        {
            // the Bridge design pattern is used for customer/employee access to various viewpoints of the program
            // the Observer design pattern is used for placing/deleting orders and letting customers know when the order has been sent through and completed
            // the Factory Method design pattern will build the customers order.

            Console.WriteLine("-------------------Pizza Delivery Program/Application---------------");

            string empType;
            string name;
            #region orderingVariables
            string cusName;
            string usertype;
            string location;
            string pizzaName;
            string pizzaType;
            string pizzaBase;
            string topping;
            string sides;
            string drink;
            int orderNumber = 0;
            string response;
            bool placed = false;
            bool completeOrder = false;

            #endregion

            // stores customer order components

            IDictionary<string, string> cusOrderSpec = new Dictionary<string, string>();

            // items on offer by the pizza delivery service
            // stores items in dictionaries and has an assigned float value to represent the price of the item
           
            // topping dictionary 
            Dictionary<string, float> toppingSelection = new Dictionary<string, float>() { 
                                                    {"sausage", 0.98f}, 
                                                    {"anchovies", 1.00f},
                                                    {"extra cheese", 2.74f } };

            // pizza base dictionary 
            Dictionary<string, float> baseSelection = new Dictionary<string, float>() {
                                                    {"small", 1.00f},
                                                    {"medium", 2.00f},
                                                    {"large", 3.00f } };

            // topping dictionary 
            Dictionary<string, float> drinkSelection = new Dictionary<string, float>() {
                                                    {"coca cola", 2.50f},
                                                    {"water", 1.00f},
                                                    {"sprite", 2.00f } };

            // pizza base dictionary 
            Dictionary<string, float> sideSelection = new Dictionary<string, float>() {
                                                    {"doughballs", 1.00f},
                                                    {"chicken wings", 2.00f},
                                                    {"garlic bread", 3.00f } };

            //pizza dictionary
            Dictionary<string, float> pizzas = new Dictionary<string, float>() {
                                                    {"margherita", 10.00f},
                                                    {"pepperoni", 11.00f},
                                                    {"hawaiian", 12.74f },
                                                    {"meat feast", 8.98f},
                                                    {"bbq chicken", 9.59f},
                                                    {"vegetarian", 9.80f } };
            //pizza type dictionary
            Dictionary<string, float> pizzaSelection = new Dictionary<string, float>() {
                                                    {"neopoliton", 4.98f},
                                                    {"deep dish", 5.00f},
                                                    {"new york style", 6.74f },
                                                    {"greek", 7.98f},
                                                    {"silcilian", 8.59f},
                                                    {"calzone", 9.80f } };



            // stores inputted results 
            object[] orderResults = new object[9];

            #region pizzaAndbranches

            // locations of pizza branches
            string[] PizzaBranches = new string[] { "london", "bath", "leeds", "bristol", "manchester" };

            List<string> Branches = new List<string>();

            Branches.AddRange(PizzaBranches);

            // stores values of dictionary keys
            List<float> finalOrderPrice = new List<float>();
            
            #endregion


            TheKitchen kitchen = new TheKitchen();

            Order testOrder = new Order();

            



            char input = 'z';

            #region orderingSystem

            // the while loop allows for continous input without having to re run the program every time after completed orders
            while (input != 'q')
            {

               // prompts user to say whether they are a customer or employee

                Console.WriteLine("Are you a customer or employee?");
                usertype = Console.ReadLine();

                if (usertype == "customer" || usertype == "Customer")
                {


                    // customer interface 
                    UserTypes customer = new Customers();

                    // Bridge design pattern functionality in main file
                    IUsertype currentState = new CustomerView();

                    customer.setState(currentState);

                    customer.MoveToCurrentState();


                    orderNumber = orderNumber + 1;

                    orderResults[0] = orderNumber;


                    //asks customer for their name
                    Console.WriteLine("what is your name?");
                    cusName = Console.ReadLine();

                    //adds attribute to data storage
                    orderResults[1] = cusName;
                    cusOrderSpec.Add("cName", cusName);
                    Customer cus1 = new Customer();

                    //asks customer what branch they are ordering from
                    Console.WriteLine("which branch would you like to order from? we have branches in london, bath, leeds, bristol and manchester");
                    location = Console.ReadLine();

                    // the while loop runs until user has selected a branch
                    while (true) {
                        //checks if branch exists
                        if (Branches.Contains(location))
                        {
                            Console.WriteLine(location + " is your selected branch");

                            //adds attribute to data storage
                            orderResults[8] = location;
                            cusOrderSpec.Add("loc", location);
                            Branch branch1 = new Branch(location);
                            // breaks out of the while loop and continues with the program
                            break;

                        }
                        else
                        {
                            // if branch does not exist, the while loop will continue

                            Console.WriteLine("we do not have a branch in that area");

                            //asks customer what branch they are ordering from
                            Console.WriteLine("which branch would you like to order from? we have branches in london, bath, leeds, bristol and manchester");
                            location = Console.ReadLine();
                            
                        }

                    }



                    //asks customer what pizza they would like
                    Console.WriteLine("what pizza would you like");
                    pizzaName = Console.ReadLine();

                    while (true) {
                        if (pizzas.ContainsKey(pizzaName))
                        {
                            Console.WriteLine("pizza is available");
                            Console.WriteLine("this will cost you £" + pizzas[pizzaName]);
                            //adds attribute to data storage and adds float value of inputted key to a float list
                            finalOrderPrice.Add(pizzas[pizzaName]);

                            orderResults[2] = pizzaName;
                            cusOrderSpec.Add("pName", pizzaName);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("this pizza is not offer :(");
                            
                        }
                    }

                    //asks customer what type of pizza they would like
                    Console.WriteLine("what type of pizza would you like? we offer neopoliton, deep dish, new york style, greek, sicilian and calzone");
                    pizzaType = Console.ReadLine();

                    while (true)
                    {

                        if (pizzaSelection.ContainsKey(pizzaType))
                        {

                            Console.WriteLine("pizza type is available");
                            Console.WriteLine("this will cost you £" + pizzaSelection[pizzaType]);
                            //adds attribute to data storage and value of inputted key to a float list
                            finalOrderPrice.Add(pizzaSelection[pizzaType]);
                            orderResults[3] = pizzaType;
                            cusOrderSpec.Add("pType", pizzaType);
                            Pizza p1 = new Pizza(pizzaName, pizzaType);
                            break;
                        }

                        else
                        {
                            // this code runs if the user gives an input that does not exist
                            Console.WriteLine("pizza type is not availible");

                            //asks customer what type of pizza they would like
                            Console.WriteLine("what type of pizza would you like? we offer neopoliton, deep dish, new york style, greek, sicilian and calzone");
                            pizzaType = Console.ReadLine();
                        }
                    }





                    //asks customer what topping they would like
                    Console.WriteLine("what topping would you like?");
                    topping = Console.ReadLine();

                    // runs until existing topping is selected
                    while (true)
                    {
                        if (toppingSelection.ContainsKey(topping))
                        {
                            Console.WriteLine("topping is available");
                            Console.WriteLine("this will cost you £" + toppingSelection[topping]);
                            finalOrderPrice.Add(toppingSelection[topping]);
                            Console.WriteLine(finalOrderPrice);
                            //adds attribute to data storage
                            orderResults[4] = topping;
                            cusOrderSpec.Add("topp", topping);
                            PizzaToppings topp1 = new PizzaToppings(topping);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Topping does not exist!");

                            Console.WriteLine("what topping would you like?");
                            topping = Console.ReadLine();
                          
                        }

                    }



                    Console.WriteLine("what size base would you like for your pizza");
                    pizzaBase = Console.ReadLine();

                    while (true)
                    {
                        if (baseSelection.ContainsKey(pizzaBase))
                        {
                            Console.WriteLine("pizza base is available");
                            Console.WriteLine("this will cost you £" + baseSelection[pizzaBase]);
                            //adds attribute to data storage and value of inputted key to a float list
                            finalOrderPrice.Add(baseSelection[pizzaBase]);
                            // newly initialised base object
                            Base base1 = new Base(pizzaBase);

                            //adds attribute to data storage
                            orderResults[5] = pizzaBase;
                            cusOrderSpec.Add("base", pizzaBase);
                            break;

                        }

                        else
                        {
                            Console.WriteLine("base does not exist");
                            Console.WriteLine("what size base would you like for your pizza");
                            pizzaBase = Console.ReadLine();
                        }
                    }
                   //asks customer what side they would like

                    Console.WriteLine("what side would you like with your order?");
                    sides = Console.ReadLine();

                    while (true)
                    {
                        if (sideSelection.ContainsKey(sides))
                        {
                            Console.WriteLine("sides is available");
                            Console.WriteLine("this will cost you £" + sideSelection[sides]);
                            //adds attribute to data storage and value of inputted key to a float list
                            finalOrderPrice.Add(sideSelection[sides]);
                            Sides sides1 = new Sides(sides);

                            orderResults[6] = sides;
                            cusOrderSpec.Add("sName", sides);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("side is not available");
                            Console.WriteLine("what side would you like with your order?");
                            sides = Console.ReadLine();
                        }
                    }
                  

                    //asks drinks what side they would like
                    Console.WriteLine("what drink would you like with your order?");
                    drink = Console.ReadLine();

                    while (true)
                    {
                        if (drinkSelection.ContainsKey(drink))
                        {
                            Console.WriteLine("sides is available");
                            Console.WriteLine("this will cost you £" + drinkSelection[drink]);
                            //adds attribute to data storage and value of inputted key to a float list
                            finalOrderPrice.Add(drinkSelection[drink]);
                            //adds attribute to data storage
                            orderResults[7] = drink;
                            cusOrderSpec.Add("dName", drink);
                            Drinks drink1 = new Drinks(drink);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("this drink is not on offer by the pizza delivery place");
                            Console.WriteLine("what drink would you like with your order?");
                            drink = Console.ReadLine();
                        }
                    }
                   
                    

               

                    // prints summary of propsed customer order


                    Console.WriteLine(cusName + " , here is your proposed order");

                    foreach (var order in orderResults)
                    {
                        // prints customers selected order to be sent through to be processed
                        Console.WriteLine(order);
                    }
                    // prints out total price of order as a float
                    float orderSum = (float)finalOrderPrice.Sum();
                    Console.WriteLine("your total price is: £" + orderSum);

                    Console.WriteLine("Would you like to place your order: ");
                    response = Console.ReadLine();
                  
                    if (response == "yes")
                        // places customer order
                    {
                        // newly created customer object via the second constructor in the customer class 
                        Customer customerObject = new Customer(cusName, location);
                        Order customerOrder = new Order(orderNumber, cusName, pizzaName, pizzaType, topping, pizzaBase, sides, drink, location);
                        cus1.placeOrder(testOrder);
                       
                       // boolean value is true
                        placed = true;
                    }
                    // runs if customer decides to delete the order
                    else if (response == "no")
                    {
                        cus1.deleteOrder(testOrder);
                        placed = false;
                        // removes current order so that a new order can be made
                        cusOrderSpec.Remove("cName");
                        cusOrderSpec.Remove("loc");
                        cusOrderSpec.Remove("pName");
                        cusOrderSpec.Remove("pType");
                        cusOrderSpec.Remove("topp");
                        cusOrderSpec.Remove("base");
                        cusOrderSpec.Remove("sName");
                        cusOrderSpec.Remove("dName");

                        orderNumber = orderNumber = 0;
                    }
                }
          
                else if (usertype == "employee" || usertype == "Employee")
                {
                    // employee interface using the bridge design pattern

                    UserTypes employee = new Employees();

                    IUsertype currentState1 = new EmployeeView();

                    employee.setState(currentState1);

                    employee.MoveToCurrentState();

                    // prompts employee for name

                    Console.WriteLine("What is your name?");
                    name = Console.ReadLine();

                    // prompts employee for job rank
                    Console.WriteLine("What is your job rank?");
                    empType = Console.ReadLine();

                    // accesses chef interface
                    if (empType == "chef")
                    {
                     
                        Chef chef1 = new Chef(name, empType);
                        //cusOrderSpec.Add("emp", name) (do not uncomment);
                        testOrder.NotifyCurrentCustomers();

                        
                        Orders finalOrder = kitchen.CreatedCustomerOrder("pizza", cusOrderSpec);
                        Console.WriteLine(finalOrder.ToString());
                        Console.ReadLine();

                        completeOrder = true;
                    }

                    // accesses manager interface
                   else if (empType == "manager")
                    {
                        Manager man1 = new Manager(name, empType);

                        if (completeOrder == true)
                        {
                           
                            Console.WriteLine("the customers order has been completed");
                            // removes the data in the completed order so that a new order can be made
                            cusOrderSpec.Remove("cName");
                            cusOrderSpec.Remove("loc");
                            cusOrderSpec.Remove("pName");
                            cusOrderSpec.Remove("pType");
                            cusOrderSpec.Remove("topp");
                            cusOrderSpec.Remove("base");
                            cusOrderSpec.Remove("sName");
                            cusOrderSpec.Remove("dName");
                            


                        }
                        else
                        {
                            Console.WriteLine("the customer's order has not been completed");
                        }
                    }


                    
               // team member interface
                    
                    else if (empType == "team member")
                        
                    {
                        TeamMember tm1 = new TeamMember(name, empType);
                        
                        // if order was confirmed by customer
                        if (placed == true)
                        {
                            Console.WriteLine("Order status: Recieved");
                            testOrder.PlacedOrder();
                            testOrder.FirstUpdate();
                        }

                        else if (placed == false)
                        {
                            // if order was withdrawn by customer
                            Console.WriteLine("Order status: Withdrawn");
                            testOrder.DeletedOrder();
                          

                        }
   
                            }               
                    }



                }

            }

            #endregion
        }
    }

