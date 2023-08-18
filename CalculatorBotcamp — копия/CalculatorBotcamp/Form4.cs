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
    public partial class Form4 : Form
    {
        private bool isNumber = false;
        private double numFirst;
        private double numSecond;
        private double numRes;
        private double numThird;
        private double dis;
        private double numRes1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

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
        }   }

        private void btnRes_Click(object sender, EventArgs e)
        {
            string strFirst = string.Copy(txtNm4.Text);
            string strSecond = string.Copy(txtNm5.Text);
            string strThird = string.Copy(txtNm6.Text);

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
            if (txtNm6.Text.Length > 0)
            {
                numThird = Convert.ToDouble(strFirst);

            }
            else
            {
                numThird = 0;
            }
                if (numFirst == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Выражение не имеет смысла!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numSecond == 0)
            {
                numRes = 0;
                lblRezultatlin.Text = numRes.ToString();
            }
            else
            {
                dis = (numSecond * numSecond) - (numFirst * numThird * 4);
                if (dis < 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Корней нет!", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label9.Text = numRes.ToString();
                }
                else if(dis == 0)
                {
                    numRes = -1 * numSecond / 2 * numFirst;
                    label9.Text = numRes.ToString();
                }
                else
                {
                    numRes = ((-1 * numSecond) + (Math.Sqrt(dis))) / (2 * numFirst);
                    numRes1 = ((-1 * numSecond) - (Math.Sqrt(dis))) / (2 * numFirst);
                    label9.Text = numRes.ToString();
                    label9.Text = numRes1.ToString();
                }
            }
        }
    }
}
