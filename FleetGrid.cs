using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Battleship2
{
    public class FleetGrid : Grid
    {
        public FleetGrid(int rows, int columns) : base(rows, columns)
        {

        }

        public override IEnumerable<Square> Squares
        {
            get
            {
                return squares.Cast<Square>().Where(s => s != null);
            }
        }

        public void EliminateSquare(int row, int column)
        {
            squares[row, column] = null;
        }

        public override bool IsSquareAvailable(int row, int col)
        {
            return squares[row, col] != null;
        }
    }
}