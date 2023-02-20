using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class ChickenOrder
    {
       public int Quantity { get; set; }
        
        public ChickenOrder(int quantity)
        {
            this.Quantity = quantity;
        }
        public int GetQuantity() // returns same value as passed in constructor
        {
            return this.Quantity;
        }
        public void CutUp() // no arguments or return value
        {
            for(int i = 0; i < this.Quantity; i++) // calls number of times requested in quantity
            {
                Console.WriteLine("The chicken meat was cut {0} times", i);
            }
        }
        public void Cook() //no arguments or return value, can call only once
        {
            Console.WriteLine("The chicken is done!");
        }
        
    }
}
