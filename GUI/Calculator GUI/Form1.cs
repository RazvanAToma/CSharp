using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator_GUI
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        char sign = 'e';

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            display.Text += 0;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            display.Text += 1;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            display.Text += 2;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            display.Text += 3;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            display.Text += 4;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            display.Text += 5;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            display.Text += 6;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            display.Text += 7;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            display.Text += 8;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            display.Text += 9;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            display.Text += ".";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            sign = '+';
            display.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            sign = '-';
            display.Text = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            sign = '*';
            display.Text = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(display.Text);
            sign = '/';
            display.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(display.Text);

            double ans = 0;
            switch (sign)
            {
                case '+':
                    ans = num1 + num2;
                    display.Text = ans.ToString();
                    break;
                case '-':
                    ans = num1 - num2;
                    display.Text = ans.ToString();
                    break;
                case '*':
                    ans = num1 * num2;
                    display.Text = ans.ToString();
                    break;
                case '/':
                    ans = num1 / num2;
                    display.Text = ans.ToString();
                    break;
            }
        }
    }
}
