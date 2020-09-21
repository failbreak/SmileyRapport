using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmileyRapport_Csharp
{
   class Program
    {
        static void Main(string[] args)
        {
            // tilfredsheds skala
            string[] TilfredsHedsSkala = new string[4] { "Super Tilfreds", "Tilfreds", "ikke Tilfreds", "Virklig Utilfreds" };

            // slut af denne skala

            // valg

            int brugerensValg;
            var MetodeBrug = new ClusterFuck("Super Tilfreds");
            var MetodeBrug2 = new ClusterFuck("Tilfreds");
            var MetodeBrug3 = new ClusterFuck("Ikke Tilfreds");
            var MetodeBrug4 = new ClusterFuck("Virklig Utilfreds");
            while (true)
            {
                Console.WriteLine(" Vi hos elgiganten elsker feedback");
                Console.WriteLine(" derfor vil vi gerne høre din mening");
                Console.WriteLine("Indtast din mening");
                Console.WriteLine("1: SUPER tilfreds");
                Console.WriteLine("2: tilfreds ");
                Console.WriteLine("3: ikke tilfreds");
                Console.WriteLine("4: virklig utilfreds ");
                brugerensValg = Convert.ToInt32(Console.ReadLine());
                //slut af valg

                switch (brugerensValg)
                {
                    case 1:

                        Console.Write("Du har valgt ");
                        Console.WriteLine("Super tilfreds", Console.ForegroundColor = ConsoleColor.DarkGreen);
                        Console.ResetColor();
                        MetodeBrug.Rating();
                        break;
                    case 2:
                        Console.WriteLine("Du har valgt");
                        Console.WriteLine(" tilfreds", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ResetColor();
                        MetodeBrug2.Rating();

                        break;
                    case 3:
                        Console.WriteLine("Du har valgt");
                        Console.WriteLine("ikke tilfreds", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ResetColor();
                        MetodeBrug3.Rating();

                        break;

                    case 4:
                        Console.WriteLine("Du har valgt");
                        Console.WriteLine("virkelig utilfreds", Console.ForegroundColor = ConsoleColor.DarkRed);
                        Console.ResetColor();
                        MetodeBrug4.Rating();

                        break;

                    case 99:

                        int Akode = 1337;
                        int forsøg = 3;
                        int kode;
                        for (int i = 1; i <= forsøg; i++)
                        {
                            Console.WriteLine("Indtast admin kode");
                            kode = Convert.ToInt32(Console.ReadLine());

                            if (kode == Akode)
                            {
                                int aaValg;
                                Console.WriteLine("velkomen til admin");
                                Console.WriteLine("1: tilføj tilfredshed med 100");
                                Console.WriteLine("2: xi jinping mode");
                                aaValg = Convert.ToInt32(Console.ReadLine());

                                switch (aaValg)
                                {
                                    case 1:
                                        var randoms = new Random();
                                        for (int g = 0; g < 100; g++)
                                        {
                                            switch (randoms.Next(4))
                                            {
                                                case 0:

                                                    MetodeBrug.Rating();

                                                    break;

                                                case 1:

                                                    MetodeBrug2.Rating();

                                                    break;
                                                case 2:

                                                    MetodeBrug3.Rating();

                                                    break;
                                                case 3:

                                                    MetodeBrug4.Rating();

                                                    break;
                                                
                                            }
                                        }
                                        break;

                                    case 2:
                                        int holdn;
                                        Console.WriteLine("slet nogle holdnigner");
                                        Console.WriteLine("1: Super Tilfreds");
                                        Console.WriteLine("2: Tilfreds");
                                        Console.WriteLine("3: ikke Tilfreds");
                                        Console.WriteLine("4: Virklig Utilfreds");

                                        holdn = Convert.ToInt32(Console.ReadLine());

                                        switch (holdn)
                                        {

                                            case 1:
                                                MetodeBrug.NoCredit();
                                                break;
                                            case 2:
                                                MetodeBrug2.NoCredit();
                                                break;
                                            case 3:
                                                MetodeBrug3.NoCredit();
                                                break;
                                            case 4:
                                                MetodeBrug4.NoCredit();
                                                break;

                                            default:
                                                break;
                                        }

                                        break;
                                    default:
                                        break;
                                }
                                break;
                            }

                        }


                        break;


                    default:

                        break;

                }
                stat(new ClusterFuck[] { MetodeBrug, MetodeBrug2, MetodeBrug3, MetodeBrug4 });
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            void stat(ClusterFuck[] JustLikeDarkSouls)
            {
                int Stil = JustLikeDarkSouls[0].Valudering();
                int Til = JustLikeDarkSouls[1].Valudering();
                int Itil = JustLikeDarkSouls[2].Valudering();
                int Util = JustLikeDarkSouls[3].Valudering();
                float count = Stil + Til + Itil + Util;
                Console.WriteLine($"Super Tilfreds {Stil / count } ");
                Console.WriteLine($"Tilfreds {Til / count } ");
                Console.WriteLine($"ikke Tilfreds {Itil / count } ");
                Console.WriteLine($"Virklig utilfreds {Util / count } ");
                
            }
        }

    }

}
