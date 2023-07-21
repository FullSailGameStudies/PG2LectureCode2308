using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Order
    {

        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }
    }
}
