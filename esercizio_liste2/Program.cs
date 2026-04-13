using static System.Runtime.InteropServices.JavaScript.JSType;

namespace esercizio_liste2
{
    internal class Program
    {
        // funzione indice esplosivo
        static void IndEsplosivo(List<int> numeri)
        {
            for (int i = numeri.Count - 1; i >= 0; i--)
            {
                if (numeri[i] == i)
                {
                    numeri.Remove(i);
                }
            } 
            foreach (int i in numeri)
            {
                Console.Write("[" + i + "]");
            }
        }

        // funzione rotazione lista
        static void Rotazione(List<int> num)
        {
            Console.WriteLine("Inserisci numeri spostamenti");
            int scelta = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num.Count; i++)
            {
                int v = 0;
                
            }
        }

        static void Main(string[] args)
        {
            // indice esplosivo
            List<int> numeri = new List<int>() { 0, 5, 2, 8, 4, 10, 6, 7 };
            IndEsplosivo(numeri);

            // rotazione lista 
            List<int> num = new List<int>() { 1, 2, 3, 4, 5 };


        }
    }
}
