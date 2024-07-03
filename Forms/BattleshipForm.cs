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

namespace Battleship.Forms
{
    public partial class BattleshipForm : Form
    {
        internal static PlayerShotTiles[,] enemyGameTiles = new PlayerShotTiles[10, 10];
        internal static PlayerFleetTiles[,] playerGameTiles = new PlayerFleetTiles[10, 10];

        public BattleshipForm()
        {
            InitializeComponent();
            GenPFG();
            GenEFG();
        }

        private void GenPFG()
        {
            for (int row = 0; row < PlayerFleetGrid.RowCount; row++)
            {
                for (int col = 0; col < PlayerFleetGrid.ColumnCount; col++)
                {
                    var gameTile = new PlayerFleetTiles(row, col, Game.game.enemyGunner.recordGrid.GetSquare(row, col))
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
                    this.PlayerFleetGrid.Controls.Add(gameTile, col, row);
                }
            }
        }

        private void GenEFG()
        {
            for (int row = 0; row < EnemyFleetGrid.RowCount; row++)
            {
                for (int col = 0; col < EnemyFleetGrid.ColumnCount; col++)
                {

                    var gameTile = new PlayerShotTiles(row, col, Game.game.playerGunner.recordGrid.GetSquare(row, col))
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Fill,
                    };
                    gameTile.Image = gameTile.emptyTile;
                    enemyGameTiles[row, col] = gameTile;
                    EnemyFleetGrid.Controls.Add(gameTile, col, row);
                }
            }
        }

        private void ResetFleetButton_Click(object sender, EventArgs e)
        {
            PlayerFleetGrid.Controls.Clear();
            Game.game.ResetFleet();
            GenPFG();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Controls.Add(PlayerFleetGrid);
            panel1.Show();
        }
    }

    public class PlayerShotTiles : GameTiles
    {
        internal int clicked = 0;
        public PlayerShotTiles(int row, int col, Square square) : base(row, col, square)
        {
        }

        protected override void OnClick(EventArgs e)
        {
            if (clicked == 0)
            {
                base.OnClick(e);
                clicked = 1;
                Game.game.playerGunner.target = square;
                HitResult hr =Game.game.enemyFleet.Hit(row, col);
                Game.game.playerGunner.ProcessHitResult(hr);
                BattleshipForm.textBox1.Text = $"You shot at coordinates: {row},{col} : \n";
                switch (hr)
                {
                    case (HitResult.Missed):
                        {
                            this.Image= missTile;
                            BattleshipForm.textBox1.Text += "Miss\n";
                            break;
                        }
                    case (HitResult.Sunken):
                        {
                            this.Image = shipSunkTile;
                            BattleshipForm.textBox1.Text += "Enemy ship sunk\n";
                            foreach (Ship ship in Game.game.enemyFleet.ships)
                            {
                                if (ship.Contains(row, col))
                                {
                                    foreach (Square sq in ship.Squares)
                                    {
                                        BattleshipForm.enemyGameTiles[sq.Row, sq.Column].Image = shipSunkTile;
                                    }
                                }
                            }
                            if (Game.game.playerGunner.shipLengths.Count == 0) { 
                                foreach(PlayerShotTiles playerShot in BattleshipForm.enemyGameTiles)
                                {
                                    clicked = 1;
                                }                               
                                new GameOverForm(1).Show(); 
                            }
                            break;
                        }
                    case (HitResult.Hit):
                        {
                            this.Image = shipHitTile;
                            BattleshipForm.textBox1.Text += "Enemy ship damaged\n";
                            break;
                        }
                }
                Square TargetSquare = Game.game.enemyTurn();
                BattleshipForm.playerGameTiles[TargetSquare.Row, TargetSquare.Column].enemyHit();
            }           
        }
    }
    public class PlayerFleetTiles : GameTiles
    {
        public PlayerFleetTiles(int row, int col, Square square) : base(row,col,square)
        {      
        }

        public void enemyHit()
        {
             Square enemyShot=square;
             BattleshipForm.textBox1.Text += $"! Enemy targeted {row},{col} - ";
             switch (enemyShot.State)
             {
                case SquareState.Miss:
                    {
                        BattleshipForm.textBox1.Text += " No damage was done";
                        BattleshipForm.playerGameTiles[enemyShot.Row, enemyShot.Column].Image = missTile;
                        break;
                    }

                case SquareState.Sunk:
                    BattleshipForm.textBox1.Text += " Our ship has sunk";
                    foreach (Ship ship in Game.game.playerFleet.ships)
                    {
                        if (ship.Contains(row, col))
                        {
                            foreach (Square sq in ship.Squares)
                            {
                                BattleshipForm.playerGameTiles[sq.Row, sq.Column].Image = shipSunkTile;
                            }
                        }
                    }
                    if (Game.game.enemyGunner.shipLengths.Count == 0) {
                        foreach (PlayerShotTiles playerShot in BattleshipForm.enemyGameTiles)
                        {
                            playerShot.clicked = 1;
                        }
                        RevealShips();
                        new GameOverForm(-1).Show(); }
                    break;

                case SquareState.Hit:
                    BattleshipForm.textBox1.Text +=" Our ship was hit";
                    BattleshipForm.playerGameTiles[enemyShot.Row, enemyShot.Column].Image = shipHitTile;
                    break;

                default:
                    break;
             }
        }
        private void RevealShips()
        {
            foreach(Ship ships in Game.game.enemyFleet.ships) {
                foreach(Square sq in ships.Squares) {
                    if (sq.State==SquareState.Intact)
                    {
                        BattleshipForm.enemyGameTiles[sq.Row,sq.Column].Image = shipTile;
                    }
                }
            }
        }
    }

    public class Game
    {
        public FleetBuilder playerBuilder;
        public FleetBuilder enemyBuilder;
        int[] shipsLen = [5, 4, 4, 3, 3, 3, 2, 2, 2, 2];
        public Fleet playerFleet;
        public Fleet enemyFleet;
        public Gunnery enemyGunner;
        public Gunnery playerGunner;
        public static Game game = new Game();
        private Game()
        {
            playerBuilder = new FleetBuilder(10, 10, shipsLen);
            playerFleet = playerBuilder.CreateFleet();
            playerGunner = new Gunnery(10, 10, shipsLen);
            enemyBuilder = new FleetBuilder(10, 10, shipsLen);
            enemyFleet = enemyBuilder.CreateFleet();
            enemyGunner = new Gunnery(10, 10, shipsLen);
        }
        public void ResetFleet()
        {
            playerBuilder = new FleetBuilder(10, 10, shipsLen);
            playerFleet = playerBuilder.CreateFleet();
        }
        public Square enemyTurn()
        {
            Square enemyShot = enemyGunner.target;
            HitResult enemyHit = Game.game.playerFleet.Hit(enemyShot.Row, enemyShot.Column);
            Game.game.enemyGunner.ProcessHitResult(enemyHit);
            enemyShot = enemyGunner.recordGrid.GetSquare(enemyShot.Row, enemyShot.Column);
            if (enemyGunner.shipLengths.Count != 0) { enemyGunner.target = enemyGunner.Next(); }
            return enemyShot;
        }  

    }
}