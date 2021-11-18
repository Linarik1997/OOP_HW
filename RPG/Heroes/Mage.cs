using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.RPG.Heroes
{
    public class Mage : Hero
    {
        protected double _magicDamageAmplify;
        protected List<Ability<Mage>> _abilities;





        public double MagicDamageAmplifier
        {
            get { return _magicDamageAmplify; }
            set { _magicDamageAmplify = value; }
        }
        public double MagDamage
        {
            get { return _stats.Intellect * _magicDamageAmplify; }
        }
        public double PhysDamage
        {
            get { return _stats.Dexterity * 1.2; }
        }
        public List<Ability<Mage>> Abilities
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

        public void Cast(Hero otherHero, Ability<Mage> ability)
        {
            if (ability.CanCast())
            {
                ability.Cast(otherHero);
                Console.WriteLine($"{this.Name} casts {ability._name} to {otherHero.Name}");
            }
        }
    }
}
