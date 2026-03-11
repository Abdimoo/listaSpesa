using System;

/*
Programma dove l’utente può gestire una lista.

Funzioni:

aggiungere prodotto

vedere lista

eliminare prodotto

Esempio:

Lista della spesa:
1. Latte
2. Pane
3. Uova

Concetti usati:

List<string>

cicli

menu*/

class Program
{
    static void AggiungiProdotto(List<String> lista)
    {
        Console.WriteLine("Inserire il nome del prodotto da aggiungere");
        string prodotto = Console.ReadLine() ?? "";
        //da inserire un commento nel momento in cui non si inserisce un carattere
        if (!prodotto.Equals(""))
        {
            lista.Add(prodotto);
        } else
        {
            Console.Clear();
            Console.WriteLine("Nessun prodotto è stato aggiunto");
        }
    }

    static void VisualizzaLista(List<String> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("La lista è vuota.");
            return;
        }
        int i=1;
        Console.WriteLine("Ecco la lista della spesa:");
        foreach(string prodotto in lista)
        {
            Console.WriteLine($"{i}. {prodotto}");
            i++;
        }    
    }

    static void eliminaUltimo(List<String> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("La lista è vuota.");
            return;
        }
        Console.WriteLine("Eliminazione ultimo prodotto in corso.");
        lista.RemoveAt(lista.Count-1);
        Console.WriteLine("Ultimo prodotto eliminato.");
        
    }

    static void eliminaLista(List<String> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("La lista è vuota.");
            return;
        }
        Console.WriteLine("Eliminazione tutta la lista in corso.");
        for(int i=lista.Count-1; i >= 0; i--)
        {
            lista.RemoveAt(i);
        }
        Console.WriteLine("Lista eliminata");
    }

    static void Main(string[] args)
    {
        int scelta = -1;
        List<String> listaSpesa = new List<String>();
        do
        {
            Console.Clear();
            Console.WriteLine("Scegliere il tipo di attività da fare:\n1. Aggiungi prodotto alla lista della spesa\n2. Visualizza la spesa\n3. Elimina l'ultimo prodotto dalla spesa\n4. Elimina tutta la lista\n0. Esci dal programma");
            if (!int.TryParse(Console.ReadLine(), out scelta))
            {
                scelta=-1;
            }
            Console.Clear();
            
            switch (scelta)
            {
                case 1:
                    AggiungiProdotto(listaSpesa);   
                break;
                case 2:
                    Console.WriteLine("Ecco la lista della spesa");
                    VisualizzaLista(listaSpesa);
                break;
                case 3:
                    eliminaUltimo(listaSpesa);
                break;
                case 4:
                    eliminaLista(listaSpesa);
                break;
                case 0:
                    Console.WriteLine("Uscita dal programma");
                break;
                default:
                    Console.WriteLine("Scelta non valida. Rieffettuare la scelta.");
                break;
            }
            if (scelta != 0)
            {
                Console.ReadLine();
            }
        }while(scelta!=0);
    }
}