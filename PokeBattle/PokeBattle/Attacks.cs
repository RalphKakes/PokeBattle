using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Attacks
    {
        private string _name;
        private float _attackPoints;
        private string _energyType;

        public Attacks(string name, float attackPoints, string energyType)
        {
            this._name = name;
            this._attackPoints = attackPoints;
            this._energyType = energyType;
        }

        public string Name
        {
            get { return this._name; }
        }
        public float AttackPoints
        {
            get { return this._attackPoints; }
        }
        public string EnergyType
        {
            get { return this._energyType; }
        }
    }
}
