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
    public partial class Form3 : Form
    {

        private bool isNumber = false;
        private double numFirst;
        private double numSecond;
        private double numRes;
        public Form3()
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

        private void button2_Click(object sender, EventArgs e)
        {
            string strFirst = string.Copy(txtNm4.Text);
            string strSecond = string.Copy(txtNm5.Text);

            if (txtNm4.Text.Length > 0)
            {
                numFirst = Convert.ToDouble(strFirst);

            }
            else
            {
                numFirst = 0;
            }
            if (txtNm5.Text.Length > 0)
            {
                numSecond = Convert.ToDouble(strSecond);
            }
            else
            {
                numSecond = 0;
            }
            if(numFirst == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Выражение не имеет смысла!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(numSecond == 0)
            {
                numRes = 0;
                lblRezultatlin.Text = numRes.ToString();
            }
            else
            {
                numRes = numSecond / numFirst;
                lblRezultatlin.Text = numRes.ToString();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}