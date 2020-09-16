using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Pikachu : Pokemon
    {
        public Pikachu(string name) : base(

        name, "Electric", 60,
        new List<Attacks>() {
                new Attacks("Pika Punch", 20f, "Fighting"),
                new Attacks("Electric Ring", 30f, "Electric")
            });
        private Weakness _weakness = new Weakness("Fire", 1.5f);
        private Resistance _resistance = new Resistance("Fighting", 20f);


    }
}
