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
        public Form3()
        {
            InitializeComponent();
        }


        private void dateEntry_DateChanged(object sender, DateRangeEventArgs e)
        {
            date = dateEntry.SelectionStart.ToShortDateString();
        }

        private void timeEntry_ValueChanged(object sender, EventArgs e)
        {
            time = timeEntry.Value.ToString("h:mm tt");
        }

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
                Form5 mForm = new Form5();
                mForm.ShowDialog();
            }
        }
    }
}

