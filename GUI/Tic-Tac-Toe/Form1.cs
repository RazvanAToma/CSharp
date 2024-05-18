namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        public int turn = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void place(Button buttonName)
        {
            if (turn % 2 == 0)
            {
                buttonName.Text = "X";
                turn += 1;
            }
            else
            {
                buttonName.Text = "O";
                turn += 1;
            }
        }

        private void topLeft_Click(object sender, EventArgs e)
        {
            place(topLeft);
        }

        private void topMiddle_Click(object sender, EventArgs e)
        {
            place(topMiddle);
        }

        private void topRight_Click(object sender, EventArgs e)
        {
            place(topRight);
        }

        private void middleLeft_Click(object sender, EventArgs e)
        {
            place(middleLeft);
        }

        private void middleMiddle_Click(object sender, EventArgs e)
        {
            place(middleMiddle);
        }

        private void middleRight_Click(object sender, EventArgs e)
        {
            place(middleRight);
        }

        private void bottomLeft_Click(object sender, EventArgs e)
        {
            place(bottomLeft);
        }

        private void bottomMiddle_Click(object sender, EventArgs e)
        {
            place(bottomMiddle);
        }

        private void bottomRight_Click(object sender, EventArgs e)
        {
            place(bottomRight);
        }
    }
}
