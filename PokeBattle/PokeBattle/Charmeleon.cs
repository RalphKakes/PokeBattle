using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Charmeleon : Pokemon
    {
        public Charmeleon(string name) : base(

        name, "Fire", 60,
        new List<Attack>() {
            new Attack("Head Butt", 10, "Fighting"),
            new Attack("Flare", 30, "Fire")
        },
        new Weakness("Water", 2.0f),
        new Resistance("Electric", 10))
        {

        }

    }
}