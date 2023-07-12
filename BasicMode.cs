using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinCalcImitation
{
    public partial class Form1 : Form
    {
        private string history = String.Empty;
        private string ops = String.Empty;
        private float res;
        private string ichigo, nigo;
        private bool enter;
        private float memory = float.NaN;
        private bool flag;
        private string adops = String.Empty;
        private bool aduse;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_num_Click(object sender, EventArgs e)
        {
            if (textcurval.Visible)
            {
                if (textcurval.Text == "0" || enter) textcurval.Text = string.Empty;

                enter = false;
                flag = true;
                Button button = sender as Button;
                if (button.Text == ",")
                {
                    if (!textcurval.Text.Contains(",")) textcurval.Text = textcurval.Text + button.Text;
                }

                else textcurval.Text = textcurval.Text + button.Text;

                ichigo = textcurval.Text;
            }
        }

        private void btn_op_Click(object sender, EventArgs e)
        {
            if (textcurval.Visible)
            {
                if (res != 0)
                {
                    flag = false;
                    btn_res.PerformClick();
                }
                else res = float.Parse(textcurval.Text);

                Button button = sender as Button;
                ops = button.Text;
                enter = true;
                if (textcurval.Text != "0")
                {
                    if (history == String.Empty) history = $"{res} {ops}";
                    else if (aduse)
                    {
                        aduse = false;
                        history += $" {ops}";
                    }
                    else history += $" {ichigo} {ops}";
                    textallops.Text = history;
                }
            }
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            if (textcurval.Visible)
            {
                nigo = textcurval.Text;
                //textallops.Text = $"{textallops.Text} {textcurval.Text}=";
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
                            if (nigo != "0") textcurval.Text = (res / float.Parse(textcurval.Text)).ToString();
                            else
                            {
                                textcurval.Visible = false; 
                                texterror.Visible = true;
                                
                            }
                            break;
                    }
                    
                    res = float.Parse(textcurval.Text);
                    if (flag)
                    {
                        textallops.Text = history = string.Empty;
                        flag = false;
                    }
                    
                    ops = string.Empty;
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "C")
            {
                textallops.Text = history = string.Empty;
                res = 0;
            }
            textcurval.Text = "0";
            textcurval.Visible = true;
            texterror.Visible = false;
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (textcurval.Visible)
            {
                if (textcurval.Text.Length > 0)
                    textcurval.Text = textcurval.Text.Remove(textcurval.Text.Length - 1, 1);
                if (textcurval.Text == string.Empty) textcurval.Text = "0";
            }
        }

        private void btn_adop_Click(object sender, EventArgs e)
        {
            if (textcurval.Visible)
            {
                nigo = textcurval.Text;
                Button button = sender as Button;
                adops = button.Text;
                string temp = string.Empty;
                switch (adops)
                {
                    case "√":
                        temp = $"sqrt({textcurval.Text})";
                        textcurval.Text = Convert.ToString(Math.Sqrt(float.Parse(textcurval.Text)));
                        break;
                    case "±":
                        temp = $"negate({textcurval.Text})";
                        textcurval.Text = Convert.ToString(-1 * float.Parse(textcurval.Text));
                        break;
                    case "%":
                        temp = $"%({textcurval.Text})";
                        textcurval.Text = Convert.ToString(float.Parse(textcurval.Text) / 100 * float.Parse(nigo));
                        break;
                    case "1/x":
                        temp = $"reciproc({textcurval.Text})";
                        if (nigo != "0")
                            textcurval.Text = Convert.ToString(1 / float.Parse(textcurval.Text));
                        else
                        {
                            textcurval.Visible = false;
                            texterror.Visible = true;
                        }

                        break;
                }
                if (history == String.Empty) history = temp;
                else history += $"{temp}";
                textallops.Text = history;
                aduse = true;
            }
        }

        private void btn_memory_Click(object sender, EventArgs e)
        {
            if (textcurval.Visible)
            {
                Button button = sender as Button;
                string crs = button.Text;
                switch (crs)
                {
                    case "MC":
                        memory = float.NaN;
                        textMem.Visible = false;
                        break;
                    case "MR":
                        if (!float.IsNaN(memory))
                        {
                            textcurval.Text = memory.ToString();
                            ichigo = textcurval.Text;
                        }
                        else textcurval.Text = ichigo = "0";

                        break;
                    case "MS":
                        if (textcurval.Text != "0")
                        {
                            memory = float.Parse(textcurval.Text);
                            textMem.Visible = true;
                        }

                        break;
                }
            }
        }

        private void btn_memop_Click(object sender, EventArgs e)
        {
            if (textcurval.Visible)
            {
                if (!float.IsNaN(memory))
                {
                    Button button = sender as Button;
                    string plumin = button.Text;
                    switch (plumin)
                    {
                        case "M+":
                            memory += float.Parse(textcurval.Text);
                            break;

                        case "M-":
                            memory -= float.Parse(textcurval.Text);
                            break;
                    }
                }
            }
        }
    }
}