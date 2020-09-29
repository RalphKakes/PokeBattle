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
        private List<Attack> _attacks;
        private Weakness _weakness;
        private Resistance _resistance;
        public Pokemon(string _name, string _energy, int _hitpoints, List<Attack> attacks ,Weakness _weakness, Resistance _resistance)
        {
            this._name = _name;
            this._energy = _energy;
            this._hitpoints = _hitpoints;
            this._attacks = new List<Attack>(attacks);
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
            
                Attack attack = this._attacks.Find(attack => attack.Name == attackName);
            if (!(attack is null) )
            {
                Console.WriteLine(attack.Name);
                //gevonnden attack ja: in thisAttack  Foe.takeDamage(this.energyType, thisAttack.damage)
                foe.takeDamage(this.Energy, attack.AttackPoints);

            }
            
            
        }

        public void takeDamage(string energytype, int damage)
        {
            Console.WriteLine(energytype);
            Console.WriteLine(damage);
            //logic voor het berekenen van de echte damage.
        }
    }
}
