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
        public Form4()
        {
            InitializeComponent();
        }

        private void backSearchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bForm = new Form1();
            bForm.ShowDialog();
        }
    }
}
