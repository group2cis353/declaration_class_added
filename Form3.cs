using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Welcome_Page
{
    public partial class Form3 : Form
    {
        //decalring variables
        string date = null;
        string time = null;
        string dateTime = null;
        string maker;
        string type;
        string license;

        public Form3(string make, string model, string plate)
        {
            InitializeComponent();
            maker = make;
            type = model;
            license = plate;
        }

        //date selection
        private void dateEntry_DateChanged(object sender, DateRangeEventArgs e)
        {
            date = dateEntry.SelectionStart.ToShortDateString();
        }

        //time selection
        private void timeEntry_ValueChanged(object sender, EventArgs e)
        {
            time = timeEntry.Value.ToString("h:mm tt");
        }

        //displays message if no date and/or time selected
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (date == null && time == null)
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Please select a date and time.";
            }
            else if (date == null)
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Please select a date.";
            }
            else if (time == null)
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Please select a time.";
            }
            else
            {
                errorMessage.Visible = false;
                dateTime = $"{date} {time}";
                this.Hide();
                Form5 mForm = new Form5(dateTime, maker, type, license);
                mForm.ShowDialog();
                this.Close();
            }
        }

        //returns to main menu if user want to cancel assessment
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            string cancel = "Would you like to cancel the current assessment?";
            string title = "Cancel";
            DialogResult result1 = MessageBox.Show(cancel, title, MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Hide();
                Form1 wForm = new Form1();
                wForm.ShowDialog();
                this.Close();
            }

        }
    }
}

