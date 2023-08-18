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
    public partial class Form2 : Form
    {
        private bool isNumber = false;
        private double numFirst;
        private double numSecond;
        private double numRes;

        public Form2()
        {
            InitializeComponent();
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            isNumber = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9
                           || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9
                           || e.KeyCode == Keys.Back;

        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            switch (e.KeyChar)
            {
                case '-':
                    if (box.Text.Length == 0)
                    {
                        isNumber = true;
                    }
                    break;
                case '.':
                case ',':
                    if (box.Text.Length == 0)
                    {
                        isNumber = false;
                        break;
                    }
                    if ((box.Text[0] != '-' && box.Text.Length == 1 && !(box.Text.Contains(',') || box.Text.Contains('.'))) || (box.Text.Length == 2 && !(box.Text.Contains(','))))
                    {
                        isNumber = true;
                        break;
                    }
                    break;
                case '!':
                case '"':
                case '№':
                case ';':
                case '%':
                case ':':
                case '?':
                case '(':
                case ')':
                case '@':
                case '#':
                case '$':
                case '^':
                case '&':
                case '*':
                    isNumber = false;
                    break;

            }
            if (!isNumber)
            {
                e.Handled = true;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string strFirst = string.Copy(txtNm1.Text);
            string strSecond = string.Copy(txtNm2.Text);

            if (txtNm1.Text.Length > 0)
            {
                numFirst = Convert.ToDouble(strFirst);

            }
            else
            {
                numFirst = 0;
            }
            if (txtNm2.Text.Length > 0)
            {
                numSecond = Convert.ToDouble(strSecond);
            }
            else
            {
                numSecond = 0;
            }

            bool dividFlag = false;
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnPlus":
                    numRes = numFirst + numSecond;
                    lblResault.Text = numRes.ToString();
                    break;
                case "btnMinus":
                    numRes = numFirst - numSecond;
                    lblResault.Text = numRes.ToString();
                    break;
                case "btnMultiplay":
                    numRes = numFirst * numSecond;
                    lblResault.Text = numRes.ToString();
                    break;
                case "btnDivide":
                    if (Math.Abs(numSecond) < 1.0E-30)
                    {
                        DialogResult dialogResult = MessageBox.Show("Делить на 0 нельзя!◘", "Ошибочка! <3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        numRes = numFirst / numSecond;
                        lblResault.Text = numRes.ToString();
                    }
                    break;
            }


            if (!dividFlag)
            {
                lblResault.Text = Convert.ToString(numRes);
            }



        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            string strFirst = string.Copy(txtNm3.Text);

            if (txtNm3.Text.Length > 0)
            {
                numFirst = Convert.ToDouble(strFirst);

            }
            else
            {
                numFirst = 0;
            }

            bool dividFlag = false;
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnSin":
                    numRes = Math.Sin(numFirst) ;
                    lblResault.Text = numRes.ToString();
                    break;
                case "btnCos":
                    numRes = Math.Cos(numFirst);
                    lblResault.Text = numRes.ToString();
                    break;
                case "btnTan":
                    numRes = Math.Tan(numFirst);
                    lblResault.Text = numRes.ToString();
                    break;
                case "btnCot":
                    numRes = 1/Math.Tan(numFirst);
                    lblResault.Text = numRes.ToString();
                    break;
            }


            if (!dividFlag)
            {
                lblResault.Text = Convert.ToString(numRes);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}