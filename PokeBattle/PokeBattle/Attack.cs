using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Attack
    {
        private string _name;
        private float _dmg;
        public Attack(string name, float dmg)
        {
            this._name = name;
            this._dmg = dmg;
        }
    }
}
