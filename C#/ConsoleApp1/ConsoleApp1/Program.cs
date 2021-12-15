using System;
using Primeiro;
using Classee;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Joao;
            Pessoas pessoa3 = (Pessoas)4;

            Animal animal = new Animal();

            animal.Nome = "Astro";
            animal.Especie = "Cachorro";
            animal.NomeDono = "Nicolas";

            Pessoa person = new Pessoa();
            person.Nome = "Nicolas";
            person.Idade = 18;
            person.Estado = "SP";

            var person2 = new Pessoa();

            person.Nome = "Jesebel";
            person.Idade = 58;
            person2.Estado = "AM";

            var classe = new Classe();
            var classe2 = new Segundo.Classe();
        }
    }
}
