using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship2
{
    public partial class GenerateFleetForm : Form
    {
        public GenerateFleetForm()
        {
            InitializeComponent();
            GenerateFleetGrid();

        }
        private void GenerateFleetGrid()
        {
            var emptyTile = Resources.Resource1.EmptyTile;
            var shipTile = Resources.Resource1.ShipTile;
            for (int row = 0; row < FleetGrid.RowCount; row++)
            {
                textBox1.Text += "[";
                for (int col = 0; col < FleetGrid.ColumnCount; col++)
                {
                    var pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Dock = DockStyle.Fill;

                    if (Game.game.playerFleet.ships.FirstOrDefault(ship => ship.Contains(row, col)) != null)
                    {
                        pictureBox.Image = shipTile;

                        textBox1.Text += "S";
                    }
                    else
                    {
                        pictureBox.Image = emptyTile;

                        textBox1.Text += "~";
                    }


                    this.FleetGrid.Controls.Add(pictureBox, col, row);

                }
                textBox1.Text += "]\n";
            }
        }

        private void GenerateFleetButton_Click(object sender, EventArgs e)
        {
            FleetGrid.Controls.Clear();
            Game.game.ResetFleet();
            GenerateFleetGrid();
        }

        private void ConfirmFleetButton_Click(object sender, EventArgs e)
        {

        }


    }
}
