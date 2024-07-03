using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public abstract class GameTiles : PictureBox
    {
        public Image emptyTile = Resources.Resource1.EmptyTile;
        public Image missTile = Resources.Resource1.MissTile;
        public Image shipHitTile = Resources.Resource1.ShipHitTile;
        public Image shipSunkTile = Resources.Resource1.ShipSunkTile;
        public Image shipTile = Resources.Resource1.ShipTile;

        public readonly int row;
        public readonly int col;
        public Square square;
        public GameTiles(int row, int col, Square square)
        {
            this.row = row;
            this.col = col;
            this.square = square;
        }
    }
}
