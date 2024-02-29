﻿namespace AS2324._3G.MarongiuMarco.PSArray
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
            foreach (int v in voti)
            {
                Console.Write("Voti: " + voti[v]);
                Console.WriteLine("Pesi: "+ pesi[v]);
            }
        }
        static void CaricaVettori(ref double[] voti, ref int[] pesi)
        {
            Random random = new Random();
            foreach(int v in voti)
            {
                voti[v] = random.Next(1, 11);
                pesi[v] = random.Next(0, 101);
            }
        }
        static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi)
        {
            bool controlloDispari = true;
            foreach(int v in voti)
            {
                if (controlloDispari == true)
                {
                    if (voti[v] > 4)
                    {
                        Console.Write("Voto: " + voti[v]);
                        Console.WriteLine("Peso: " + pesi[v]);
                    }
                }
                controlloDispari = false;
            }
        }
    }
}