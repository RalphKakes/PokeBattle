using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Pokemon
    {
        private string _name;
        private string _energy;
        private int _hitpoints;
        private List<Weakness> _weaknesses;
        private Weakness _weakness;
        public Pokemon(string _name, string _energy, int _hitpoints, Weakness _weakness, List<Weakness> _weaknesses )
        {
            this._name = _name;
            this._energy = _energy;
            this._hitpoints = _hitpoints;
            this._weakness = _weakness;
            this._weaknesses = _weaknesses;

        }
        public string Name
        {
            get { return this._name; }
        }

        public string Energy
        {
            get { return this._energy; }
        }

        public int Hitpoints
        {
            get { return this._hitpoints; }
        }
    }
}
