using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Welcome_Page
{
    public partial class Form5 : Form
    {
        bool yesCheck; // boolean to determine if user checks yes or no
        double declareNum; // variable to store user input
        static double dutyQty = 4; // static variable for duty quantity
        static double dutyCaseAmt = 1.50; // static variable for duty fine

        public Form5()
        {
            InitializeComponent();
        }

        public class Duty // public class
        { 
            private static double fine; // variable holds final user fine
            public static double Fine // property to access private variable
            {
                get { return fine; }
                set { fine = value; }
            }
            public delegate double isFine(double dNum); // creates a delegate
            public double calcDuty(double dNum) // method to calculate duty fine, passes user input
            {
                if (dNum <= dutyQty) // checks if fine is required
                {
                    Fine = 0; // less than 4 cases, no fine
                    return Fine;
                }
                else
                {
                    dNum -= dutyQty; // subtracts dutyQty from user input
                    Fine = dNum * dutyCaseAmt; // more than 4 cases, calculate fine
                    return Fine;
                }
            }
            public static double getFine() // method to return value of Fine
            {
                return Fine;
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void yesBtn_CheckedChanged(object sender, EventArgs e) // method for yes button selected
        {
            this.caseLabel.Visible = true; // shows labels, textbox, submit button
            this.caseTotal.Visible = true;
            this.totLabel.Visible = true;
            this.displayFine.Visible = false;
            this.declareSubmit.Visible = true;
            this.caseInvalid.Visible = false; 
            yesCheck = true; // true because yesBtn was clicked

        }

        private void noBtn_CheckedChanged(object sender, EventArgs e) // method for no button selected
        {
            this.caseLabel.Visible = false; // hides everything except submit button
            this.caseTotal.Visible = false;
            this.totLabel.Visible = false;
            this.displayFine.Visible = false;
            this.declareSubmit.Visible = true;
            this.caseInvalid.Visible = false;
            yesCheck = false; // false because noBtn clicked
        }

        private void caseTotal_TextChanged(object sender, EventArgs e) // method to accept user input
        {
            try
            {
                declareNum = Convert.ToDouble(caseTotal.Text); // checks user input for integers, sets input to declareNum
                this.caseInvalid.Visible = false; // hides invalid input message
            }
            catch (System.FormatException) // catches exception if user did not input integers
            {
                this.caseInvalid.Visible = true; // display invalid message
                this.caseInvalid.Text = "Please enter a number."; // sets invalid message text
            }
            Duty obj = new Duty(); // creates instance of class
            Duty.isFine del_obj = new Duty.isFine(obj.calcDuty); // instantiates delegate, calls calcDuty method
            del_obj(declareNum); 
            this.displayFine.Visible = true; // displays Fine
            this.displayFine.Text = Duty.getFine().ToString("C2", CultureInfo.CurrentCulture);
            // calls getFine method, converts to string, and shows text to user
        }   

        private void declareSubmit_Click(object sender, EventArgs e) // method for submit button
        { 
            if (yesCheck) // is user entered duty information
            {
                string message = "The total duty fine is " + Duty.getFine().ToString("C2", CultureInfo.CurrentCulture);
                string title = "Submit"; // message box for user to confirm inputs
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult selection = MessageBox.Show(message, title, buttons);
                if (selection == DialogResult.OK) // saves to file
                {
                    
                }
                else // returns to form
                { 

                }
            }
            else // user did not input duty information
            {
                string message = "Confirm that You do not need to declare any cases.";
                string title = "Submit"; // confirms user does not need to declare cases
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult selection = MessageBox.Show(message, title, buttons);
                if (selection == DialogResult.OK) // saves to file
                {
                  
                }
                else // returns to form
                {

                }
            }
        }
    }
}
