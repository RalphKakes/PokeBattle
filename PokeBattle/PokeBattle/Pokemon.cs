using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
     class Pokemon
    {
        private string _name;
        private string _energy;
        private float _hitpoints;
        private List<Attack> _attacks;
        private Weakness _weakness;
        private Resistance _resistance;
        public float Hitpoints
        {
            get { return this._hitpoints; }
        }

        public void setHitpoints(float value)
        {
            this._hitpoints = value;
        }

        public string Name
        {
            get { return this._name; }
        }

        public string Energy
        {
            get { return this._energy; }
        }
        public Pokemon(string _name, string _energy, int _hitpoints, List<Attack> attacks ,Weakness _weakness, Resistance _resistance)
        {
            this._name = _name;
            this._energy = _energy;
            this._hitpoints = _hitpoints;
            this._attacks = new List<Attack>(attacks);
            this._weakness = _weakness;
            this._resistance = _resistance;
        }
       
        
        public void performAttack(Pokemon foe, string attackName)
        {
            //zoek bijbehorende attack in this.attacks op basis van attackName
            
            Attack attack = this._attacks.Find(attack => attack.Name == attackName);
            if (!(attack is null))
            {     

                //gevonnden attack ja: in thisAttack  Foe.takeDamage(this.energyType, thisAttack.damage)

                float multiplier = 1;
                float damage = attack.AttackPoints;

                if (attack.EnergyType == foe._weakness.Energy)
                {
                    multiplier = foe._weakness.Multiply;
                }

                if(attack.EnergyType == foe._resistance.EnergyType)
                {
                    damage -= foe._resistance.DamageReduction;
                    if (damage < 0) damage = 0;
                }

                foe.takeDamage(damage * multiplier, foe);

            }
        }

        public void takeDamage(float damage, Pokemon foe)
        {
            foe.setHitpoints(foe.Hitpoints - damage);
            //logic voor het berekenen van de echte damage.
        }
    }
}
