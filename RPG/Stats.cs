using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.RPG
{
    public class Stats
    {
        /// <summary>
        /// stat that determines hero's physical damage, capacity of the inventory and hp
        /// </summary>
        private int _strength;
        /// <summary>
        /// stat that determines hero's magical damage, mp
        /// </summary>
        private int _intellegent;
        /// <summary>
        /// stat that determines hero;s attack speed, physical damage and evasion
        /// </summary>
        private int _dexterity;



        public int Stregth
        {
            get { return _strength; }
            internal set { _strength = value; }
        }
        public int Intellect
        {
            get { return _intellegent; }
            internal set { _intellegent = value; }
        }
        public int Dexterity
        {
            get { return _dexterity; }
            internal set { _dexterity = value; }
        }
        public Stats() { }



        internal void SetStats(int s, int i, int d)
        {
            Stregth = s;
            Dexterity = d;
            Intellect = i;
        }

    }
}
