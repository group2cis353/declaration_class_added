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
        //declaring variables
        bool yesCheck; // boolean to determine if user checks yes or no
        double declareNum; // variable to store user input
        static double dutyQty = 4; // static variable for duty quantity
        static double dutyCaseAmt = 1.50; // static variable for duty fine
        string make;
        string model;
        string plate;
        string dateTime;

        public Form5(string timeDate, string maker, string type, string license)
        {
            InitializeComponent();
            dateTime = timeDate;
            make = maker;
            model = type;
            plate = license;
        }

        //overriding ToString for data save
        public override string ToString()
        {
            return $"{make},{model},{plate},{dateTime},{ Duty.Fine:c}";
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
                    //check if there is a fine, if there is, then formats data for save then saves to file
                    if (Duty.Fine != 0)
                    {
                        string fileLine = ToString();
                        FileStream writeFile = new FileStream("Fines.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                        StreamWriter fileWrite = new StreamWriter(writeFile);
                        fileWrite.WriteLine(fileLine);
                        fileWrite.Flush();
                        writeFile.Close();
                    }
                    //ask if user wants to add another entry
                    string assessment = "Would you like to enter another assessment?";
                    string caption = "Another entry";
                    DialogResult result1 = MessageBox.Show(assessment, caption, MessageBoxButtons.YesNo);
                    //if user says yes, then opens Form2 to begin new assessment
                    if (result1 == DialogResult.Yes)
                    {
                        this.Hide();
                        Form2 vForm = new Form2();
                        vForm.ShowDialog();
                        this.Close();
                    }
                    //if user says no, closes this window and opens main menu
                    else
                    {
                        this.Hide();
                        Form1 wForm = new Form1();
                        wForm.ShowDialog();
                        this.Close();
                    }
                }
                else // returns to form
                { 

                }
            }
            else // if user selected No and clicked submit, will not save any data and go back to main page
            {
                string message = "Please confirm that you do not need to declare any cases.";
                string title = "Submit"; // confirms user does not need to declare cases
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult selection = MessageBox.Show(message, title, buttons);
                if (selection == DialogResult.OK) // saves to file
                {
                    this.Hide();
                    Form1 wForm = new Form1();
                    wForm.ShowDialog();
                    this.Close();
                }
                else // returns to form
                {

                }
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
        //pressing enter in textbox acts as if user clicked submit
        private void General_KeyDown(object sender, KeyEventArgs e)
        {
            int value = 0;
            bool numberEntered = false;
            numberEntered = int.TryParse(caseTotal.Text, out value);
            if (numberEntered)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    declareSubmit_Click(sender, e);
                }
            }
        }
    }
}
