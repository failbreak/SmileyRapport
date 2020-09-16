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
            var poopKun = new ClusterFuck();
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
                        poopKun.RatingOthersBeHating(0);
                        poopKun.ToSaveThemIsMyCause();
                        break;
                    case 2:
                        Console.WriteLine("Du har valgt tilfreds", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ResetColor();
                        poopKun.RatingOthersBeHating(1);
                        poopKun.ToSaveThemIsMyCause();
                        break;
                    case 3:
                        Console.WriteLine("Du har valgt ikke tilfreds", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ResetColor();
                        poopKun.RatingOthersBeHating(2);
                        poopKun.ToSaveThemIsMyCause();
                        break;

                    case 4:
                        Console.WriteLine("Du har valgt virkelig utilfreds", Console.ForegroundColor = ConsoleColor.DarkRed);
                        Console.ResetColor();
                        poopKun.RatingOthersBeHating(3);
                        poopKun.ToSaveThemIsMyCause();
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
                                Console.WriteLine("velkomen til admin");


                                break;
                            }

                        }


                        break;


                    default:

                        break;

                }
                poopKun.InterspeciesValudering();
                System.Threading.Thread.Sleep(10000);
                Console.Clear();
            }

        }

    }

}
