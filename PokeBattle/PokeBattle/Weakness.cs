using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Weakness
    {
        private string _energy;
        private float _multiply;

        public Weakness(string _energy, int _multiply)
        {
            this._energy = _energy;
            this._multiply = _multiply;
        }

        public string Energy
        {
            get { return this._energy; }
        }

        public float Multiply
        {
            get { return this._multiply; }
        }
    }
}
