using OOP_HW.RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.RPG.Fabrique
{
    public class RogueCreator: Creator<Rogue>
    {
        const int _dexterityByDefault = 15;
        const int _intellegentByDefault = 6;
        const int _strengthByDefault = 6;
        const double _pDamageAmplifierByDefault = 1.7;

        public override Rogue Create(string name)
        {
            Rogue rogue = new Rogue();
            rogue.Name = name;
            rogue.Stats.SetStats(_strengthByDefault,
                _intellegentByDefault,
                _dexterityByDefault);
            rogue.HP = _strengthByDefault * _hpMultiplyer;
            rogue.MP = _intellegentByDefault * _mpMultiplyer;
            rogue.PhysDamageAmplifier = _pDamageAmplifierByDefault;
            Console.WriteLine($"New rogue {rogue.Name} has arrived");
            return rogue;
        }
    }
}
