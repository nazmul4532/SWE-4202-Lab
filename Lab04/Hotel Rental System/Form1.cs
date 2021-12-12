using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Rental_System
{
    public partial class Form1 : Form
    {
        List<Single_Room> single_rooms = new List<Single_Room>();
        List <Double_Room> double_rooms = new List<Double_Room>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void AddSingleRoom_Click(object sender, EventArgs e)
        {
            string singleRoomName = singlePackageName.Text;
            string singleAir = singleAC.Text;
            singleAir.ToUpper();
            string singleGamingSetup = singleGaming.Text;
            singleGamingSetup.ToUpper();

            bool flag = false;

            foreach (Single_Room singleRoom in single_rooms)
            { 
                if (singleRoom.roomName == singleRoomName)
                {
                    flag = true;
                    singleRoom.roomQty = singleRoom.roomQty + 1;
                    
                    if (singleAir == "YES")
                    {
                        singleRoom.roomAC = true;
                    }
                    if (singleGamingSetup == "YES")
                    {
                        singleRoom.gamingSetup = true;
                    }

                    int roomPrice = singleRoom.calculateCost();

                    MessageBox.Show("You have added " + Convert.ToString(singleRoom.roomQty) + " " + singleRoom.roomName + " rooms which costs " + Convert.ToString(roomPrice) + " per day");
                }

            }


            if (flag == false)
            {
                Single_Room dummy = new Single_Room();
                dummy.roomName = singleRoomName;
                dummy.roomQty = dummy.roomQty + 1;
                if (singleAir == "Yes" || singleAir == "yes" || singleAir == "YES")
                {
                    dummy.roomAC = true;
                }
                if (singleGamingSetup == "Yes" || singleGamingSetup == "yes" || singleGamingSetup == "YES")
                {
                    dummy.gamingSetup = true;
                }

                int roomPrice = dummy.calculateCost();
                single_rooms.Add(dummy);

                MessageBox.Show("You have created " + Convert.ToString(dummy.roomQty) + " " + dummy.roomName + " rooms which costs " + Convert.ToString(roomPrice) + " per day");
            }
        }

        private void AddDoubleRoom_Click(object sender, EventArgs e)
        {
            string doubleRoomName = doublePackageName.Text;
            string doubleAir = doubleAC.Text;
            int doubleTv = Convert.ToInt32(doubleExtraTv.Text);
            string doubleBreakfast = doubleContinentalBreakfast.Text;

            bool flag = false;

            foreach (Double_Room doubleRoom in double_rooms)
            {

                if (doubleRoom.roomName == doubleRoomName)
                {
                    flag = true;
                    doubleRoom.roomQty = doubleRoom.roomQty + 1;

                    if (doubleAir == "Yes" || doubleAir == "yes" || doubleAir == "YES")
                    {
                        doubleRoom.roomAC = true;
                    }
                    if (doubleBreakfast == "Yes" || doubleBreakfast == "yes" || doubleBreakfast == "YES")
                    {
                        doubleRoom.complimentaryBreakfast = true;
                    }

                    int roomPrice = doubleRoom.calculateCost();

                    MessageBox.Show("You have added " + Convert.ToString(doubleRoom.roomQty) + " " + doubleRoom.roomName + " rooms which costs " + Convert.ToString(roomPrice) + " Per Day.");
                }
            }

                if (flag == false)
                {
                    Double_Room dummy = new Double_Room();
                    dummy.roomName = doubleRoomName;
                    dummy.extraTV = doubleTv;
                    dummy.roomQty = dummy.roomQty + 1;
                    if (doubleAir == "Yes" || doubleAir == "yes" || doubleAir == "YES")
                    {
                        dummy.roomAC = true;
                    }
                    if (doubleBreakfast == "Yes" || doubleBreakfast == "yes" || doubleBreakfast == "YES")
                    {
                        dummy.complimentaryBreakfast = true;
                    }

                    int roomPrice = dummy.calculateCost();

                    double_rooms.Add(dummy);

                    MessageBox.Show("You have created " + Convert.ToString(dummy.roomQty) + " " + dummy.roomName + " rooms which costs " + Convert.ToString(roomPrice) + " Per Day.");
                }
            

     
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string roomRent = rentRoomName.Text;
            int rentQty = Convert.ToInt32(rentNumberRoom.Text);
            bool flag = false;
            foreach (Single_Room singleRoom in single_rooms)
            {

                if (singleRoom.roomName == roomRent && singleRoom.roomQty > rentQty)
                {
                    flag = true;
                    singleRoom.roomQty -= rentQty;
                    MessageBox.Show("You Successfully Rented" +" "+ Convert.ToString(rentQty) +" " +"Rooms. Payable Amount :" + Convert.ToString(rentQty * singleRoom.calculateCost()) + " Per Day.");
                }
                if (singleRoom.roomQty < 0)
                {
                    singleRoom.roomQty = singleRoom.roomQty + rentQty;
                    MessageBox.Show("Not Enough Rooms are free");
                    return;
                }
            }
            if (flag == false)
            {
                foreach (Double_Room doubleRoom in double_rooms)
                {

                    if (doubleRoom.roomName == roomRent && doubleRoom.roomQty > rentQty)
                    {
                        flag = true;
                        doubleRoom.roomQty -= rentQty;
                        MessageBox.Show("You Successfully Rented " +" "+ Convert.ToString(rentQty) +" "+ " Rooms. Payable Amount: " + Convert.ToString(rentQty * doubleRoom.calculateCost()) + " Per Day.");
                    }
                    if (doubleRoom.roomQty < 0)
                    {
                        doubleRoom.roomQty = doubleRoom.roomQty + rentQty;
                        MessageBox.Show("Not Enough Rooms are free.");
                        return;
                    }

                }
            }
            if (flag == false)
            {
                MessageBox.Show("Room Not Found.");
            }
        }
                

    

        private void showAvailable_Click(object sender, EventArgs e)
        {
            string SearchName = searchRoomName.Text;
            bool flag = false;
            RoomAvailability.Items.Clear();
            foreach(Single_Room singleRoom in single_rooms)
            {
                if( singleRoom.roomName == SearchName)
                {
                    flag = true;
                    string roomInfo = singleRoom.roomName + "\t" +Convert.ToString(singleRoom.roomQty) + "\t" + Convert.ToString(singleRoom.calculateCost());
                    RoomAvailability.Items.Add(roomInfo);
                }
            }
            if(flag == false)
            {
                foreach ( Double_Room doubleRoom in double_rooms)
                {
                    if( doubleRoom.roomName == SearchName)
                    {
                        flag = true;
                        string roomInfo = doubleRoom.roomName + "\t" + Convert.ToString(doubleRoom.roomQty) + "\t" + Convert.ToString(doubleRoom.calculateCost());
                        RoomAvailability.Items.Add(roomInfo);
                    }
                }
            }


        }
    }
    }

