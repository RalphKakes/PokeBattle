using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class Charmeleon : Pokemon
    {
        public Charmeleon(string name) : base(

        name, "Fire", 60,
        new List<Attacks>() {
            new Attacks("Head Butt", 10f, "Normal"),
            new Attacks("Flare", 30f, "Fire")
        },
        new Weakness("Water", 2.0f),
        new Resistance("Ligtning", 10f))
        {

        }

    }
}