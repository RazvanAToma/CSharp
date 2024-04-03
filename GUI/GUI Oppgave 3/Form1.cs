namespace GUI_Oppgave_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fetch userNum:
            int userNum = int.Parse(userNumTextBox.Text);

            // Check value:
            if (userNum == 0)
            {
                checkTextBox.Text = "Tallet er 0";
            }
            else if (userNum < 0)
            {
                checkTextBox.Text = "Tallet er mindre enn 0";
            }
            else
            {
                checkTextBox.Text = "Tallet er større enn 0";
            }
        }
    }
}
