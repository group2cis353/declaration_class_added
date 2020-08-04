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
        bool yesCheck;
        double declareNum;
        static double dutyQty = 4;
        static double dutyCaseAmt = 1.50;
        public double custFine;
        public Form5()
        {
            InitializeComponent();
        }

        public class Duty
        {
            public static double fine;
            public static double Fine
            {
                get { return fine; }
                set { fine = value; }
            }
            public delegate double isFine(double dNum);
            public double calcDuty(double dNum)
            {
                if (dNum < dutyQty)
                {
                    Fine = 0;
                    return Fine;
                }
                else
                {
                    Fine = dNum * dutyCaseAmt;
                    return Fine;
                }
            }
            public static double getFine()
            {
                return Fine;
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void yesBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.caseLabel.Visible = true;
            this.caseTotal.Visible = true;
            this.totLabel.Visible = true;
            this.displayFine.Visible = false;
            this.declareSubmit.Visible = true;
            this.caseInvalid.Visible = false;
            yesCheck = true;

        }

        private void noBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.caseLabel.Visible = false;
            this.caseTotal.Visible = false;
            this.totLabel.Visible = false;
            this.displayFine.Visible = false;
            this.declareSubmit.Visible = true;
            this.caseInvalid.Visible = false;
            yesCheck = false;
        }

        private void caseTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                declareNum = Convert.ToDouble(caseTotal.Text);
                this.caseInvalid.Visible = false;
            }
            catch (System.FormatException)
            {
                this.caseInvalid.Visible = true;
                this.caseInvalid.Text = "Please enter a number.";
            }
            Duty obj = new Duty();
            Duty.isFine del_obj = new Duty.isFine(obj.calcDuty);
            del_obj(declareNum);
            this.displayFine.Visible = true;
            this.displayFine.Text = Duty.getFine().ToString("C2", CultureInfo.CurrentCulture);
        }

        private void declareSubmit_Click(object sender, EventArgs e)
        {
            if (yesCheck)
            {
                string message = "The total duty fine is " + Duty.getFine().ToString("C2", CultureInfo.CurrentCulture);
                string title = "Submit";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult selection = MessageBox.Show(message, title, buttons);
                if (selection == DialogResult.OK)
                {
                    
                }
                else
                {

                }
            }
            else
            {
                string message = "Confirm that You do not need to declare any cases.";
                string title = "Submit";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult selection = MessageBox.Show(message, title, buttons);
                if (selection == DialogResult.OK)
                {
                  
                }
                else
                {

                }
            }
        }
    }
}
