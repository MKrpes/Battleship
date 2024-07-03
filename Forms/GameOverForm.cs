using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship.Forms
{
    public partial class GameOverForm : Form
    {
        public GameOverForm(int winCond)
        {
            InitializeComponent();
            if (winCond == 1)
            {
                label1.Text = "You have won against the machine! For now...";
            }
            else
            {
                label1.Text = "The machine has won! Humanity is doomed...";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
