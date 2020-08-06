using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Welcome_Page
{
    public partial class Form4 : Form
    {
        //variable in case more than 1 fine found and bool to verify search found a match
        int nextCounter = 2;
        bool found = false;
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
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e) // method when Form4 loads
        {
            groupBox1.Visible = false; // hides all information on page except where user can input plate number 
            groupBox2.Visible = false; // submit and back button visible 
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            inputRequired.Visible = false;
            nextFineBtn.Visible = false;
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

                //opening and searching file then displaying info if found
                string fineInfo;
                string[] info;
                const char spliter = ',';
                int counter = 0;
                FileStream readFile = new FileStream("Fines.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
                StreamReader fileRead = new StreamReader(readFile);
                fineInfo = fileRead.ReadLine();
                while (fineInfo != null)
                {
                    info = fineInfo.Split(spliter);
                    if (info[2] == pSearch)
                    {
                        found = true;
                        groupBox1.Visible = true; // displays rest of information 
                        groupBox2.Visible = true;
                        groupBox3.Visible = true;
                        groupBox5.Visible = true;
                        counter++;
                        if (counter < 2)
                        {
                            displayMake.Text = info[0];
                            displayModel.Text = info[1];
                            displayDate.Text = info[3];
                            displayFine.Text = info[4];
                        }
                        else if (counter == 2)
                        {
                            nextFineBtn.Visible = true;
                            nextCounter++;
                            break;
                        }
                    }
                    fineInfo = fileRead.ReadLine();
                    if (fineInfo == null)
                    {
                        readFile.Seek(0, SeekOrigin.Begin);
                    }
                }
                readFile.Close();
                if (found != true)
                {
                    MessageBox.Show("No match was found.");
                }
            }
            else // user has not input plate
            {
                inputRequired.Visible = true; // displays invalid message
            }
        }

        //reading and displaying next fine if more than one found
        private void nextFineBtn_Click(object sender, EventArgs e)
        {
            nextFineBtn.Visible = false;
            string fineInfo;
            string[] info;
            const char spliter = ',';
            int counter = 0;
            FileStream readFile = new FileStream("Fines.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            StreamReader fileRead = new StreamReader(readFile);
            fineInfo = fileRead.ReadLine();
            while (fineInfo != null)
            {
                info = fineInfo.Split(spliter);
                if (info[2] == pSearch)
                {
                    counter++;
                    if (counter < nextCounter)
                    {
                        displayMake.Text = info[0];
                        displayModel.Text = info[1];
                        displayDate.Text = info[3];
                        displayFine.Text = info[4];
                    }
                    else if (counter == nextCounter)
                    {
                        nextFineBtn.Visible = true;
                        nextCounter++;
                        break;
                    }
                }
                fineInfo = fileRead.ReadLine();
                if (fineInfo == null)
                {
                    readFile.Seek(0, SeekOrigin.Begin);
                }
            }
            readFile.Close();
        }
        //pressing enter in textbox acts as if user clicked search
        private void General_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    searchBtn_Click(sender, e);
                }
        }
    }
}
