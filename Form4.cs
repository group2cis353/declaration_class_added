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
    public partial class Form4 : Form
    {
        string pSearch = null; // variable to hold user input
        public Form4()
        {
            InitializeComponent();
        }

        private void backSearchBtn_Click(object sender, EventArgs e) // method when back button clicked
        {
            this.Hide(); // hides form
            Form1 bForm = new Form1(); // instantiates Form1
            bForm.ShowDialog(); // displays Form1 (welcome page)
        }

        private void Form4_Load(object sender, EventArgs e) // method when Form4 loads
        {
            groupBox1.Visible = false; // hides all information on page except where user can input plate number 
            groupBox2.Visible = false; // submit and back button visible 
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            inputRequired.Visible = false;
        }

        private void plateSearch_TextChanged(object sender, EventArgs e) // text box for user to input vehicle plate
        {
            pSearch = plateSearch.Text; // sets user input to pSearch
        }

        private void searchBtn_Click(object sender, EventArgs e) // method when search button is clicked
        {
            if (pSearch != null) // verifies user has input in textbox 
            {
                inputRequired.Visible = false; // hides invalid message
                groupBox1.Visible = true; // displays rest of information 
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                /* search file for pSearch
                 
                displayMake.Text = "";
                displayModel.Text = "";
                displayDate.Text = "";
                displayTime.Text = "";
                displayFine.Text = "";
                */
            }
            else // user has not input plate
            {
                inputRequired.Visible = true; // displays invalid message
            }
        }
    }
}
