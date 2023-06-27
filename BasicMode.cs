using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinCalcImitation
{
    public partial class Form1 : Form
    {
        private string ops = String.Empty;
        private float res = 0;
        private string ichigo, nigo;
        private bool enter = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_num_Click(object sender, EventArgs e)
        {
            if (textcurval.Text == "0" || enter) textcurval.Text = string.Empty;

            enter = false;
            Button button = sender as Button;
            if (button.Text == ",")
            {
                if (!textcurval.Text.Contains(",")) textcurval.Text = textcurval.Text + button.Text;
            }

            else textcurval.Text = textcurval.Text + button.Text;
        }
        private void btn_op_Click(object sender, EventArgs e)
        {
            if (res != 0) btn_res.PerformClick();
            else res = float.Parse(textcurval.Text);
            
            Button button = sender as Button;
            ops = button.Text;
            enter = true;
            if (textcurval.Text != "0")
            {
                textallops.Text = ichigo = $"{res} {ops}";
                textcurval.Text = string.Empty;
            }
        }
        private void btn_res_Click(object sender, EventArgs e)
        {
            nigo = textcurval.Text;
            textallops.Text = $"{textallops.Text} {textcurval.Text}=";
            if (textcurval.Text != string.Empty)
            {
                if (textcurval.Text == "0") textallops.Text = string.Empty;
                switch (ops)
                {
                    case "+":
                        textcurval.Text = (res + float.Parse(textcurval.Text)).ToString();
                        break;
                    case "-":
                        textcurval.Text = (res - float.Parse(textcurval.Text)).ToString();
                        break;
                    case "*":
                        textcurval.Text = (res * float.Parse(textcurval.Text)).ToString();
                        break;
                    case "/":
                        textcurval.Text = (res / float.Parse(textcurval.Text)).ToString();
                        break;
                    default:
                        textallops.Text = $"{textcurval.Text} = ";
                        break;
                }

                res = float.Parse(textcurval.Text);
                ops = string.Empty;
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "C")
            {
                textallops.Text = string.Empty;
                res = 0;
            }
            textcurval.Text = "0";
        }
        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (textcurval.Text.Length > 0)
                textcurval.Text = textcurval.Text.Remove(textcurval.Text.Length - 1, 1);
            if (textcurval.Text == string.Empty) textcurval.Text = "0";
        }
        private void btn_adop_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ops = button.Text;
            switch (ops)
            {
                case "√":
                    textallops.Text = $"sqrt({textcurval.Text})";
                    textcurval.Text = Convert.ToString(Math.Sqrt(float.Parse(textcurval.Text)));
                    break;
                case "±":
                    textallops.Text = $"±({textcurval.Text})";
                    textcurval.Text = Convert.ToString(-1 * float.Parse(textcurval.Text));
                    break;
                case "%":
                    textallops.Text = $"%({textcurval.Text})";
                    textcurval.Text = Convert.ToString(float.Parse(textcurval.Text) / 100);
                    break;
                case "1/x":
                    textallops.Text = $"1/({textcurval.Text})";
                    textcurval.Text = Convert.ToString(1 / float.Parse(textcurval.Text));
                    break;
            }
        }
    }
}