using OOP_HW.RPG.Ablts;
using OOP_HW.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.RPG.Fabrique
{
    public class MageCreator: Creator<Mage>
    {
        const int _dexterityByDefault = 6;
        const int _intellegentByDefault = 12;
        const int _strengthByDefault = 6;
        const double _mDamageAmplifierByDefault = 2;

        public override Mage Create(string name)
        {
            Mage mage = new Mage();
            mage.Name = name;
            mage.Stats.SetStats(_strengthByDefault,
                _intellegentByDefault,
                _dexterityByDefault);
            mage.HP = _strengthByDefault * _hpMultiplyer;
            mage.MP = _intellegentByDefault * _mpMultiplyer;
            mage.MagicDamageAmplifier = _mDamageAmplifierByDefault;
            mage.Abilities = new List<Ability<Mage>>();
            mage.Abilities.Add(new Fireball(mage));
            Console.WriteLine($"New mage {mage.Name} has arrived");
            return mage;
        }
    }
}
