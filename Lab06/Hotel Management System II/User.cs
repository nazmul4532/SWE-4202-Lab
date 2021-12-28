using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_II
{
    internal class User
    {
        public string UserId;
        public string UserName;
        public string UserContactInfo;
        public string UserAddress;
        public string UserRoomNo;
        public int UserPayableAmount;
        public int UserRoomQty;
        public string UserOrderStatus;
        public string UserBookingId;
        public string UserRoomType;

        public User(string Id, string Name, string Contact, string Address)
        {
            this.UserAddress = Address;
            this.UserContactInfo = Contact;
            this.UserId = Id;
            this.UserName = Name;
        }
        public int roomCost ()
        {
            if(this.UserRoomType == "Single")
            {
                return 1000;
            }
            if(this.UserRoomType == "Double")
            {
                return 1500;
            }
            if(this.UserRoomType == "Deluxe")
            {
                return 3000;
            }
            return 1000;
        }
    }
}
