using System;

namespace PokeBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pikachu = new Pokemon("Pikachu", "Electric", 60, new Weakness("ground", 1));
            var pika = new Pikachu("Pik");
            var charm = new Charmeleon("Charmeleon");
            Console.WriteLine(pika.Name);
            pika.performAttack(charm , "Pika Punch");

            //var charm = new Pokemon("")
            //Console.WriteLine(pikachu.Name + " is from type:" + pikachu.Energy + " and has" + pikachu.Hitpoints);

            // a = new Pokemon(....);
            // b = new Pokemon(....);

            //a.performAttack(b, 'flare');
        }
    }
}
