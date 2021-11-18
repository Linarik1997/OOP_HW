using OOP_HW.RPG.Fabrique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.RPG.Heroes
{
    public class WarriorCreator : Creator<Warrior>
    {
        const int _dexterityByDefault = 8;
        const int _intellegentByDefault = 4;
        const int _strengthByDefault = 14;
        const double _pDamageAmplifierByDefault = 1.2;
        public override Warrior Create(string name)
        {
            Warrior war = new Warrior();
            war.Name = name;
            war.Stats.SetStats(_strengthByDefault,
                _intellegentByDefault,
                _dexterityByDefault);
            war.HP = _strengthByDefault * _hpMultiplyer;
            war.MP = _intellegentByDefault * _mpMultiplyer;
            war.PhysDamageAmplifier = _pDamageAmplifierByDefault;
            Console.WriteLine($"New war {war.Name} has arrived");
            return war;
        }
    }
}
