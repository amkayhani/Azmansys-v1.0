namespace CUESYSv._01
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CustContact = new System.Windows.Forms.TextBox();
            this.Origin = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.TextBox();
            this.Airline = new System.Windows.Forms.TextBox();
            this.FlightNumber = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustContact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Airline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 739);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 775);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Flight Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 818);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Paid";
            // 
            // CustContact
            // 
            this.CustContact.Location = new System.Drawing.Point(224, 62);
            this.CustContact.Name = "CustContact";
            this.CustContact.Size = new System.Drawing.Size(201, 31);
            this.CustContact.TabIndex = 9;
            // 
            // Origin
            // 
            this.Origin.Location = new System.Drawing.Point(224, 158);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(208, 31);
            this.Origin.TabIndex = 10;
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(224, 234);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(208, 31);
            this.Destination.TabIndex = 11;
            this.Destination.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Airline
            // 
            this.Airline.Location = new System.Drawing.Point(224, 309);
            this.Airline.Name = "Airline";
            this.Airline.Size = new System.Drawing.Size(189, 31);
            this.Airline.TabIndex = 12;
            // 
            // FlightNumber
            // 
            this.FlightNumber.Location = new System.Drawing.Point(209, 370);
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.Size = new System.Drawing.Size(204, 31);
            this.FlightNumber.TabIndex = 13;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(115, 738);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(100, 31);
            this.Time.TabIndex = 14;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(108, 775);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(100, 31);
            this.Cost.TabIndex = 15;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(123, 818);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(28, 27);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 865);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(76, 413);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 966);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.FlightNumber);
            this.Controls.Add(this.Airline);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.Origin);
            this.Controls.Add(this.CustContact);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CustContact;
        private System.Windows.Forms.TextBox Origin;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.TextBox Airline;
        private System.Windows.Forms.TextBox FlightNumber;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}