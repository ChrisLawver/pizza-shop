using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Size { get; set; }
        public int NumberOfToppings { get; set; }
        public bool StuffedCrust { get; set; }

        public List<string> toppings = new List<string>();

        //public Pizza()
        //{

        //}

        //public Pizza(string size, int numberOfToppings, bool stuffedCrust)
        //{
        //    Size = size;
        //    NumberOfToppings = numberOfToppings;
        //    StuffedCrust = stuffedCrust;
        //}

        public string SelectPizzaSize(string pizzaSize)
        {
            Size = pizzaSize;
            return pizzaSize;
        }

        public int SelectNumberOfToppings(int userToppings)
        {
            NumberOfToppings = userToppings;
            return userToppings;
        }

        public bool SelectStuffedCrust()
        {
            return StuffedCrust = true;
        }
        public double PriceOfPizza()
        {
            double totalPrice = 0;

            if (Size == "Small")
            {
                totalPrice += 10;
            }
            else if (Size == "Medium")
            {
                totalPrice += 12;
            }
            else
            {
                totalPrice += 14;
            }

            if (StuffedCrust == true)
            {
                totalPrice += 2;
            }

            foreach (string topping in toppings)
            {
                totalPrice += .5;
            }

            return totalPrice;
        }
    }
}
