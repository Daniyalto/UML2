using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UML2
{
    public class MenuCatalog
    {
        List<Pizza> _pizzas;

        public MenuCatalog() 
        {
            _pizzas = new List<Pizza>(); 
        }


        public void Create(Pizza p)
        {
            foreach (Pizza pizza in _pizzas)
            {
                if (p.PizzaNumber == pizza.PizzaNumber)
                { throw new FormatException("Sorry, the selected number already exist. Please select a different number."); }
               
            }
            _pizzas.Add(p);
        }

        
        public Pizza Search(Pizza pizza) 
        {
            bool foundPizza = false;
            foreach (Pizza i in _pizzas)
            {
                
                if (i.PizzaNumber == pizza.PizzaNumber)
                {
                    return i;
                    foundPizza = true;
                }
            }
            if (foundPizza == false) { throw new FormatException("Sorry, no pizza was found."); }
            return null;

        }


        public void Update(Pizza pizza) 
        {
            bool foundPizza = false;
            foreach (Pizza i in _pizzas)
            {

                if (i.PizzaNumber == pizza.PizzaNumber)
                {
                    i.Name = pizza.Name;
                    i.Price = pizza.Price;
                    foundPizza = true;
                    
                }

            }
            if  (foundPizza == false) { throw new FormatException("Sorry, unable to update pizza."); }

        }
    

        public void Delete(Pizza pizza)
        {
            if (pizza.PizzaNumber <= 0) 

                { throw new FormatException("Sorry, pizza number was not found."); }

            foreach (Pizza i in _pizzas)
            { 
                if (i.PizzaNumber == pizza.PizzaNumber)
                {
                    pizza = i;
                    
                }

            }
            if ((pizza.Name == null) || (pizza.Name.Trim().Length <= 0)) { throw new FormatException("Pizza number was not found"); }
           
            _pizzas.Remove(pizza);
        }

        
        public void PrintMenu() 
        {
            foreach(Pizza i in _pizzas) 
            {
                Console.WriteLine(i);
            }
        }
     }
}
