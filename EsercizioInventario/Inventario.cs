using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Inventario
    {
        string NomeNegozio { get; set; }
        public List<Merce> merci;
        public Inventario(string nomenegozio)
        {
            NomeNegozio = nomenegozio;
            merci = new List<Merce>();
        }

        public void AggiungiMerceAdInventario(Merce merce)
        {
            merci.Add(merce);            
        }
        public void MostraInventario()
        {
            Console.WriteLine("Inventario del negozio : " + NomeNegozio);
            foreach (var merce in merci)
            {
                merce.MostraMerce();
            }
        }
    }

