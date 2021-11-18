using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.RPG.Heroes
{
    public class Rogue : Hero
    {
        protected double _physDamageAmplifier;
        protected List<Ability<Rogue>> _abilities;




        public double PhysDamageAmplifier
        {
            get { return _physDamageAmplifier; }
            set { _physDamageAmplifier = value; }
        }
        public double PhysDamage
        {
            get { return _stats.Stregth * _physDamageAmplifier; }
        }
        public List<Ability<Rogue>> Abilities
        {
            get { return _abilities; }
            set { _abilities = value; }
        }



        public override void Attack(Hero enemy)
        {
            var dmg = this.PhysDamage;
            enemy.HP -= dmg;
            Console.WriteLine($"{this.Name} deals {dmg} to {enemy.Name}");
        }

        public void Cast(Hero otherHero, Ability<Rogue> ability)
        {
            if (ability.CanCast())
            {
                ability.Cast(otherHero);
                Console.WriteLine($"{this.Name} casts {ability._name} to {otherHero.Name}");
            }
        }
    }
}
