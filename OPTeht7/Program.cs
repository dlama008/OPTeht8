using System;

namespace OPTeht7
{
    class Program
    {
        static void Main(string[] args)
        {
            
              
                bool jatkuu;
                do
                {
                    Console.Write("Anna säde: ");
                    string vastaanotettu = Console.ReadLine();
                    double kelpo;
                    //Säteen tulla olla positiivinen luku
                    while (!Double.TryParse(vastaanotettu, out kelpo) || kelpo<0)
                    {
                        Console.Write("Virheellinen arvo, yritä vielä: ");
                        vastaanotettu = Console.ReadLine();
                    }
                //Nyt voit luoda olion:
                Ympyra ympyra = new Ympyra(kelpo);
                Console.WriteLine("Säde: {0:F3}, pinta-ala: {1:F3}.",
                   ympyra.Sade, ympyra.LaskeAla());




                Console.Write("Jatketaanko K/E?: ");
                    string valinta = Console.ReadLine().ToUpper();
                    if (valinta.StartsWith("K"))
                        jatkuu = true;
                    else
                        jatkuu = false;
                } while (jatkuu);
            
        }
    }

    internal class Ympyra
    {
        internal int Sade;
        private double kelpo;

        public Ympyra(double kelpo)
        {
            this.kelpo = kelpo;
        }

        internal int LaskeAla()
        {
            throw new NotImplementedException();
        }
    }
}
