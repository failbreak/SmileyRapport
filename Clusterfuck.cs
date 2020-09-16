using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmileyRapport_Csharp
{
    public class ClusterFuck
    {
        string[] TilfredsHedsSkala = new string[4] { "Super Tilfreds", "Tilfreds", "ikke Tilfreds", "Virklig Utilfreds" };
        List<Tuple<DateTime, int>> Ratings = new List<Tuple<DateTime, int>>();
        public ClusterFuck()
        {
            if (!File.Exists("TilfredsHedsData.txt"))
            {
                File.Create("TilfredsHedsData.txt").Close();
                
            }
            using (StreamReader sr = new StreamReader("TilfredsHedsData.txt"))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {

                    string[] teach = line.Split('-');
                    DateTime allanErBoomer = DateTime.Parse(teach[0]);
                    int RateShadowLegends = Array.IndexOf(TilfredsHedsSkala, teach[1]);
                    Ratings.Add(new Tuple<DateTime, int>(allanErBoomer, RateShadowLegends));
                }
            }

        }
        public void ToSaveThemIsMyCause()
        {
            using (StreamWriter sr = new StreamWriter("TilfredsHedsData.txt"))
            {
                foreach (var Tilfredshed in Ratings)
                {
                    sr.WriteLine(Tilfredshed.Item1 + "-" + TilfredsHedsSkala[Tilfredshed.Item2]);
                }

            }
        }
        public void RatingOthersBeHating(int RatingTheKristneBøger)
        {
            Ratings.Add(new Tuple<DateTime, int>(DateTime.Now, RatingTheKristneBøger));
            while (Ratings.Count >= 100)
            {
                Ratings.RemoveAt(0);
            }
            ToSaveThemIsMyCause();
        }
        public void InterspeciesValudering()
        {
            List<int> wut = Ratings.Select(x => x.Item2).ToList(); //transformere hver enkel item fra listen //NILLER SAID SO//
            float TotallyNotNillerSuperTilfreds = wut.FindAll(x => x == 0).Count();
            float TotallyNoNillerTilfreds = wut.FindAll(x => x == 1).Count();
            float TotallyNoNillerIkkeTilfreds = wut.FindAll(x => x == 2).Count();
            float TotallyNoNillerVirkligUtilfreds = wut.FindAll(x => x == 3).Count();
            float EtNavn = wut.Count();
            Console.WriteLine($"SuperTilfreds {TotallyNotNillerSuperTilfreds / EtNavn}");
            Console.WriteLine($"Tilfreds {TotallyNoNillerTilfreds / EtNavn}");
            Console.WriteLine($"IkkeTilfreds {TotallyNoNillerIkkeTilfreds / EtNavn}");
            Console.WriteLine($"VirkligUtilfreds {TotallyNoNillerVirkligUtilfreds / EtNavn}");
        }
    }
}
