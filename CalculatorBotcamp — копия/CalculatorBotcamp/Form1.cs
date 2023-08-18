using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorBotcamp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void lblLinkCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new Form2();
            frm.Show();
        }

        private void lblLinkCalculator2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm1 = new Form3();
            frm1.Show();
        }

        private void lblLinkCalculator3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm2 = new Form4();
            frm2.Show();
        }
    }
}