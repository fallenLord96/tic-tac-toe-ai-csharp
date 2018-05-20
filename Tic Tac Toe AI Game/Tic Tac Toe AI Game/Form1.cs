using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_AI_Game
{
    public partial class Form1 : Form
    {
        bool turn = true; //true == X turn; false == Y turn;
        int turn_count = 0; // counting the turns
        static String player1, player2;
        static Boolean against_Computer;

        public Form1()
        {
            InitializeComponent();
        }

        public static void SetPlayersName(String n1, String n2, Boolean bot)
        {
            player1 = n1;
            player2 = n2;
            player1 = player1.Trim();
            player2 = player2.Trim();

            against_Computer = bot;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            resetButtons();
            resetWinCount();
            Form1_Load(sender, e);
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetWinCount();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do u want really to close this app?", "Exit?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Nikola Kolev (theFallenLord) v1", "About");
        }

        private void startNewGame()
        {
            turn = true;
            turn_count = 0;
            resetButtons();
        } // end startNewGame()

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();

            if((!turn) && (against_Computer))
            {
                computerMakeMove();
            } // end if
        } // end button_click

        private void computerMakeMove()
        {
            // priority 1: get tic tac toe
            // priority 2: block X tic tac toe
            // priority 3: go for corner space
            // priority 4: pick open space
            Button move = null;

            move = lookForWinOrBlock("O");
            if (move == null)
            {
                move = lookForWinOrBlock("X");
                if (move == null)
                {
                    move = lookForCorner();
                    if (move == null)
                    {
                        move = lookForOpenSpace();
                    }
                }
            }

            move.PerformClick();
        }

        private Button lookForWinOrBlock(string mark)
        {
            // horizontal check
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;

            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;

            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            // vertical check
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;

            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;

            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            // diagonal check
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;
            if ((C1.Text == mark) && (A1.Text == mark) && (B2.Text == ""))
                return B2;

            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((B2.Text == mark) && (A3.Text == mark) && (C1.Text == ""))
                return C1;
            
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((B2.Text == mark) && (A1.Text == mark) && (C3.Text == ""))
                return C3;

            return null;
        }

        private Button lookForCorner()
        {
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
                if (C3.Text == "")
                    return C3;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C1.Text == "")
                    return C1;
                if (C3.Text == "")
                    return C3;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }

        private Button lookForOpenSpace()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    b = c as Button;
                    if (b != null)
                    {
                        if (b.Text == "")
                            return b;
                    } // end if
                } // end if
            } // end if

            return null;
        }

        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            // vertical check
            if (A1.Text == A2.Text && A2.Text == A3.Text && (!A1.Enabled))
                there_is_a_winner = true;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && (!B1.Enabled))
                there_is_a_winner = true;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && (!C1.Enabled))
                there_is_a_winner = true;

            // horizontal check
            if (A1.Text == B1.Text && B1.Text == C1.Text && (!A1.Enabled))
                there_is_a_winner = true;
            else if (A2.Text == B2.Text && B2.Text == C2.Text && (!A2.Enabled))
                there_is_a_winner = true;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && (!A3.Enabled))
                there_is_a_winner = true;

            // diagonal check
            if (A1.Text == B2.Text && B2.Text == C3.Text && (!A1.Enabled))
                there_is_a_winner = true;
            else if (C1.Text == B2.Text && B2.Text == A3.Text && (!C1.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disableButtons();
                String winner = "";
                if (turn)
                {
                    winner = player2;
                    oWinCountNum.Text = (Int32.Parse(oWinCountNum.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    xWinCountNum.Text = (Int32.Parse(xWinCountNum.Text) + 1).ToString();
                } // end if

                MessageBox.Show($"{winner} Wins!", "Yay!!!");
                startNewGame();
            }
            else
            {
                if (turn_count == 9)
                {
                    drawCountNum.Text = (Int32.Parse(drawCountNum.Text) + 1).ToString();
                    MessageBox.Show("There is no winner this time.", "Draw");
                    startNewGame();
                } // end if                
            } // end if

        } // end checkForWinner()

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button)
                    c.Enabled = false;
            } // end foreach
        } // end disableButtons()

        private void resetButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                    c.Text = "";
                } // end if
            } // end foreach
        } // end resetButtons()

        private void resetWinCount()
        {
            xWinCountNum.Text = "0";
            drawCountNum.Text = "0";
            oWinCountNum.Text = "0";
        } // end resetWinCount()

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                } // end if
            } // end if
        } // end button_enter

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
                b.Text = "";
        } // end button_leave

        private void Form1_Load(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();

            if (!(against_Computer))
            {
                if (player1.Length < 1 || player2.Length < 1)
                {
                    do
                    {
                        f2.ShowDialog();
                    }
                    while (player1.Length < 1 || player2.Length < 1); // end do-while
                } // end if
            } // end if
                
           
            xWinCountLabel.Text = player1;
            oWinCountLabel.Text = player2;
        }
    }
}
