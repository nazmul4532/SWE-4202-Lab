using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Rental_System
{
    internal class Double_Room : Hotel_Room
    {
        public int bed = 2;
        public int extraTV = 0;
        public bool complimentaryBreakfast = false;

        public int calculateCost()
        {
            int totalCost = 0;
            if(roomAC == true)
            { 
                totalCost = totalCost + 500;
            }
            if(extraTV > 0)
            {
                totalCost = totalCost + extraTV * 1000;
            }
            if( complimentaryBreakfast == true)
            {
                totalCost = totalCost + 500;
            }
            totalCost = totalCost + 3500;

            return totalCost;
        }


    }
}
