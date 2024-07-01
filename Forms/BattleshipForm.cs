using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship2.Forms
{
    public partial class BattleshipForm : Form
    {
        public BattleshipForm()
        {
            InitializeComponent();
        }
        private void ConfirmFleetButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
