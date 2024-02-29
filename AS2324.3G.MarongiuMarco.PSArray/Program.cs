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

            double max=voti[0];
            double min=voti[0];
            int posmax=0;
            int posmin=0;
            double media = MediaPonderata(ref voti, ref pesi, ref max, ref posmax, ref min, ref posmin);
            Console.WriteLine("la media ponderata è: "+media);
            Console.WriteLine("il valore massimo è: " + max + " con posizione: "+posmax);
            Console.WriteLine("il valore minimo è: " + min + " con posizione: "+posmin);
            StampaVotiPesi(voti, pesi);

            Console.WriteLine("inserisci un voto");
            double votoUtente=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("stampa dei voti con un valore +/-0.5 al voto immesso da te");
            ElencoVotiNellIntorno(ref voti,ref pesi, ref votoUtente);
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
                voti[i] = random.NextDouble()*10+1;
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
        static double MediaPonderata(ref double[] voti,ref int[] pesi, ref double max, ref int posmax,ref double min, ref int posmin)
        {
            double Sommatoria1 = 0;
            int Sommatoria2=0;
            for(int i = 0;i < pesi.Length;i++)
            {
                Sommatoria1+= voti[i]*pesi[i];
                Sommatoria2 += pesi[i];
                if (voti[i] > max)
                {
                    max= voti[i];
                    posmax = i+1;
                }
                if (voti[i] < min)
                {
                    min= voti[i];
                    posmin = i+1;
                }
            }
            double media=Sommatoria1/Sommatoria2;
            
            return media;
        }
        static void ElencoVotiNellIntorno(ref double[] voti, ref int[] pesi,ref double votoUtente)
        {
            for(int i = 0; i < pesi.Length;i++)
            {
                if (votoUtente >= voti[i]-0.5 && votoUtente <= voti[i]+0.5)
                {
                    Console.Write("Voto: " + voti[i] + " ");
                    Console.WriteLine("Peso: " + pesi[i]);
                }
            }
        }
    }
}