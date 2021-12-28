namespace Hotel_Management_System_II
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BookingIDOwnerTextBox = new System.Windows.Forms.TextBox();
            this.BookingIDComboBox = new System.Windows.Forms.ComboBox();
            this.SetStatusButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CreateUserIDTextBox = new System.Windows.Forms.TextBox();
            this.CreateUserNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateUserContactTextBox = new System.Windows.Forms.TextBox();
            this.CreateUserAddressTextBox = new System.Windows.Forms.TextBox();
            this.PlaceDepartureDateTextBox = new System.Windows.Forms.TextBox();
            this.PlaceEntryDateTextBox = new System.Windows.Forms.TextBox();
            this.PlaceUserIDTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.CurrentBalanceLabel = new System.Windows.Forms.Label();
            this.RoomDetailsListBox = new System.Windows.Forms.ListBox();
            this.RoomDetailsButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.BookingIDUserTextBox = new System.Windows.Forms.TextBox();
            this.PlaceRoomQtyComboBox = new System.Windows.Forms.ComboBox();
            this.PlaceRoomChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.OrderAmountLabel = new System.Windows.Forms.Label();
            this.OrderStatusLabel = new System.Windows.Forms.Label();
            this.OrderUserAddressLabel = new System.Windows.Forms.Label();
            this.OrderUserNameLabel = new System.Windows.Forms.Label();
            this.OrderDetailsButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Booking ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current Balance :";
            // 
            // BookingIDOwnerTextBox
            // 
            this.BookingIDOwnerTextBox.Location = new System.Drawing.Point(84, 67);
            this.BookingIDOwnerTextBox.Name = "BookingIDOwnerTextBox";
            this.BookingIDOwnerTextBox.Size = new System.Drawing.Size(81, 20);
            this.BookingIDOwnerTextBox.TabIndex = 4;
            // 
            // BookingIDComboBox
            // 
            this.BookingIDComboBox.FormattingEnabled = true;
            this.BookingIDComboBox.Location = new System.Drawing.Point(171, 67);
            this.BookingIDComboBox.Name = "BookingIDComboBox";
            this.BookingIDComboBox.Size = new System.Drawing.Size(87, 21);
            this.BookingIDComboBox.TabIndex = 5;
            // 
            // SetStatusButton
            // 
            this.SetStatusButton.Location = new System.Drawing.Point(15, 134);
            this.SetStatusButton.Name = "SetStatusButton";
            this.SetStatusButton.Size = new System.Drawing.Size(243, 30);
            this.SetStatusButton.TabIndex = 6;
            this.SetStatusButton.Text = "Set Status";
            this.SetStatusButton.UseVisualStyleBackColor = true;
            this.SetStatusButton.Click += new System.EventHandler(this.SetStatusButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "User ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Contact No :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Address :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(545, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Departure Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Entry Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(545, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Room Choice :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "User ID :";
            // 
            // CreateUserIDTextBox
            // 
            this.CreateUserIDTextBox.Location = new System.Drawing.Point(381, 67);
            this.CreateUserIDTextBox.Name = "CreateUserIDTextBox";
            this.CreateUserIDTextBox.Size = new System.Drawing.Size(81, 20);
            this.CreateUserIDTextBox.TabIndex = 15;
            // 
            // CreateUserNameTextBox
            // 
            this.CreateUserNameTextBox.Location = new System.Drawing.Point(381, 100);
            this.CreateUserNameTextBox.Name = "CreateUserNameTextBox";
            this.CreateUserNameTextBox.Size = new System.Drawing.Size(81, 20);
            this.CreateUserNameTextBox.TabIndex = 16;
            // 
            // CreateUserContactTextBox
            // 
            this.CreateUserContactTextBox.Location = new System.Drawing.Point(381, 139);
            this.CreateUserContactTextBox.Name = "CreateUserContactTextBox";
            this.CreateUserContactTextBox.Size = new System.Drawing.Size(81, 20);
            this.CreateUserContactTextBox.TabIndex = 17;
            // 
            // CreateUserAddressTextBox
            // 
            this.CreateUserAddressTextBox.Location = new System.Drawing.Point(381, 172);
            this.CreateUserAddressTextBox.Name = "CreateUserAddressTextBox";
            this.CreateUserAddressTextBox.Size = new System.Drawing.Size(81, 20);
            this.CreateUserAddressTextBox.TabIndex = 18;
            // 
            // PlaceDepartureDateTextBox
            // 
            this.PlaceDepartureDateTextBox.Location = new System.Drawing.Point(637, 168);
            this.PlaceDepartureDateTextBox.Name = "PlaceDepartureDateTextBox";
            this.PlaceDepartureDateTextBox.Size = new System.Drawing.Size(81, 20);
            this.PlaceDepartureDateTextBox.TabIndex = 22;
            // 
            // PlaceEntryDateTextBox
            // 
            this.PlaceEntryDateTextBox.Location = new System.Drawing.Point(637, 135);
            this.PlaceEntryDateTextBox.Name = "PlaceEntryDateTextBox";
            this.PlaceEntryDateTextBox.Size = new System.Drawing.Size(81, 20);
            this.PlaceEntryDateTextBox.TabIndex = 21;
            // 
            // PlaceUserIDTextBox
            // 
            this.PlaceUserIDTextBox.Location = new System.Drawing.Point(637, 63);
            this.PlaceUserIDTextBox.Name = "PlaceUserIDTextBox";
            this.PlaceUserIDTextBox.Size = new System.Drawing.Size(81, 20);
            this.PlaceUserIDTextBox.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(545, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Quantity :";
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(309, 203);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(201, 23);
            this.CreateAccountButton.TabIndex = 25;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Location = new System.Drawing.Point(724, 107);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(64, 57);
            this.PlaceOrderButton.TabIndex = 26;
            this.PlaceOrderButton.Text = "Place Booking";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(282, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(506, 10);
            this.button4.TabIndex = 27;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(279, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(10, 429);
            this.button5.TabIndex = 28;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // CurrentBalanceLabel
            // 
            this.CurrentBalanceLabel.AutoSize = true;
            this.CurrentBalanceLabel.Location = new System.Drawing.Point(107, 107);
            this.CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            this.CurrentBalanceLabel.Size = new System.Drawing.Size(25, 13);
            this.CurrentBalanceLabel.TabIndex = 29;
            this.CurrentBalanceLabel.Text = "Null";
            // 
            // RoomDetailsListBox
            // 
            this.RoomDetailsListBox.FormattingEnabled = true;
            this.RoomDetailsListBox.Location = new System.Drawing.Point(12, 203);
            this.RoomDetailsListBox.Name = "RoomDetailsListBox";
            this.RoomDetailsListBox.Size = new System.Drawing.Size(246, 160);
            this.RoomDetailsListBox.TabIndex = 30;
            // 
            // RoomDetailsButton
            // 
            this.RoomDetailsButton.Location = new System.Drawing.Point(15, 382);
            this.RoomDetailsButton.Name = "RoomDetailsButton";
            this.RoomDetailsButton.Size = new System.Drawing.Size(243, 30);
            this.RoomDetailsButton.TabIndex = 31;
            this.RoomDetailsButton.Text = "Show Room Details";
            this.RoomDetailsButton.UseVisualStyleBackColor = true;
            this.RoomDetailsButton.Click += new System.EventHandler(this.RoomDetailsButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(307, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Booking ID :";
            // 
            // BookingIDUserTextBox
            // 
            this.BookingIDUserTextBox.Location = new System.Drawing.Point(379, 264);
            this.BookingIDUserTextBox.Name = "BookingIDUserTextBox";
            this.BookingIDUserTextBox.Size = new System.Drawing.Size(81, 20);
            this.BookingIDUserTextBox.TabIndex = 33;
            // 
            // PlaceRoomQtyComboBox
            // 
            this.PlaceRoomQtyComboBox.FormattingEnabled = true;
            this.PlaceRoomQtyComboBox.Location = new System.Drawing.Point(637, 203);
            this.PlaceRoomQtyComboBox.Name = "PlaceRoomQtyComboBox";
            this.PlaceRoomQtyComboBox.Size = new System.Drawing.Size(81, 21);
            this.PlaceRoomQtyComboBox.TabIndex = 34;
            // 
            // PlaceRoomChoiceComboBox
            // 
            this.PlaceRoomChoiceComboBox.FormattingEnabled = true;
            this.PlaceRoomChoiceComboBox.Location = new System.Drawing.Point(637, 100);
            this.PlaceRoomChoiceComboBox.Name = "PlaceRoomChoiceComboBox";
            this.PlaceRoomChoiceComboBox.Size = new System.Drawing.Size(81, 21);
            this.PlaceRoomChoiceComboBox.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(307, 340);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Amount :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(307, 304);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Status :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(543, 340);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Address :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(545, 304);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "User Name :";
            // 
            // OrderAmountLabel
            // 
            this.OrderAmountLabel.AutoSize = true;
            this.OrderAmountLabel.Location = new System.Drawing.Point(378, 340);
            this.OrderAmountLabel.Name = "OrderAmountLabel";
            this.OrderAmountLabel.Size = new System.Drawing.Size(25, 13);
            this.OrderAmountLabel.TabIndex = 44;
            this.OrderAmountLabel.Text = "Null";
            // 
            // OrderStatusLabel
            // 
            this.OrderStatusLabel.AutoSize = true;
            this.OrderStatusLabel.Location = new System.Drawing.Point(378, 304);
            this.OrderStatusLabel.Name = "OrderStatusLabel";
            this.OrderStatusLabel.Size = new System.Drawing.Size(25, 13);
            this.OrderStatusLabel.TabIndex = 42;
            this.OrderStatusLabel.Text = "Null";
            // 
            // OrderUserAddressLabel
            // 
            this.OrderUserAddressLabel.AutoSize = true;
            this.OrderUserAddressLabel.Location = new System.Drawing.Point(617, 340);
            this.OrderUserAddressLabel.Name = "OrderUserAddressLabel";
            this.OrderUserAddressLabel.Size = new System.Drawing.Size(25, 13);
            this.OrderUserAddressLabel.TabIndex = 46;
            this.OrderUserAddressLabel.Text = "Null";
            // 
            // OrderUserNameLabel
            // 
            this.OrderUserNameLabel.AutoSize = true;
            this.OrderUserNameLabel.Location = new System.Drawing.Point(617, 304);
            this.OrderUserNameLabel.Name = "OrderUserNameLabel";
            this.OrderUserNameLabel.Size = new System.Drawing.Size(25, 13);
            this.OrderUserNameLabel.TabIndex = 45;
            this.OrderUserNameLabel.Text = "Null";
            // 
            // OrderDetailsButton
            // 
            this.OrderDetailsButton.Location = new System.Drawing.Point(420, 408);
            this.OrderDetailsButton.Name = "OrderDetailsButton";
            this.OrderDetailsButton.Size = new System.Drawing.Size(243, 30);
            this.OrderDetailsButton.TabIndex = 47;
            this.OrderDetailsButton.Text = "Show Order Details";
            this.OrderDetailsButton.UseVisualStyleBackColor = true;
            this.OrderDetailsButton.Click += new System.EventHandler(this.OrderDetailsButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(541, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 25);
            this.label14.TabIndex = 48;
            this.label14.Text = "Date : (dd.mm.yy)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.OrderDetailsButton);
            this.Controls.Add(this.OrderUserAddressLabel);
            this.Controls.Add(this.OrderUserNameLabel);
            this.Controls.Add(this.OrderAmountLabel);
            this.Controls.Add(this.OrderStatusLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.PlaceRoomChoiceComboBox);
            this.Controls.Add(this.PlaceRoomQtyComboBox);
            this.Controls.Add(this.BookingIDUserTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.RoomDetailsButton);
            this.Controls.Add(this.RoomDetailsListBox);
            this.Controls.Add(this.CurrentBalanceLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PlaceOrderButton);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PlaceDepartureDateTextBox);
            this.Controls.Add(this.PlaceEntryDateTextBox);
            this.Controls.Add(this.PlaceUserIDTextBox);
            this.Controls.Add(this.CreateUserAddressTextBox);
            this.Controls.Add(this.CreateUserContactTextBox);
            this.Controls.Add(this.CreateUserNameTextBox);
            this.Controls.Add(this.CreateUserIDTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SetStatusButton);
            this.Controls.Add(this.BookingIDComboBox);
            this.Controls.Add(this.BookingIDOwnerTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hotel Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BookingIDOwnerTextBox;
        private System.Windows.Forms.ComboBox BookingIDComboBox;
        private System.Windows.Forms.Button SetStatusButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CreateUserIDTextBox;
        private System.Windows.Forms.TextBox CreateUserNameTextBox;
        private System.Windows.Forms.TextBox CreateUserContactTextBox;
        private System.Windows.Forms.TextBox CreateUserAddressTextBox;
        private System.Windows.Forms.TextBox PlaceDepartureDateTextBox;
        private System.Windows.Forms.TextBox PlaceEntryDateTextBox;
        private System.Windows.Forms.TextBox PlaceUserIDTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label CurrentBalanceLabel;
        private System.Windows.Forms.ListBox RoomDetailsListBox;
        private System.Windows.Forms.Button RoomDetailsButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox BookingIDUserTextBox;
        private System.Windows.Forms.ComboBox PlaceRoomQtyComboBox;
        private System.Windows.Forms.ComboBox PlaceRoomChoiceComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label OrderAmountLabel;
        private System.Windows.Forms.Label OrderStatusLabel;
        private System.Windows.Forms.Label OrderUserAddressLabel;
        private System.Windows.Forms.Label OrderUserNameLabel;
        private System.Windows.Forms.Button OrderDetailsButton;
        private System.Windows.Forms.Label label14;
    }
}

