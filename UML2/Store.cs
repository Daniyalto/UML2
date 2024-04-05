using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class Store
    {
        MenuCatalog _menuCatalog;

        public Store()
        {
           _menuCatalog = new MenuCatalog();

        }


        public void Test()
        {
              
                Pizza p = new Pizza() { PizzaNumber = 1, Name = "MARGHERITA", Price = 80 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 2, Name = "VESUVIO", Price = 92 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 3, Name = "CAPRICCIOSA", Price = 98 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 4, Name = "CALZONE", Price = 98 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 5, Name = "QUATTRO STAGIONI", Price = 98 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 6, Name = "MARINARA", Price = 97 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 7, Name = "VEGETARIANA", Price = 98 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 8, Name = "ITALIANA", Price = 93 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 9, Name = "GORGONZOLA", Price = 97 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 10, Name = "CONTADINA", Price = 92 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 11, Name = "NAPOLI", Price = 95 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 12, Name = "VICHINGA", Price = 98 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 13, Name = "CALZONE SPECIALE", Price = 98 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 14, Name = "ESOTICA", Price = 98 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 15, Name = "TONNO", Price = 97 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 16, Name = "SARDEGNA", Price = 97 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 17, Name = "ROMANA", Price = 98 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 18, Name = "SOLE", Price = 98 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 19, Name = "BIG MAMMA", Price = 99 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 20, Name = "LA SALAMI", Price = 98 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 21, Name = "ROCCO", Price = 99 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 22, Name = "MARCO", Price = 99 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 23, Name = "KOKKODE", Price = 99 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 24, Name = "ANTONELLO", Price = 99 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 25, Name = "PASQUALINO", Price = 98 };
                _menuCatalog.Create(p);

                p = new Pizza() { PizzaNumber = 26, Name = "FELIX", Price = 95 };
                _menuCatalog.Create(p);

                _menuCatalog.PrintMenu();
        }

        public void Start()
        {
            new UserDialog(_menuCatalog).Start();
        }

    }
}
