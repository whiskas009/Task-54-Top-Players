using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_53_Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>(){
            new Player("Антон", 32, 900),
            new Player("Денис", 12, 430),
            new Player("Макс", 78, 123),
            new Player("Артём", 98, 600),
            new Player("Лиза", 96, 490),
            new Player("Настя", 11, 34),
            new Player("Кирилл", 95, 700),
            new Player("Тимур", 19, 220),
            new Player("Влад", 43, 320),
            new Player("Кристина", 19, 850)};

            var sortedByLevel = players.OrderByDescending(p => p.Level).Take(3);

            Console.WriteLine("Топ 3 по уровню: ");

            foreach (var player in sortedByLevel)
            {
                player.ShowInfo();
            }

            sortedByLevel = players.OrderByDescending(p => p.Power).Take(3);

            Console.WriteLine("\nТоп 3 по силе: ");

            foreach (var player in sortedByLevel)
            {
                player.ShowInfo();
            }
        }
    }

    class Player
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }

        public Player(string name, int level, int power)
        {
            Name = name;
            Level = level;
            Power = power;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}. Уровень: {Level}. Сила: {Power}.");
        }
    }
}
