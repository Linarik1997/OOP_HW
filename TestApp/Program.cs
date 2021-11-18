using System;
using OOP_HW.RationalNumbers;
using OOP_HW.RPG;
using OOP_HW.RPG.Fabrique;
using OOP_HW.Buildings;
using OOP_HW.RPG.Heroes;
using OOP_HW.RPG.Ablts;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MageCreator mg = new MageCreator();
            var Alex = mg.Create("Alex");
            var Tony = mg.Create("Tony");
            Alex.Cast(Tony, Alex.Abilities[0]);
            Alex.Cast(Tony, Alex.Abilities[0]);
            WarriorCreator warriorCreator = new WarriorCreator();
            var Gerald = warriorCreator.Create("Gerald");
            Gerald.Attack(Tony);
            Console.WriteLine(Tony);
            Console.ReadLine();
        }
    }
}
