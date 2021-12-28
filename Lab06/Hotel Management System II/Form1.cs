using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_II
{
    public partial class Form1 : Form
    {
        HotelManagementSystem Hotel = new HotelManagementSystem();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string userID = CreateUserIDTextBox.Text;
            string userName = CreateUserNameTextBox.Text;
            string userContact = CreateUserContactTextBox.Text;
            string userAddress = CreateUserAddressTextBox.Text;


            if (Order.x == 1)
            {
                PlaceRoomChoiceComboBox.Items.Add("Single");
                PlaceRoomChoiceComboBox.Items.Add("Double");
                PlaceRoomChoiceComboBox.Items.Add("Deluxe");
                BookingIDComboBox.Items.Add("Pending");
                BookingIDComboBox.Items.Add("Confirmed");
                PlaceRoomQtyComboBox.Items.Add("1");
                PlaceRoomQtyComboBox.Items.Add("2");
                PlaceRoomQtyComboBox.Items.Add("3");
                Order.x++;
            }



            bool flag1 = false;

            foreach (User user in Hotel.users)
            {
                if (user.UserId == userID)
                {
                    flag1 = true;
                    MessageBox.Show("User Account Already Exists!!");
                    return;
                }
            }
            if (flag1 == false)
            {
                User dumUser = new User(userID, userName, userContact, userAddress);
                Hotel.users.Add(dumUser);
                MessageBox.Show("User Account has been created Successfully.");
            }
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            string userId = PlaceUserIDTextBox.Text;

            bool flag2 = false;

            foreach (User user in Hotel.users)
            {
                if (user.UserId == userId)
                {
                    flag2 = true;
                    user.UserRoomQty = Convert.ToInt32(PlaceRoomQtyComboBox.Text);
                    user.UserRoomNo = Convert.ToString(Order.RoomNo);
                    user.UserOrderStatus = "Pending";
                    user.UserRoomType = PlaceRoomChoiceComboBox.Text;
                    user.UserPayableAmount = user.roomCost() * user.UserRoomQty * Order.calculateDays(PlaceEntryDateTextBox.Text, PlaceDepartureDateTextBox.Text);
                    user.UserBookingId = Convert.ToString(Order.BookingID);
                    MessageBox.Show("Your Order has been placed successfully. Your Order Status is now Pending. Payable Amount: " + Convert.ToString(user.UserPayableAmount) + " Your Order Number is " + Convert.ToString(user.UserBookingId));

                    Order.RoomNo++;
                    Order.BookingID++;
                }
            }
            if (flag2 == false)
            {
                MessageBox.Show("User Not Found!! Create Account Please.");
            }

        }

        private void OrderDetailsButton_Click(object sender, EventArgs e)
        {
            string userBookingId = BookingIDUserTextBox.Text;
            bool flag3 = false;
            foreach (User user in Hotel.users)
            {
                if (user.UserBookingId == userBookingId)
                {
                    flag3 = true;
                    OrderStatusLabel.Text = user.UserOrderStatus;
                    OrderAmountLabel.Text = Convert.ToString(user.UserPayableAmount);
                    OrderUserNameLabel.Text = user.UserName;
                    OrderUserAddressLabel.Text = user.UserAddress;

                    MessageBox.Show("User Order Details have been updated");
                }
            }
            if (flag3 == false)
            {
                MessageBox.Show("Booking Order is not found in the Database.");
            }
        }

        private void SetStatusButton_Click(object sender, EventArgs e)
        {
            string bookingId = BookingIDOwnerTextBox.Text;
            string bookingStatus = BookingIDComboBox.Text;
            bool flag4 = false;
            foreach (User user in Hotel.users)
            {
                if (user.UserBookingId == bookingId)
                {
                    flag4 = true;
                    user.UserOrderStatus = bookingStatus;
                    if (user.UserOrderStatus == "Confirmed")
                    {
                        Order.Balance = Order.Balance + user.UserPayableAmount;
                        CurrentBalanceLabel.Text = Convert.ToString(Order.Balance);
                    }
                }

            }
            if (flag4 == false)
            {
                MessageBox.Show("Booking order is not found in the Database!!");
            }
        }

        private void RoomDetailsButton_Click(object sender, EventArgs e)
        {
            RoomDetailsListBox.Items.Clear();
            string BookingId = BookingIDOwnerTextBox.Text;
            bool flag = false;
            foreach (User user in Hotel.users)
            {
                if (user.UserBookingId == BookingId)
                {
                    flag = true;
                    RoomDetailsListBox.Items.Add("Room \t No \t Qty \t Amnt" );
                    RoomDetailsListBox.Items.Add(user.UserRoomType + "\t" + user.UserRoomNo + "\t" + Convert.ToString(user.UserRoomQty) + "\t" + Convert.ToString(user.UserPayableAmount));
                    MessageBox.Show("Room Details Have been Updated.");

                }
                
            }
            
            if (flag == false)
            {
                MessageBox.Show("Booking Order is not Found");
            }
        }
    }
}
