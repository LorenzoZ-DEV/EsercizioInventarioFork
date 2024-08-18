// Creazione dell'inventario
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System;

class Program
{
    static void Main(string[] args)
    {

        // oggetto generale delle merci
        // creazione delle merci
        Merce pane = new Merce("Pane", 50, "Alimentare");
        Merce uova = new Merce("Uova", 30, "Alimentare");
        Merce latte = new Merce("Latte", 10, "Alimentare");

        // nome del inventario
        Inventario inventario = new Inventario("Vlessy Market");

        // aggiunta delle merci al invantario
        inventario.AggiungiMerceAdInventario(pane);
        inventario.AggiungiMerceAdInventario(latte);
        inventario.AggiungiMerceAdInventario(uova);

        // modifica delle quantita
        pane.AggiungiQuantita(3);
        latte.AggiungiQuantita(20);

        // stampa della visualizzazione del inventario
        inventario.MostraInventario();
    }
}