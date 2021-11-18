using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.RPG
{
    public abstract class Hero
    {
        /// <summary>
        /// Name of the hero
        /// </summary>
        protected string _name;
        /// <summary>
        /// Total hit points of the hero
        /// </summary>
        protected double _hp;
        /// <summary>
        /// Total mana points of the hero
        /// </summary>
        protected double _mp;
        /// <summary>
        /// Current level of the hero
        /// </summary>
        protected int _level;
        /// <summary>
        /// Storage of hero's items
        /// </summary>
        protected Inventory _inventory;
        /// <summary>
        /// state that determines if hero's alive
        /// </summary>
        protected bool _isAlive = true;
        /// <summary>
        /// Hero stats;
        /// </summary>
        protected Stats _stats;
        /// <summary>
        /// List of hero abilities
        /// </summary>





        public string Name
        {
            get { return _name; }
            internal set { _name = value; }
        }
        public int Level
        {
            get { return _level; }
            internal set { _level = value; }
        }
        public double HP
        {
            get { return _hp; }
            internal set
            {
                _hp = value;
                if (_hp <= 0)
                {
                    IsAlive = false;
                    Console.WriteLine($"{this.Name} died");
                }
            }
        }
        public double MP
        {
            get { return _mp; }
            internal set { _mp = value; }
        }
        public Inventory Inventory
        {
            get { return _inventory; }
            internal set { _inventory = value; }
        }
        public bool IsAlive
        {
            get { return _isAlive; }
            protected set { _isAlive = value; }
        }
        public Stats Stats
        {
            get { return _stats; }
            set { _stats = value; }
        }



        internal Hero()
        {
            Inventory = new Inventory();
            Inventory.Owner = this; 
            Stats = new Stats();
            Level = 1;
        }


        public override string ToString()
        {
            return $"{GetType()} {Name}. Level {Level}. HP {HP}";
        }
        public abstract void Attack(Hero enemy);
        public void RestortHealth(int restore)
        {
            HP += restore;
            Console.WriteLine($"Hero {this.Name} restored {restore} hp. Total hp: {this.HP}");
        }
        public void RestoreMP(int restore)
        {
            MP += restore;
            Console.WriteLine($"Hero {this.Name} restored {restore} mp. Total mp: {this.MP}");
        }
    }
}
