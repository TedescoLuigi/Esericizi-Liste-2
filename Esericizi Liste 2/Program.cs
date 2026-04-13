namespace Esericizi_Liste_2
{
    internal class Program
    {
        //indice esplosivo 

        static void Esplosivo (List<int> valori )
        {
            for (int i=  valori.Count-1;i>=0;i--)
            {
              if (valori[i] == i)
              {
                    valori.Remove(i);
              }
            }
            foreach (int i in valori)
            {
                Console.WriteLine("["+i+"]");

            }
        }

        //Rotazione della Lista
        static void Rotazione(List<int> numeri1)
        {
            Console.WriteLine("inserisci un numero che spostera la lista di tot valore");
            int scelta=Convert.ToInt32 (Console.ReadLine());

            for (int i = 0; i < numeri1.Count; i++)
            {
                int v = 0;
               

            }

        }
        static void Main(string[] args)
        {
            //indice esplosivo 
            List<int> valori = new List<int>() { 0, 5, 2, 8, 4, 10, 6, 7 };
            Esplosivo(valori);
            Console.WriteLine(valori);

            //Rotazione della Lista
            List<int> numeri1 = new List<int>() { 1, 2, 3, 4, 5 };
            Rotazione(numeri1);
        }
    }
}
