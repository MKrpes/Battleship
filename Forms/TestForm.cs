using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Battleship2.Forms
{
    public partial class TestForm : Form
    {
        internal static GameTiles2[,] enemyGameTiles =new GameTiles2[10,10];
        internal static GameTiles[,] playerGameTiles =new GameTiles[10, 10];
        public TestForm()
        {
            InitializeComponent();
            GenFG();
            GenEFG();
        }

        public void GenFG()
        {
            for (int row = 0; row < FleetGrid.RowCount; row++)
            {
                for (int col = 0; col < FleetGrid.ColumnCount; col++)
                {
                    var gameTile = new GameTiles(row, col, Game.game.enemyGunner.recordGrid.GetSquare(row, col),1)
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Fill
                    };

                    if (Game.game.playerFleet.ships.FirstOrDefault(ship => ship.Contains(row, col)) != null)
                    {
                        gameTile.Image = gameTile.shipTile;

                    }
                    else
                    {
                        gameTile.Image = gameTile.emptyTile;

                    }
                    playerGameTiles[row, col] = gameTile;
                    this.FleetGrid.Controls.Add(gameTile, col, row);
                }
            }
        }

        public void GenEFG()
        {
            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {

                    var gameTile = new GameTiles2(row, col, Game.game.playerGunner.recordGrid.GetSquare(row, col))
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Fill
                        
                    };

                    switch (Game.game.playerGunner.recordGrid.GetSquare(row, col).State)
                    {
                        case SquareState.Intact:
                            gameTile.Image = gameTile.emptyTile;
                            break;

                        case SquareState.Miss:
                            gameTile.Image = gameTile.missTile;
                            break;
                        case SquareState.Hit:
                            gameTile.Image = gameTile.shipHitTile;
                            break;

                        case SquareState.Sunk:
                            gameTile.Image = gameTile.shipSunkTile;
                            break;
                    }
                    enemyGameTiles[row,col] = gameTile;
                    tableLayoutPanel1.Controls.Add(gameTile, col, row);
                }
            }
        }
    }

    public class GameTiles : PictureBox
    {
        public Image emptyTile = Resources.Resource1.EmptyTile;
        public Image missTile = Resources.Resource1.MissTile;
        public Image shipHitTile = Resources.Resource1.ShipHitTile;
        public Image shipSunkTile = Resources.Resource1.ShipSunkTile;
        public Image shipTile = Resources.Resource1.ShipTile;

        public readonly int row;
        public readonly int col;
        public Square square;

        private int clicked;

        public GameTiles(int row, int col, Square square, int clicked=0)
        {
            this.row = row;
            this.col = col;
            this.square = square;
            this.clicked = clicked;
        }
        

        protected override void OnClick(EventArgs e)
        {
            if (clicked == 0)
            {
                
                base.OnClick(e);
                clicked = 1;
                Game.game.playerGunner.target = square;
                HitResult hr =Game.game.enemyFleet.Hit(row, col);
                //Game.game.playerGunner.shipSquares.Contains(square);
                Game.game.playerGunner.ProcessHitResult(hr);
                switch (hr)
                {
                    case (HitResult.Missed):
                        {
                            this.Image= missTile; 

                            enemyHit();

                            break;
                        }
                    case (HitResult.Sunken):
                        {
                            this.Image = shipSunkTile;
                            foreach (Ship ship in Game.game.enemyFleet.ships)
                            {
                                if (ship.Contains(row, col))
                                {
                                    foreach (Square sq in ship.Squares)
                                    {
                                        TestForm.enemyGameTiles[sq.Row, sq.Column].Image = shipSunkTile;
                                    }
                                }
                            }
                            break;
                        }
                    case (HitResult.Hit):
                        {
                            this.Image = shipHitTile;
                            break;
                        }

                }

            }
            else { }

        }

        protected void enemyHit()
        {

            Square enemyShot;
            do
            {
                enemyShot = Game.game.enemyTurn();
                TestForm.textBox1.Text += enemyShot.Row.ToString() + ", " + enemyShot.Column.ToString() + ": target";
                switch (enemyShot.State) {
                    
                    case SquareState.Miss:
                        {
                            TestForm.textBox1.Text += enemyShot.Row.ToString() + ", " + enemyShot.Column.ToString() + ": miss";

                            TestForm.playerGameTiles[enemyShot.Row, enemyShot.Column].Image = missTile;
                            break;
                        }
                    case SquareState.Sunk:
                        foreach (Ship ship in Game.game.playerFleet.ships)
                        {
                            if (ship.Contains(row, col))
                            {
                                foreach (Square sq in ship.Squares)
                                {
                                    TestForm.playerGameTiles[sq.Row, sq.Column].Image = shipSunkTile;
                                }
                            }
                        }
                        break;
                    case SquareState.Hit:
                        TestForm.textBox1.Text += enemyShot.Row.ToString() + ", " + enemyShot.Column.ToString() + ": hit";

                        TestForm.playerGameTiles[enemyShot.Row, enemyShot.Column].Image = shipHitTile;
                        break;
                    default:
                        break;
                } 

            } while (enemyShot.State != SquareState.Miss && enemyShot.State!=SquareState.Intact);

        }
    }
    public class GameTiles2 : PictureBox
    {
        public Image emptyTile = Resources.Resource1.EmptyTile;
        public Image missTile = Resources.Resource1.MissTile;
        public Image shipHitTile = Resources.Resource1.ShipHitTile;
        public Image shipSunkTile = Resources.Resource1.ShipSunkTile;
        public Image shipTile = Resources.Resource1.ShipTile;

        public readonly int row;
        public readonly int col;
        public Square square;

        public GameTiles2(int row, int col, Square square)
        {
            this.row = row;
            this.col = col;
            this.square = square;
        }

        protected void enemyHit()
        {

            Square enemyShot;
            do
            {
                enemyShot = Game.game.enemyTurn();
                TestForm.textBox1.Text += enemyShot.Row.ToString() + ", " + enemyShot.Column.ToString() + ": target";
                switch (enemyShot.State)
                {

                    case SquareState.Miss:
                        {
                            TestForm.textBox1.Text += enemyShot.Row.ToString() + ", " + enemyShot.Column.ToString() + ": miss";

                            TestForm.playerGameTiles[enemyShot.Row, enemyShot.Column].Image = missTile;
                            break;
                        }
                    case SquareState.Sunk:
                        foreach (Ship ship in Game.game.playerFleet.ships)
                        {
                            if (ship.Contains(row, col))
                            {
                                foreach (Square sq in ship.Squares)
                                {
                                    TestForm.playerGameTiles[sq.Row, sq.Column].Image = shipSunkTile;
                                }
                            }
                        }
                        break;
                    case SquareState.Hit:
                        TestForm.textBox1.Text += enemyShot.Row.ToString() + ", " + enemyShot.Column.ToString() + ": hit";

                        TestForm.playerGameTiles[enemyShot.Row, enemyShot.Column].Image = shipHitTile;
                        break;
                    default:
                        break;
                }

            } while (enemyShot.State != SquareState.Miss && enemyShot.State != SquareState.Intact);

        }
    }
}
