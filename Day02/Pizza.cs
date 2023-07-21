using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Pizza
    {
        public Size Size { get; set; }
        public Crust Crust { get; set; }
        public Sauce Sauce { get; set; }
        public List<Topping> Toppings { get; set; } = new List<Topping>();

        public void Show()
        {
            Console.Write($"{Size} {Crust} pizza with {Sauce} sauce ");
            if (Toppings.Count > 0)
            {
                Console.Write(" with ");
                foreach (var topping in Toppings)
                {
                    if (topping != Toppings.First())
                        Console.Write(',');
                    Console.Write(topping);

                }                
            }
            Console.WriteLine();
        }
    }
}
