using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Warrior = new Player("Олаф - ", 1000, 75, 25);

            Warrior.ShowStats();        
        }
    }

    class Player
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;

        public Player(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public void ShowStats ()
        {
            Console.WriteLine(_name + "Жизни - " + _health + " Дамага - " + _damage + " Брони - " + _armor);
        }
    }
}
