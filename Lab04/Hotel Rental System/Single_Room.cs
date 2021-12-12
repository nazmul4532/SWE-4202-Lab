using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Rental_System
{
    internal class Single_Room : Hotel_Room
    {
        public int bed = 1;
        public bool gamingSetup = false;
        public int calculateCost()
        {
            int totalCost = 0;
            if(roomAC==true)
            {
                totalCost = totalCost+500;
            }
            if(gamingSetup==true)
            { totalCost = totalCost+1000;}
            totalCost = totalCost + 2000;

            return totalCost;
        }

    }
}
