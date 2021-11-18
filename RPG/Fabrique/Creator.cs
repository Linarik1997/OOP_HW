using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.RPG.Fabrique
{
    public abstract class Creator<T> where T:Hero
    {
        protected const int _hpMultiplyer = 10;
        protected const int _mpMultiplyer = 10;
        public abstract T Create(string name);
    }
}
