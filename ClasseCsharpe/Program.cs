using Classe.src;
using System;

namespace Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicicleta bike1 = new Bicicleta();
            Bicicleta bike2 = new Bicicleta("Vermelho", "Médio", false);
            Bicicleta bike3 = new Bicicleta("Azul", "Pequeno", true);
            Bicicleta bike4 = new Bicicleta("Verde", "Grande", true);


            bike1.Subir();
            bike1.Pedalar();
            bike1.Descendo();

            Console.WriteLine(bike2.ToString());
        }
    }
}
