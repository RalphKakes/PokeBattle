using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Pikachu 
    {
        private string _name = "Pikachu";
        private string _energy = "Electic";
        private int _hitpoints = 60;
        private Weakness _weakness = new Weakness("Fire", 1.5f);
        private Resistance _resistance = new Resistance("Fighting", 20f);


        //public Pikachu(string name) : base(
        //name, "Electric", 60,
        //new List<Attacks>() {
        // new Attacks("Pika Punch", 20, "Fighting"),
        //new Attacks("Electric Ring", 30, "Lightning")
        //},
        //new Weakness("Fire", 1.5F),
        //new Resistance("Fighting", 20))
        //{

        //}
    }
}
