using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public enum ShootingTactics
    {
        Random,
        Surronding,
        Inline
    }
    public class Gunnery
    {
        public readonly ShotsGrid recordGrid;
        public ShootingTactics shootingTactics { get; private set; } = ShootingTactics.Random;
        private ITargetSelector targetSelector;
        public List<int> shipLengths;
        public Square target;
        private readonly SquareEliminator eliminator = new SquareEliminator();
        public List<Square> shipSquares = new List<Square>();

        public void ProcessHitResult(HitResult hitResult)
        {
            ChangeTargetState(hitResult);
            switch (hitResult)
            {
                case HitResult.Missed:
                    return;
                case HitResult.Sunken:
                    {
                        shootingTactics = ShootingTactics.Random;
                        if(shipLengths.Count!=0)changeTargetSelector();
                        return;
                    }
                case HitResult.Hit:
                    {
                        shipSquares.Add(target);
                        shootingTactics = shootingTactics == ShootingTactics.Random ?
                            shootingTactics = ShootingTactics.Surronding : shootingTactics = ShootingTactics.Inline;

                        if (shipLengths.Count != 0) changeTargetSelector();
                        return;
                    }
                default:
                    Debug.Assert(false);
                    return;
            }
        }

        private void ChangeTargetState(HitResult hitResult)
        {
            switch (hitResult)
            {
                case HitResult.Missed: target.changeState(SquareState.Miss); return;
                case HitResult.Hit: target.changeState(SquareState.Hit); return;
                case HitResult.Sunken: MarkShipSunk(); return;

            }
        }

        private void MarkShipSunk()
        {
            int shipLength= 0;
            shipSquares.Add(target);
            foreach (var square in shipSquares)
            {
                square.changeState(SquareState.Sunk);
                shipLength++;
            }
            var toEliminate = eliminator.ToEliminate(shipSquares, recordGrid.Rows, recordGrid.Columns);
            foreach (var square in toEliminate)
            {
                recordGrid.GetSquare(square.row, square.col).changeState(SquareState.Sunk);
            }
            shipLengths.Remove(shipLength);
            shipSquares.Clear();
        }

        public Gunnery(int rows, int columns, IEnumerable<int> shipLengths)
        {
            recordGrid = new ShotsGrid(rows, columns);
            this.shipLengths = new List<int>(shipLengths.OrderDescending());
            targetSelector = new RandomTargetSelector(recordGrid, this.shipLengths[0]);
            target = targetSelector.Next();
        }
        public Square Next()
        {
            return targetSelector.Next();
        }
        public void changeTargetSelector()
        {
            switch (shootingTactics)
            {
                case ShootingTactics.Random: targetSelector = new RandomTargetSelector(recordGrid, shipLengths[0]); break;
                case ShootingTactics.Surronding: targetSelector = new SurrondingTargetSelector(recordGrid, target, shipLengths[0]); break;
                case ShootingTactics.Inline: targetSelector = new InlineTargetSelector(recordGrid, shipSquares, shipLengths[0]); break;
                default:
                    Debug.Assert(false);
                    return;
            }
        }
    }
}
