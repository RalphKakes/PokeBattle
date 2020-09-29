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
            new Attack("Head Butt", 10, "Normal"),
            new Attack("Flare", 30, "Fire")
        },
        new Weakness("Water", 2.0f),
        new Resistance("Ligtning", 10f))
        {

        }

    }
}