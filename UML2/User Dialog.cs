using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UML2;

namespace UML2
{
    public class UserDialog
    {
        MenuCatalog _menuCatalog;
        public UserDialog(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }


        Pizza CreateNewPizza() 
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Creating your new pizza");
            Console.WriteLine();

            string input = "";
            Console.WriteLine("Please enter the name for your new pizza:");

            try
            {
                input = Console.ReadLine();
                pizzaItem.Name = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine($"Invalid input: '{input}'. Sorry, unable to create pizza.");
                throw;
                
            }
            

            input = "";
            Console.Write("Please enter the price for your new pizza: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.Price = Int32.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Invalid input: '{input}'. Sorry, unable to create pizza.");
                throw;
                
            }

            input = "";
            Console.Write("Enter pizza number: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.PizzaNumber = Int32.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Invalid input: '{input}'. Sorry, unable to create pizza.");
                throw;
                
            }

            return pizzaItem;
        }

        Pizza PizzaDelete() 
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Please enter the pizza number you would like to delete:");
            
            string input = "";
       
            try
            {
                input = Console.ReadLine();
                pizzaItem.PizzaNumber = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Invalid input: '{input}' - Message: {e.Message}");
                
            }

            return pizzaItem;
        }

        Pizza PizzaUpdate() 
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine();
            _menuCatalog.PrintMenu();
            Console.Write("Please enter the pizza number which you would like to update:");
            pizzaItem.PizzaNumber = Int32.Parse(Console.ReadLine());

            Pizza pi = _menuCatalog.Search(pizzaItem);

            if (pi != null)
            {

                string input = "";
                Console.Write("Please enter the new name for your pizza: ");
                try
                {
                    input = Console.ReadLine();
                    pizzaItem.Name = input;
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Invalid input: '{input}' - Message: {e.Message}");

                }

                input = "";
                Console.Write("Please enter the updated price for your pizza: ");
                try
                {
                    input = Console.ReadLine();
                    pizzaItem.Price = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Invalid input: '{input}' - Message: {e.Message}");

                }

            }
            return pizzaItem;
        }

        Pizza SearchForPizza()
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Please enter the pizza number which you are searching for:");

            string input = "";
            try
            {
                input = Console.ReadLine();
                pizzaItem.PizzaNumber = Int32.Parse(input);
               
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Invalid input: '{input}' - Message: {e.Message}");
                
            }

            return pizzaItem;
        }
        int MenuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("Big Mamma´s Pizza Menu");
            Console.WriteLine();
            Console.WriteLine("You have the following choices:");

            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter choice#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($" Invalid input: '{input}'");
            }
            return -1;

        }

        public void Start() 
        {
            bool running = true;
            List <string> Menulist = new List<string>()
            {
                "0. Make new pizza",
                "1. Delete pizza",
                "2. Update pizza",
                "3. Search for pizza",
                "4. Display pizza menu",
            };

            while (running) 
            {
                int menuChoice = MenuChoice(Menulist);
                Console.WriteLine();
                switch (menuChoice)
                {   

                    case 0:
                        try
                        {
                            Pizza pizza = CreateNewPizza();
                            _menuCatalog.Create(pizza);
                            Console.WriteLine($"You have created the following pizza: {pizza}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        break;

                    case 1:
                        try
                        {
                            Pizza pizza = PizzaDelete();
                            _menuCatalog.Delete(pizza);
                        }
                        catch (Exception e) 
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        break;

                    case 2:
                        try 
                        {
                            Pizza pizza = PizzaUpdate();
                            _menuCatalog.Update(pizza);
                            Console.WriteLine($"You updated the following pizza: {pizza}");
                        }
                        catch (Exception e) 
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        break;

                    case 3:
                        try 
                        {
                            Pizza pizza = SearchForPizza();
                            pizza=_menuCatalog.Search(pizza);
                            Console.WriteLine($"The following pizza was found:{pizza}");
                        }
                        catch (Exception e) 
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        
                        _menuCatalog.PrintMenu();
                        Console.WriteLine("Plese press any key to continue");
                        Console.ReadKey();
                        break;

                    default: 
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        break;

                }
                        
                
            }
        }

       
    }
}






    
