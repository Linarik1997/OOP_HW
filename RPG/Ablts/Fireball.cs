using OOP_HW.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.RPG.Ablts
{
    public class Fireball : Ability<Mage>
    {
        protected double _damage = 4;

        public Fireball(Mage caster)
        {
            _canUse = typeof(Mage);
            _name = $"Fireball";
            _cooldown = 8;
            _accessOnLevel = 1;
            _cost = 20;
            _caster = caster;
        }
        public override void Cast(Hero otherHero)
        {
            otherHero.HP -= _damage +_caster.MagDamage;
            timeCasted = DateTime.Now;
        }
    }
}
