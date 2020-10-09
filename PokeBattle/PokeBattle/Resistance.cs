using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Resistance
    {
        private string _energyType;
        private int _damageReduction;

        public Resistance(string energyType, int damageReduction)
        {
            this._energyType = energyType;
            this._damageReduction = damageReduction;
        }

        public string EnergyType
        {
            get { return this._energyType; }
        }
        public int DamageReduction
        {
            get { return this._damageReduction; }
        }
    }
}
