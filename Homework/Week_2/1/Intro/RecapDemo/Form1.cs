using System.Drawing.Text;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 0;
            int left = 0;
            Button[,] board = new Button[8, 8];

            for (int i = 0; i < board.GetUpperBound(0); i++)
            {
                for (int j = 0; j < board.GetUpperBound(1); j++)
                {
                    board[i, j] = new Button();
                    board[i, j].Height = 50;
                    board[i, j].Width = 50;

                    board[i, j].Top = top;
                    board[i, j].Left = left;
                    left += 50;
                    board[i, j].BackColor = ((i+j) %2 == 0 ? Color.White : Color.Black);

                    this.Controls.Add(board[i, j]);
                }
                left = 0;
                top += 50;
            }

        }
    }
}
