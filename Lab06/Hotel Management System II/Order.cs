using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_II
{
    internal class Order
    {
        public static int BookingID = 1;
        public static int RoomNo = 100;
        public static int Balance=0;
        public static int x = 1;

        public static int calculateDays(string EntryDate, string DepartureDate)
        {
            int days;
            int entryDay;
            int entryMonth;
            int entryYear;
            int departureDay;
            int departureMonth;
            int departureYear;
            entryDay = Convert.ToInt32(EntryDate[0]) * 10 + Convert.ToInt32(EntryDate[1]);
            entryMonth = Convert.ToInt32(EntryDate[3]) * 10 + Convert.ToInt32(EntryDate[4]);
            entryYear = Convert.ToInt32(EntryDate[6])*10 + Convert.ToInt32(EntryDate[7]);
            departureDay = Convert.ToInt32(DepartureDate[0]) * 10 + Convert.ToInt32(DepartureDate[1]);
            departureMonth = Convert.ToInt32(DepartureDate[3]) * 10 + Convert.ToInt32(DepartureDate[4]);
            departureYear = Convert.ToInt32(DepartureDate[6]) * 10 + Convert.ToInt32(DepartureDate[7]);
            int entry;
            int departure;
            entry = entryYear * 365 + entryMonth * 30 + entryDay;
            departure = departureDay + departureMonth * 30 + departureYear * 365;
            days = departure - entry;
            return days;
        }
    }
}
