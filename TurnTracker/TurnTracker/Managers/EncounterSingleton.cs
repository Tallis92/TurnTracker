using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnTracker.Models;

namespace TurnTracker.Managers
{
    public class EncounterSingleton
    {
        public static readonly EncounterSingleton getEncounterList = new EncounterSingleton();

        internal Models.Encounter selectedEncounter = new Models.Encounter();
        internal Creature thisCreature = new Creature();
        public static EncounterSingleton GetEncounter()
        {
            return getEncounterList;
        }

        internal static void SetEncounter(Models.Encounter savedEncounter)
        {


        }

        internal Creature GetActiveCreature()
        {

            return thisCreature;
        }
    }
}
