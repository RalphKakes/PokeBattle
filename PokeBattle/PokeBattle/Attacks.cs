using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Attacks
    {
        private string _energy;
        private float _multiply;

        public Weakness(string _energy, int _multiply)
        {
            this._energy = _energy;
            this._multiply = _multiply;
        }
    }
}
