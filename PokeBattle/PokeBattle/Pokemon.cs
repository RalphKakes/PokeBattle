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
        private List<Attacks> _attacks;
        private Weakness _weakness;
        private Resistance _resistance;
        public Pokemon(string _name, string _energy, int _hitpoints, List<Attacks> attacks ,Weakness _weakness, Resistance _resistance)
        {
            this._name = _name;
            this._energy = _energy;
            this._hitpoints = _hitpoints;
            this._attacks = new List<Attacks>(attacks);
            this._weakness = _weakness;
            this._resistance = _resistance;

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
        public void performAttack(Pokemon foe, string attackName)
        {
            //zoek bijbehorende attack in this.attacks op basis van attackName
            Attacks attack = this._attacks.Find(foe => foe.Name == attackName);
            //gevonnden attack ja: in thisAttack  Foe.takeDamage(this.energyType, thisAttack.damage)
            foe.takeDamage(this.Energy, this._attacks);
        }

        public void takeDamage(string energytype, int damage)
        {
            //logic voor het berekenen van de echte damage.
        }
    }
}
