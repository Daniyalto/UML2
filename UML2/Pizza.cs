﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class Pizza
    {

        private string _name;
        private double _price;
        private int _pizzaNumber;
        
        
    

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int PizzaNumber
        {
            get { return _pizzaNumber; }
            set { _pizzaNumber = value; }
        }

        public override string ToString() 
        {
            return $"Pizza No.: {PizzaNumber}, Name: {Name}, Price: {Price} kr.";
        }


    }



    
}
