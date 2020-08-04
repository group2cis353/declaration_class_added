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
        string Make;
        string Model;
        string Plate;
        public Form2()
        {
            InitializeComponent();
        }


        private void MakeInput_TextChanged(object sender, EventArgs e)
        {
            Make = MakeInput.Text;
        }

        private void ModeLInput_TextChanged(object sender, EventArgs e)
        {
            Model = ModeLInput.Text;
        }

        private void plateInput_TextChanged(object sender, EventArgs e)
        {
            Plate = plateInput.Text.ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string message = "You have entered: \n " +
                "Make: " + Make + "\n " +
                "Model: " + Model + "\n" +
                "License Plate: " + Plate + "\n" +
                "Is this correct?";
            string title = "Submit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult selection = MessageBox.Show(message, title, buttons);
            if (selection == DialogResult.Yes)
            {
                this.Hide();
                Form3 dForm = new Form3();
                dForm.ShowDialog();
            }
            else
            {

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 wForm = new Form1();
            wForm.ShowDialog();
        }
    }
}
