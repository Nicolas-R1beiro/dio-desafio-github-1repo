using System;

namespace Rpg_Game
{
    class Program
    {
        public static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 23, "Ninja");
            Wizard topapa = new Wizard("Topapa", 23, "Black Wizard");

            System.Console.WriteLine(arus.ToString() + " | " + arus.Attack());
            System.Console.WriteLine(jennica.ToString() + " | " + jennica.Attack(7));
            System.Console.WriteLine(wedge + " | " + wedge.Attack());
             System.Console.WriteLine(topapa + " | " + topapa.Attack(4));
        }
    }
}