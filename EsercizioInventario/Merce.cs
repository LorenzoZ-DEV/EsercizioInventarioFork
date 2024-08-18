using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


    public class Merce
    {
        public string Nome { get; set; }
        public int Quantita { get; set; }
        public string TipoDiMerce {  get; set; }
        public Merce(string nome , int quantita, string tipodimerce)
        {
            Nome = nome;
            Quantita = quantita;
            TipoDiMerce = tipodimerce;

        }
        public void AggiungiQuantita(int  quantita)
        {
            Quantita = quantita;
        }
        public void MostraMerce()
        {
            Console.WriteLine("Merce: " + Nome);
            Console.WriteLine("Quantita : " + Quantita);
            Console.WriteLine("Tipo di merce: " + TipoDiMerce);

        }
    }

