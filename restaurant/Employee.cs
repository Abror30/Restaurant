using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class Employee
    {
        public int forgetsNewRequest;


        public Employee()
        {
            forgetsNewRequest = 0;

        }

        public int NewRequest(int requestedItem) //create ner instance of ChickenOrder or EggOrder class
        {
            ChickenOrder chickenOrder = new ChickenOrder();
            EggOrder eggOrder = new EggOrder();
            
            

            if (requestedItem % 3 == 0) // simulates the employee forgetting 1/3 of the time, should create an intance of the wrong class
            {
                if (requestedItem == chickenOrder)
                {
                    return eggOrder;
                }
            }
        }
    }
}
