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
    public partial class Form2 : Form
    {
        string Make = null; // variable to hold Make
        string Model = null; // variable to hold Model
        string Plate = null; // variable to hold Plate
        public Form2()
        {
            InitializeComponent();
        }


        private void MakeInput_TextChanged(object sender, EventArgs e) // method for user to input Make
        {
             Make = MakeInput.Text; // sets user input to Make variable
        }   

        private void ModeLInput_TextChanged(object sender, EventArgs e) // method for user to input Model
        { 
            Model = ModeLInput.Text; // sets user input to Model variable
        }

        private void plateInput_TextChanged(object sender, EventArgs e) // method for user to input Plate
        {
            Plate = plateInput.Text.ToString(); // sets user input to Plate variable
        }

        private void submitBtn_Click(object sender, EventArgs e) // method when submit button is clicked
        {
            if (Make != null && Model != null && Plate != null) // checks that all fields have been entered
            {
                string message = "You have entered: \n" +
                    "Make: " + Make + "\n" +
                    "Model: " + Model + "\n" +
                    "License Plate: " + Plate + "\n" +
                    "Is this correct?"; // message to verify input
                string title = "Submit";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo; // yes no buttons on message box
                DialogResult selection = MessageBox.Show(message, title, buttons); // displays message box, sets user selection (yes or no) to selection
                if (selection == DialogResult.Yes) // user selects yes
                {
                    this.Hide(); // hides this form
                    Form3 dForm = new Form3(Make, Model, Plate); // instantiates Form3
                    dForm.ShowDialog(); // opens Form3 (date details)
                    this.Close();
                }
                else
                {
                    // returns to form
                }
            }
            else // user has not entered all fields
            {
                string message1 = "All fields are required."; // message to notify user
                string title1 = "Invalid Input";
                MessageBoxButtons btn1 = MessageBoxButtons.OK; // OK buttons on message box
                MessageBox.Show(message1, title1, btn1); // displays message box
            }
        }

        private void backBtn_Click(object sender, EventArgs e) // method whe back button is clicked
        {
            this.Hide(); // hides this form
            Form1 wForm = new Form1(); // instantiates Form1
            wForm.ShowDialog(); // opens Form1 (welcome page)
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
