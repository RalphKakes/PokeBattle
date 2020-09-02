using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Attacks
    {
        private string _energy;
        private float _multiply;

        public Attacks(string _energy, float _multiply)
        {
            this._energy = _energy;
            this._multiply = _multiply;
        }
        public string Energy
        {
            get { return this._energy; }
        }
    }
}
