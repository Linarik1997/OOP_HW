using System;

namespace OOP_HW.RPG
{
    public abstract class Ability<T> where T:Hero
    {
        internal T _caster { get; set; }
        public Type _canUse { get; set; }
        public string _name { get; set; }
        public int _cost { get; set; }
        public double _cooldown { get; set; }
        public int _accessOnLevel { get; set; }

        static protected DateTime timeCasted { get; set; }

        public abstract void Cast(Hero otherHero);
        
        public bool CanCast()
        {
            return (IsAppropriateTypeOf() && IsNotOnCD() && IsEnoughMana());
        }
        protected bool IsAppropriateTypeOf()
        {
            var res = _caster.GetType() == _canUse;
            return res;
        }
        protected bool IsNotOnCD()
        {
            if (DateTime.Now >= timeCasted.AddSeconds(_cooldown))
            {              
                return true;
            }
            else
            {
                Console.WriteLine($"{this._name} is on CD " +
                   $"{(timeCasted.AddSeconds(_cooldown) - DateTime.Now).TotalSeconds} more seconds");
                return false;
            }
        }
        protected bool IsEnoughMana()
        {
            if ((_caster.MP - _cost) >= 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"{_caster.Name} doesnt have anough mana to cast {_name}");
                return false;
            }
        }
    }
}