namespace AS2324._3G.MarongiuMarco.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("29/02/2024 Marongiu Marco 3g prova singola sugli array ");
            Console.WriteLine("Quanti voti vuoi immettere?");
            int nVoti=Convert.ToInt32(Console.ReadLine());
            double[] voti = new double[nVoti];
            int[] pesi = new int[nVoti];

        }
        void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine("Stampa dei voti e dei pesi");
            foreach (int v in voti)
            {
                Console.Write("Voti: " + voti[v]);
                Console.WriteLine("Pesi: "+ pesi[v]);
            }
        }
    }
}