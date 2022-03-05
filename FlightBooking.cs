using System;
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
    public partial class FlightBooking : Form
    {
        public static Boolean Passportl , IDCard ;
        public static string  From, To, TripstartDate, TripendDate, FirstName, LastName, DocumentNo, IssueDate, ExpiryDate, WeighBaggage ;

        public FlightBooking()
        {
            InitializeComponent();
        }

        private void Lblto_Click(object sender, EventArgs e)
        {

        }

        private void Txtto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lblfrom_Click(object sender, EventArgs e)
        {

        }

        private void Txtfrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            To = Txtto.Text;
            From = Txtfrom.Text;

            TripstartDate = monthCalendar1.SelectionStart.ToString("dd mm yyyy");
            TripendDate = monthCalendar1.SelectionEnd.ToString("dd mm yyyy");

            FirstName = Txtfirstname.Text;
            LastName = Txtlastname.Text;
            DocumentNo = Docno.Text;

            IssueDate = dateTimePicker1.Value.ToString("dd mm yyyy");
            ExpiryDate = dateTimePicker1.Value.ToString("dd mm yyyy");

            WeighBaggage = numericUpDown1.Value.ToString();

            this.Hide();

            Form1 ff1 = new Form1();
            ff1.Show();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FlightBooking_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;

            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Lbln_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label2.Text = "IDCard No";
                label3.Text = "IDCard Issue Date";
                label4.Text = "IDCard Expiry Date";

                IDCard = true;

            }
            else
            {
                IDCard = false;
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;

        }

        private void Passportl_CheckedChanged(object sender, EventArgs e)
        {

            if (Passport.Checked)
            {
                label2.Text = "Passport No";
                label3.Text = "Passport Issue Date";
                label4.Text = "Passport Expiry Date";

                Passportl = true;

            }
            else
            {
                Passportl = false;
            }
           
        }
    }
}
