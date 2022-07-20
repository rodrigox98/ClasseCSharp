using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe.src
{
    internal class Bicicleta
    {
        string Cor { get; set; }
        string Tamanho { get; set; } 
        bool ModeloComRodinhas   { get; set; }
        bool MontadoBicicleta { get; set; }
        public Bicicleta()
        {

        }

        public Bicicleta(string cor, string tamanho, bool modeloComRodinhas)
        {
            Cor = cor;
            Tamanho = tamanho;
            ModeloComRodinhas = modeloComRodinhas;
        }


        public void Subir()
        {
            Console.WriteLine("Bora fi pedala");
            MontadoBicicleta = true;
        }
        public void Descendo()
        {
            Console.WriteLine("Cansou");
            MontadoBicicleta = false;
        }
        public void Pedalar()
        {
            if (MontadoBicicleta == true)
            {
                Console.WriteLine("Acelera fi!");
            }else
            {
                Console.WriteLine("Sobe na bicicleta primeiro né fi");
            }
        }
        public void Freiar()
        {
            Console.WriteLine("TÁ Bracando! Deixa ir..");
        }

        public override string ToString()
        {
            return $"A cor é : {Cor}" +
                   $"\n O tamanho é :{Tamanho}" +
                   $"\n Possui rodinhas:{ModeloComRodinhas}";
                
        }
    }
}
