using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVP
{
    public partial class MultiDimensional : Form
    {
        int height { get; set; }
        int width { get; set; }
        int moves { get; set; }

        public Color p1color;
        public Color p2color;

        //public int[,] array = new int[3, 3];
        public int[,] array { get; set; }
        List<Button> buttons { get; set; }
        int boardSize { get; set; }
        public string player1 = GameOptions.p1Name;
        public string player2 = GameOptions.p2Name;
        public int timePlayer1;
        public int timePlayer2;
        public int pointsToWin = GameOptions.ptsWin;
        public int ptsPlayer1;
        public int ptsPlayer2;
        public int winner;
        public int games;
        public int ties;
        public int winsPlayer1;
        public int winsPlayer2;

        public MultiDimensional(int n)
        {
            InitializeComponent();
            Initialize(n);

            


        }
        public void Initialize(int n)
        {
            this.height = this.Height;
            this.width = this.Width;
            this.boardSize = n;
            this.buttons = new List<Button>();
            this.array = new int[boardSize, boardSize];
            moves = 0;

            for (int i = 0; i < boardSize * boardSize; i++)
            {
                Button b = new Button();
                buttons.Add(b);
            }
            DrawButtons();

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    array[i, j] = -1;
                }
            }

            winner = 0;
            moves = 0;
            games = 1;
            ties = 0;
            timePlayer1 = 15;
            timePlayer2 = 15;
            winsPlayer1 = 0;
            winsPlayer2 = 0;
            ptsPlayer1 = 0;
            ptsPlayer2 = 0;
            whichTurn.Text = player1;
            firstPlayer.Text = player1;
            secondPlayer.Text = player2;

            statusLabel1.Text = "Points to win the game: " + pointsToWin.ToString();
            statusLabel2.Text = "Game number: 1";
            statusLabel3.Text = "Ties: 0";
            pointsP1.Text = "Points: " + ptsPlayer1;
            pointsP2.Text = "Points: " + ptsPlayer2;

            progressBar1.Value = 15;
            progressBar2.Value = 15;
            timerPlayer1.Start();
            p1color = GameOptions.c1;
            p2color = GameOptions.c2;
            label5.ForeColor = p1color;
            label6.ForeColor = p2color;
            firstPlayer.ForeColor = p1color;
            secondPlayer.ForeColor = p2color;
            pointsP1.ForeColor = p1color;
            pointsP2.ForeColor = p2color;
            whichTurn.ForeColor = p1color;

        }

        public void DrawButtons()
        {
            var rowCount = boardSize;
            var columnCount = boardSize;

            this.tableLayoutPanel1.ColumnCount = columnCount;
            this.tableLayoutPanel1.RowCount = rowCount;

            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < rowCount * columnCount; i++)
            {
                var b = new Button();
                //b.Text = (i + 1).ToString();
                //b.Name = string.Format("b_{0}", i + 1);
                b.Name = i.ToString();
                b.Click += b_Click;
                b.Dock = DockStyle.Fill;
                this.tableLayoutPanel1.Controls.Add(b);
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            var btn1 = sender as Button;
            //btn1.Enabled = false;
            /*if (b != null)
                MessageBox.Show(string.Format("{0} Clicked", b.Text));*/

            moves++;
            string name = btn1.Name;
            int number = int.Parse(name);
            int x = number / boardSize;
            int y = number % boardSize;
            if (moves % 2 != 0)
            {
                btn1.Text = "X";
                btn1.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);                
                btn1.ForeColor = p1color;
                array[x, y] = 1;
                timerPlayer1.Stop();
                timePlayer1 = 15;
                progressBar1.Value = 15;
                whichTurn.Text = player2;
                whichTurn.ForeColor = p2color;
                timerPlayer2.Start();



            }
            else
            {
                btn1.Text = "O";
                btn1.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
                btn1.ForeColor = p2color;
                array[x, y] = 0;
                timerPlayer2.Stop();
                timePlayer2 = 15;
                progressBar2.Value = 15;
                whichTurn.Text = player1;
                whichTurn.ForeColor = p1color;
                timerPlayer1.Start();

            }
            btn1.Click -= b_Click;
            checkWin();
            checkDraw();
            
        }

        public void checkWin()
        {
            for(int i = 1; i < boardSize - 1;i++)
            {
                for(int j = 1; j < boardSize - 1; j++)
                {
                    
                    int znak = array[i, j];
                    
                    if(znak != -1 && znak == array[i-1, j - 1] && znak == array[i+1, j + 1])
                    {
                        if (znak == 0)
                            winner = 2;
                        else
                            winner = 1;
                    }
                    if (znak != -1 && znak == array[i - 1, j + 1] && znak == array[i + 1, j - 1])
                    {
                        if (znak == 0)
                            winner = 2;
                        else
                            winner = 1;
                    }
                    if (znak != -1 && znak == array[i - 1, j] && znak == array[i + 1, j])
                    {
                        if (znak == 0)
                            winner = 2;
                        else
                            winner = 1;
                    }
                    if (znak != -1 && znak == array[i , j - 1] && znak == array[i, j + 1])
                    {
                        if (znak == 0)
                            winner = 2;
                        else
                            winner = 1;
                    }
                    
                    for(int k = 1; k < boardSize - 1; k++)
                    {
                        znak = array[0, k];
                        if(znak != -1 && (znak == array[0,k-1]) && znak == array[0,k+1])
                        {
                            if (znak == 0)
                                winner = 2;
                            else
                                winner = 1;
                        }
                    }
                    for (int k = 1; k < boardSize - 1; k++)
                    {
                        znak = array[boardSize-1, k];
                        if (znak != -1 && (znak == array[boardSize - 1, k - 1]) && znak == array[boardSize - 1, k + 1])
                        {
                            if (znak == 0)
                                winner = 2;
                            else
                                winner = 1;
                        }
                    }

                    for(int k = 1;k < boardSize - 1; k++)
                    {
                        znak = array[k, boardSize - 1];
                        if (znak != -1 && (znak == array[k-1, boardSize - 1]) && znak == array[k+1, boardSize - 1])
                        {
                            if (znak == 0)
                                winner = 2;
                            else
                                winner = 1;
                        }
                    }
                    for (int k = 1; k < boardSize - 1; k++)
                    {
                        znak = array[k, 0];
                        if (znak != -1 && (znak == array[k - 1, 0]) && znak == array[k + 1, 0])
                        {
                            if (znak == 0)
                                winner = 2;
                            else
                                winner = 1;
                        }
                    }
                }
            }
            if (winner != 0)
                MessageBox.Show("Winner of this round is player" + winner);
            if (winner == 1)
            {
                pointForPlayerOne();
            }
            else if(winner == 2)
            {
                pointForPlayerTwo();
            }
            
        }
        public void pointForPlayerOne()
        {
            timerPlayer1.Stop();
            timerPlayer2.Stop();
            ptsPlayer1++;

            if (ptsPlayer1 == pointsToWin)
            {
                string winnerName;
                if (winner == 1)
                    winnerName = player1;
                else
                    winnerName = player2;
                MessageBox.Show("The game was won by " + winnerName);
                Close();
            }

            pointsP1.Text = "Points: " + ptsPlayer1.ToString();
            pointsP2.Text = "Points: " + ptsPlayer2.ToString();


            ResetGame();
        }
        public void pointForPlayerTwo()
        {
            timerPlayer1.Stop();
            timerPlayer2.Stop();
            ptsPlayer2++;

            if (ptsPlayer2 == pointsToWin)
            {
                string winnerName;
                if (winner == 1)
                    winnerName = player1;
                else
                    winnerName = player2;
                MessageBox.Show("The game was won by " + winnerName);
                Close();
            }

            pointsP1.Text = "Points: " + ptsPlayer1.ToString();
            pointsP2.Text = "Points: " + ptsPlayer2.ToString();

            ResetGame();

        }

        
        public void ResetGame()
        {
            tableLayoutPanel1.Controls.Clear();
            moves = 0;
            winner = 0;
            DrawButtons();
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    array[i, j] = -1;
                }
            }
        }

        public void checkDraw()
        {
            if(moves == boardSize * boardSize && winner == 0)
            {
                MessageBox.Show("DRAW");
                timerPlayer1.Stop();
                timerPlayer2.Stop();
                ResetGame();
                
            }
            
        }
        public void checkTimer1()
        {
            if (timePlayer1 == 0)
            {
                timerPlayer1.Stop();
                MessageBox.Show("-1 point for " + player1);
                if (ptsPlayer1 > 0)
                    ptsPlayer1--;
                pointsP1.Text = "Points: " + ptsPlayer1.ToString();
                progressBar1.Value = 15;


            }
        }
        public void checkTimer2()
        {
            if (timePlayer2 == 0)
            {
                timerPlayer2.Stop();
                MessageBox.Show("-1 point for " + player2);
                if (ptsPlayer2 > 0)
                    ptsPlayer2--;
                pointsP2.Text = "Points: " + ptsPlayer2.ToString();
                progressBar2.Value = 15;


            }
        }

        private void MultiDimensional_Load(object sender, EventArgs e)
        {

        }

        private void timerPlayer1_Tick(object sender, EventArgs e)
        {
            timePlayer1--;
            if (progressBar1.Value > 0)
                progressBar1.Value--;
            checkTimer1();

        }

        private void timerPlayer2_Tick(object sender, EventArgs e)
        {
            timePlayer2--;
            if (progressBar2.Value > 0)
                progressBar2.Value--;
            checkTimer2();
        }
    }
}
