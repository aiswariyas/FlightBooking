﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lblfrom_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (FlightBooking.Passportl)
            {
                Lbldoc.Text = "passprt no: ";
                LblDocexp.Text = "Passport Expiry Date: ";
            }
            if (FlightBooking.IDCard)
            {
                Lbldoc.Text = "IDCard no: ";
                LblDocexp.Text = "IDCard Expiry Date: ";
            }
            Lblfn.Text = FlightBooking.FirstName + " " + FlightBooking.LastName;
            Lbldeptcity.Text = FlightBooking.From;
            Lbldestcity.Text = FlightBooking.To;
            LblTrp.Text = FlightBooking.TripstartDate + " " + FlightBooking.TripendDate;
            Lbldoc.Text = FlightBooking.DocumentNo;
            LblDocexp.Text = FlightBooking.ExpiryDate;
            Lblbaggages.Text = FlightBooking.WeighBaggage;





        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
