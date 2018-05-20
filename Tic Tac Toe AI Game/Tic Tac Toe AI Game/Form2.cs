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
    public partial class Form2 : Form
    {
        static Boolean against_Computer;
        public Form2()
        {
            InitializeComponent();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (checkBoxAgainstThePC.Checked)
                against_Computer = true;

            Form1.SetPlayersName(playerOneTextBox.Text, playerTwoTextBox.Text, against_Computer);
            this.Close();
        }

        private void checkBoxAgainstThePC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAgainstThePC.Checked)
            {
                playerTwoTextBox.Enabled = false;
                playerTwoTextBox.Text = "COMPUTER";
            }
            else
            {
                playerTwoTextBox.Enabled = true;
                playerTwoTextBox.Text = "";
            } // end if
        }
    }
}
