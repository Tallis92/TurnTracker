using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnTracker.Models;

namespace TurnTracker.Managers
{
    public class SingletonManager
    {
        public static readonly SingletonManager getSingleton = new SingletonManager();

        private Creature creature = new Creature();

        public static SingletonManager GetSingleton()
        {
            return getSingleton;
        }

        internal void SetCreature(Creature sentCreature)
        {
            creature = sentCreature;
        }

        internal Creature GetCreature()
        {
            return creature;
        }
    }
}
