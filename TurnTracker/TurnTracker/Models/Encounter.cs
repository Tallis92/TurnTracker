using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnTracker.Models
{
    internal class Encounter
    {
        internal List<Creature>? EncounterCreatures { get; set; }
        internal List<PlayerCharacter>? EncounterPlayers { get; set; }
    }
}
