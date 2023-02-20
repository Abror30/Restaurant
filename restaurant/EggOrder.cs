using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class EggOrder
    {
        private int _quantity; 
        private int? _quality;
        public EggOrder(int quantity)
        {
            _quantity = quantity;
        }
        public int GetQuantity()
     
        {
            return _quantity;
        }
        public int? GetQuality()
        {
            if (_quality == null)  // Check if quality has been calculated yet.
            {
                Random rnd = new Random();
                // Only calculate quality half of the time.
                if (rnd.Next(2) == 0)  // 1/2 chance of returning a value.
                {
                    _quality = rnd.Next(1, 101);  // Generate random number between 1 and 100.
                }
            }
            return _quality;
        }
        public void Crack()  // Throws exception on egg quality < 25.
        {
            if (GetQuality() < 25)  // Check for rotten egg.
            {
                throw new Exception("Rotten egg!");  // Throw exception on bad egg.
            }
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
