using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class EggOrder
    {
        private int Quantity { get; set; }
        private static int counter = 0;

        int rnd = 0;
        public EggOrder(int quantity)
        {
            Quantity = quantity;
            rnd = new Random().Next(1, 101);
            counter++;
        }
        public int GetQuantity()
     
        {
            return Quantity;
        }
        public int? GetQuality()
        {
            if (counter % 2 == 0)
            {
                return null;
            }
            if (rnd < 25)
            {
                return null;
            }
            else
            {
                return rnd;
            }
        }
        public void Crack()  
        {
            Console.WriteLine("the employee cracks the eggs");  // Code to crack eggs here... 
        }
        public void DiscardShell()  // No arguments or return value.
        {
            Console.WriteLine("the emplloyee discards egg shells");
        }
        public void Cook()  // No arguments or return value.
        {
            Console.WriteLine("the eggs are ready!");
        }

    }
    
}
