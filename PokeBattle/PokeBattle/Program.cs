using System;

namespace PokeBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon Pikachu = new Pokemon("Pikachu", "Electric", 60);
            Console.WriteLine(Pikachu.Name + " is from type:" + Pikachu.Energy + " and has" + Pikachu.Hitpoints);
            Console.WriteLine(Pikachu.Energy);
        }
    }
}
