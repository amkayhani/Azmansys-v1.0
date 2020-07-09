using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUESYSv._01
{
    public partial class Form2 : Form
    {
        dbConn mysqlConn = new dbConn();
        public Form2()
        {
            InitializeComponent();
            dbConfig();
            mysqlConn.connect();
        }
        public bool dbConfig()
        {
            try
            {
                mysqlConn.varConfigServer = "ad4622.cucstudents.org";
                mysqlConn.varConfigDatabase = "Flightbooking";
                mysqlConn.varConfigUser = "Booking";
                mysqlConn.varConfigPass = "Password123!";
                return true;
            }
            catch { return false; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlConn.connOpen();
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string varPaid;
            if (checkBox1.Checked == true) { varPaid = "Y"; }
            else { varPaid = "N"; }
            mysqlConn.insertbooking(CustContact.Text, Airline.Text, Origin.Text, Destination.Text, FlightNumber.Text, date, Time.Text, Cost.Text, varPaid);
            MessageBox.Show("Booking Finished Successfully");

        }

    }
}


