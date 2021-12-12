using System;

namespace Hotel_Rental_System
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
            this.AddSingleRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.singlePackageName = new System.Windows.Forms.TextBox();
            this.singleAC = new System.Windows.Forms.TextBox();
            this.singleGaming = new System.Windows.Forms.TextBox();
            this.doublePackageName = new System.Windows.Forms.TextBox();
            this.doubleAC = new System.Windows.Forms.TextBox();
            this.doubleExtraTv = new System.Windows.Forms.TextBox();
            this.doubleContinentalBreakfast = new System.Windows.Forms.TextBox();
            this.rentRoomName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rentNumberRoom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.searchRoomName = new System.Windows.Forms.TextBox();
            this.showAvailable = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RoomAvailability = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddSingleRoom
            // 
            this.AddSingleRoom.Location = new System.Drawing.Point(276, 69);
            this.AddSingleRoom.Name = "AddSingleRoom";
            this.AddSingleRoom.Size = new System.Drawing.Size(75, 40);
            this.AddSingleRoom.TabIndex = 0;
            this.AddSingleRoom.Text = "Add Single Room";
            this.AddSingleRoom.UseVisualStyleBackColor = true;
            this.AddSingleRoom.Click += new System.EventHandler(this.AddSingleRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Air Condition:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gaming Setup:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Air Condition:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Extra TV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Continental Breakfast:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add Double Room";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddDoubleRoom_Click);
            // 
            // singlePackageName
            // 
            this.singlePackageName.Location = new System.Drawing.Point(130, 56);
            this.singlePackageName.Name = "singlePackageName";
            this.singlePackageName.Size = new System.Drawing.Size(100, 20);
            this.singlePackageName.TabIndex = 9;
            // 
            // singleAC
            // 
            this.singleAC.Location = new System.Drawing.Point(130, 82);
            this.singleAC.Name = "singleAC";
            this.singleAC.Size = new System.Drawing.Size(100, 20);
            this.singleAC.TabIndex = 10;
            // 
            // singleGaming
            // 
            this.singleGaming.Location = new System.Drawing.Point(130, 108);
            this.singleGaming.Name = "singleGaming";
            this.singleGaming.Size = new System.Drawing.Size(100, 20);
            this.singleGaming.TabIndex = 11;
            // 
            // doublePackageName
            // 
            this.doublePackageName.Location = new System.Drawing.Point(130, 205);
            this.doublePackageName.Name = "doublePackageName";
            this.doublePackageName.Size = new System.Drawing.Size(100, 20);
            this.doublePackageName.TabIndex = 12;
            // 
            // doubleAC
            // 
            this.doubleAC.Location = new System.Drawing.Point(130, 229);
            this.doubleAC.Name = "doubleAC";
            this.doubleAC.Size = new System.Drawing.Size(100, 20);
            this.doubleAC.TabIndex = 13;
            // 
            // doubleExtraTv
            // 
            this.doubleExtraTv.Location = new System.Drawing.Point(130, 255);
            this.doubleExtraTv.Name = "doubleExtraTv";
            this.doubleExtraTv.Size = new System.Drawing.Size(100, 20);
            this.doubleExtraTv.TabIndex = 14;
            // 
            // doubleContinentalBreakfast
            // 
            this.doubleContinentalBreakfast.Location = new System.Drawing.Point(130, 278);
            this.doubleContinentalBreakfast.Name = "doubleContinentalBreakfast";
            this.doubleContinentalBreakfast.Size = new System.Drawing.Size(100, 20);
            this.doubleContinentalBreakfast.TabIndex = 15;
            // 
            // rentRoomName
            // 
            this.rentRoomName.Location = new System.Drawing.Point(583, 69);
            this.rentRoomName.Name = "rentRoomName";
            this.rentRoomName.Size = new System.Drawing.Size(100, 20);
            this.rentRoomName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Room Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Number of Rooms: ";
            // 
            // rentNumberRoom
            // 
            this.rentNumberRoom.Location = new System.Drawing.Point(583, 104);
            this.rentNumberRoom.Name = "rentNumberRoom";
            this.rentNumberRoom.Size = new System.Drawing.Size(100, 20);
            this.rentNumberRoom.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(439, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Room Name:";
            // 
            // searchRoomName
            // 
            this.searchRoomName.Location = new System.Drawing.Point(583, 244);
            this.searchRoomName.Name = "searchRoomName";
            this.searchRoomName.Size = new System.Drawing.Size(100, 20);
            this.searchRoomName.TabIndex = 21;
            // 
            // showAvailable
            // 
            this.showAvailable.Location = new System.Drawing.Point(701, 233);
            this.showAvailable.Name = "showAvailable";
            this.showAvailable.Size = new System.Drawing.Size(75, 40);
            this.showAvailable.TabIndex = 23;
            this.showAvailable.Text = "Show Availability";
            this.showAvailable.UseVisualStyleBackColor = true;
            this.showAvailable.Click += new System.EventHandler(this.showAvailable_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(405, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(10, 382);
            this.button5.TabIndex = 24;
            this.button5.Text = "Add Single Room";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(442, 178);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(346, 10);
            this.button6.TabIndex = 25;
            this.button6.Text = "Add Single Room";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 178);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(346, 10);
            this.button7.TabIndex = 26;
            this.button7.Text = "Add Single Room";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Rent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RoomAvailability
            // 
            this.RoomAvailability.FormattingEnabled = true;
            this.RoomAvailability.Location = new System.Drawing.Point(462, 281);
            this.RoomAvailability.Name = "RoomAvailability";
            this.RoomAvailability.Size = new System.Drawing.Size(314, 108);
            this.RoomAvailability.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoomAvailability);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.showAvailable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchRoomName);
            this.Controls.Add(this.rentNumberRoom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rentRoomName);
            this.Controls.Add(this.doubleContinentalBreakfast);
            this.Controls.Add(this.doubleExtraTv);
            this.Controls.Add(this.doubleAC);
            this.Controls.Add(this.doublePackageName);
            this.Controls.Add(this.singleGaming);
            this.Controls.Add(this.singleAC);
            this.Controls.Add(this.singlePackageName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddSingleRoom);
            this.Name = "Form1";
            this.Text = "Trivago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void rentRoom_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button AddSingleRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox singlePackageName;
        private System.Windows.Forms.TextBox singleAC;
        private System.Windows.Forms.TextBox singleGaming;
        private System.Windows.Forms.TextBox doublePackageName;
        private System.Windows.Forms.TextBox doubleAC;
        private System.Windows.Forms.TextBox doubleExtraTv;
        private System.Windows.Forms.TextBox doubleContinentalBreakfast;
        private System.Windows.Forms.TextBox rentRoomName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rentNumberRoom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchRoomName;
        private System.Windows.Forms.Button showAvailable;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox RoomAvailability;
    }
}

