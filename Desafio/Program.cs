using System;
using Desafio.src.Entities;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Maleficus", 99, "Devil");
            Console.WriteLine(wizard.Attack(2));
            Console.WriteLine(arus.Attack());
        }
    }
}
