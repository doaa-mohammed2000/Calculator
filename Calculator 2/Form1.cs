using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2
{

    public partial class Calculator : Form
    {
        Double value = 0;
        String operation = "";
        bool isoperation= false;
        public Calculator()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0")||(isoperation))
                textBox_result.Clear();
            isoperation = false;
            Button button = (Button)sender;
            if(button.Text==",")
            {
                if(!textBox_result.Text.Contains(","))
                    textBox_result.Text += button.Text;
            }
            else
            textBox_result.Text += button.Text;
        }
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(textBox_result.Text);
            isoperation = true;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox_result.Text =value+"+"+ textBox_result.Text+"="+(value + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = value + "-" + textBox_result.Text + "=" + (value - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = value + "*" + textBox_result.Text + "=" + (value * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = value + "/" + textBox_result.Text + "=" + (value / Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            value = 0;
        }
    }
}
