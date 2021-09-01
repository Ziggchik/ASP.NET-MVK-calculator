using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        float znach1, znach2;
        int count;

        protected void Button14_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 0;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 1;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 2;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 3;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 4;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 5;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 6;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 7;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 8;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 9;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            if (tb1.Text.IndexOf(',') == -1 && tb1.Text != "")
                tb1.Text = tb1.Text + ",";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            tb2.Text = tb1.Text;
            znach1 = float.Parse(tb1.Text);
            tb1.Text = "";
            count = 2;
            tb3.Text = count.ToString();
            label1.Text = znach1.ToString() + "-";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            tb2.Text = tb1.Text;
            znach1 = float.Parse(tb1.Text);
            tb1.Text = "";
            count = 3;
            tb3.Text = count.ToString();
            label1.Text = znach1.ToString() + "*";
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            tb2.Text = tb1.Text;
            znach1 = float.Parse(tb1.Text);
            tb1.Text = "";
            count = 4;
            tb3.Text = count.ToString();
            label1.Text = znach1.ToString() + "/";
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            tb2.Text = tb1.Text;
            znach1 = float.Parse(tb1.Text);
            tb1.Text = "";
            count = 1;
            tb3.Text = count.ToString();
            label1.Text = znach1.ToString() + "+";
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            if (tb3.Text == "1")
            {
                znach2 = float.Parse(tb2.Text) + float.Parse(tb1.Text);
                tb1.Text = znach2.ToString();
            }
            else if (tb3.Text == "2")
            {
                znach2 = float.Parse(tb2.Text) - float.Parse(tb1.Text);
                tb1.Text = znach2.ToString();
            }
            else if (tb3.Text == "3")
            {
                znach2 = float.Parse(tb2.Text) * float.Parse(tb1.Text);
                tb1.Text = znach2.ToString();
            }
            else if (tb3.Text == "4")
            {
                if (tb1.Text == "0")
                    tb1.Text = ("На 0 делить нельзя, очистите делитель и введите новое значение");
                else
                {
                    znach2 = float.Parse(tb2.Text) / float.Parse(tb1.Text);
                    tb1.Text = znach2.ToString();
                }
            }
            //switch (count)
            //{
            //    case 1:
            //        znach2 = float.Parse(tb2.Text) + float.Parse(tb1.Text);
            //        tb3.Text = znach2.ToString();
            //        znach2 = znach1 + float.Parse(tb1.Text);
            //        tb1.Text = znach2.ToString();
            //        break;
            //    case 2:
            //        znach2 = znach1 - float.Parse(tb1.Text);
            //        tb1.Text = znach2.ToString();
            //        break;
            //    case 3:
            //        znach2 = znach1 * float.Parse(tb1.Text);
            //        tb1.Text = znach2.ToString();
            //        break;
            //    case 4:
            //        znach2 = znach1 / float.Parse(tb1.Text);
            //        tb1.Text = znach2.ToString();
            //        break;
            //    default:
            //        break;
            //}
            label1.Text = "";
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            label1.Text = "";
        }
    }
}