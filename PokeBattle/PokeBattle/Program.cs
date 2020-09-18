using System;

namespace PokeBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pikachu = new Pokemon("Pikachu", "Electric", 60, new Weakness("ground", 1));
            var pika = new Pikachu("Pik");
            Console.WriteLine(pika.Name);
            //var charm = new Pokemon("")
            //Console.WriteLine(pikachu.Name + " is from type:" + pikachu.Energy + " and has" + pikachu.Hitpoints);
        }
    }
}
