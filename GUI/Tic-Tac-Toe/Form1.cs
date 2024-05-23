namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        public int turn = 0;
        public bool win = false;
        private Button[,] board;

        public int rows = 3;
        public int cols = 3;


        public Form1()
        {
            InitializeComponent();
        }

        void place(Button buttonName)
        {
            if (turn != 8 && !win)
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

            checkForWin();
        }


        private void create2DArray()
        {
            board = new Button[,] 
            {
                {topLeft, topMiddle, topRight},
                {middleLeft, middleMiddle, middleRight},
                {bottomLeft, bottomMiddle, bottomRight},
            };
        }
        

        void checkForWin()
        {
            for (int i  = 0; i < rows; i += 1)
            {
                if (CheckButton(board[i, 0], board[i, 1], board[i, 2]) ||
                    CheckButton(board[0, i], board[1, i], board[2, i]))
                {
                    win = true;
                    return;
                }
            }
        }

        bool CheckButton(Button left, Button middle, Button right)
        {
            if (left.Text == middle.Text && left.Text == right.Text)
            {
                left.ForeColor = middle.ForeColor = right.ForeColor = Color.Red;
                return true;
            }

            return false;
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
