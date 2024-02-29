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
            CaricaVettori(ref voti, ref pesi);
            StampaVotiPesi(voti, pesi);
            Console.WriteLine("stampa dei voti maggiori di 4 in posizione dispari e dei loro relativi pesi");
            StampaVotiDispariMaggiori4(ref voti, ref pesi);
            StampaVotiPesi(voti, pesi);
        }
        static void StampaVotiPesi(double[] voti, int[] pesi)
        {
            Console.WriteLine("Stampa dei voti e dei pesi");
            for(int i = 0; i < pesi.Length; i++)
            {
                Console.Write("Voto: " + voti[i]+" ");
                Console.WriteLine("Peso: " + pesi[i]);
            }
        }
        static void CaricaVettori(ref double[] voti, ref int[] pesi)
        {
            Random random = new Random();
            for(int i=0; i<pesi.Length;i++)
            {
                voti[i] = random.Next(1, 11);
                pesi[i] = random.Next(0, 101);
            }
        }
        static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi)
        {
            bool controlloDispari = true;
            for (int i = 0; i < pesi.Length; i++)
            {
                if (controlloDispari == true)
                {
                    if (voti[i] > 4)
                    {
                        Console.Write("Voto: " + voti[i]+" ");
                        Console.WriteLine("Peso: " + pesi[i]);
                    }
                    controlloDispari = false;
                }
                else
                {
                    controlloDispari = true;
                }
                
                
            }
        }
    }
}