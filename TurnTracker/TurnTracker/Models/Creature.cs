using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnTracker.Models
{
    internal class Creature
    {
        public string Name { get; set; }
        public int Initiative { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
    }
}
