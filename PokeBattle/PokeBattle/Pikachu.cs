using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Pikachu : Pokemon
    {
        public Pikachu(string name) : base(

        name, "Electric", 60,
        new List<Attack>() {
            new Attack("Pika Punch", 20, "Fighting"),
            new Attack("Electric Ring", 30, "Electric")
        },
        new Weakness("Fire", 1.5f),
        new Resistance("Fighting", 20f))
        {

        }


    }
}