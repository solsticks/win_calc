using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_calc
{
    public partial class Form1 : Form
    {
        double value = 0;
        double value2 = 0;
        string operation = "";
        bool operation_pressed = false;
        public Iwin_Calc Operate { get; set; }
        public Form1(Iwin_Calc operate)
        {
            InitializeComponent();
            Operate = operate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)// This method is resposible for all click events on the calculator.
        {    
            if(operation_pressed)
            {
                result.Text = "0";
                operation_pressed = false;
            }

            if (result.Text == "0" || (operation_pressed))// this condition resets the screen when the equal sign is clicked 
                result.Clear();

            operation_pressed = false;

            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                {
                    result.Text += b.Text;
                }
            }
            else
                result.Text += b.Text;
        }

        private void buttonC_Click(object sender, EventArgs e)// this method is responsible for the C button on the calculator
        {
            result.Clear();
            result.Text = "0";
            operation = "";
            value = value2 = 0;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0 && !operation_pressed)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
            }
            else
            {            
                operation = b.Text;
                value = double.Parse(result.Text);
                operation_pressed = true;
                // result.Text = "";
            }
        }

        private void operators_click(object sender, EventArgs e)
        {
            operation_pressed = true;
            value2 = double.Parse(result.Text);

            try
            {
                switch (operation)
                {
                    case "+":
                        result.Text = Operate.Add(value, value2).ToString();
                        // result.Text = (value + value2).ToString();
                        break;
                    case "-":
                        result.Text = Operate.Subtract(value, value2).ToString();
                        //result.Text = (value - value2).ToString();
                        break;
                    case "x":
                        result.Text = Operate.Times(value, value2).ToString();
                        //result.Text = (value * value2).ToString();
                        break;
                    case "/":
                        result.Text = Operate.Divide(value, value2).ToString();
                        //result.Text = (value / value2).ToString();
                        break;
                    default:
                        break;
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            value = double.Parse(result.Text);
            operation = "";
        }

        private void buttonCC_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(result.Text != "0")
            {
                result.Text = (Convert.ToDouble(result.Text) * -1).ToString();
            }

        }

        private void buttonBS_Click(object sender, EventArgs e)
        {
            if (result.TextLength > 1)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1, 1);
            }
            else
            {
                result.Text = "0";
            }
        }
    }
}
