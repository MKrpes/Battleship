﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class RandomTargetSelector : ITargetSelector
    {
        private readonly ShotsGrid grid;
        private readonly int shipLength;
        private readonly Random random = new Random();
        public RandomTargetSelector(ShotsGrid grid, int shipLength)
        {
            this.grid = grid;
            this.shipLength = shipLength;
        }
        public Square Next()
        {
            var placements = grid.GetAvailablePlacements(shipLength);
            var candidates = placements.SelectMany(s => s);
            var selectedIndex = random.Next(candidates.Count());
            return candidates.ElementAt(selectedIndex);
        }
    }
}
