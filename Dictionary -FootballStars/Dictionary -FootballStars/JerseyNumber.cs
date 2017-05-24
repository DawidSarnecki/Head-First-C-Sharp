using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary__FootballStars
{
    class JerseyNumber
    {
        public string Player { get; private set; }
        public int YearRetired { get; private set; }

        public JerseyNumber(string player, int yearRetired)
        {
            this.Player = player;
            this.YearRetired = yearRetired;
        }
    }
}
