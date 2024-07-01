using Battleship2.Forms;
using System.Reflection.Emit;

namespace Battleship2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TestForm());
        }
    }
    enum Players
    {
        Me,
        Computer
    }
    internal class Game
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
            playerGunner=new Gunnery(10,10,shipsLen);
            enemyBuilder=new FleetBuilder(10,10,shipsLen);
            enemyFleet = enemyBuilder.CreateFleet();
            enemyGunner = new Gunnery(10,10,shipsLen);
        }
        public void ResetFleet()
        {
            playerBuilder = new FleetBuilder(10, 10, shipsLen);
            playerFleet = playerBuilder.CreateFleet();
        }
        private Players SwitchPlayers(Players currentPlayer)
        {
            switch (currentPlayer)
            {
                case Players.Me:
                    return Players.Computer;
                case Players.Computer:
                    return Players.Me;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }
        public Square enemyTurn()
        {
            Square enemyShot= enemyGunner.target;
            HitResult enemyHit = Game.game.playerFleet.Hit(enemyShot.Row, enemyShot.Column);
            Game.game.enemyGunner.ProcessHitResult(enemyHit);
            enemyShot = enemyGunner.recordGrid.GetSquare(enemyShot.Row, enemyShot.Column);
            TestForm.textBox1.Text= enemyShot.State.ToString();
            enemyGunner.target=enemyGunner.Next();
            if(enemyGunner.shipLengths.Count==0) { }
            return enemyShot;
        }

    }
}