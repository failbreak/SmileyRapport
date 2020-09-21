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
        List<DateTime> Ratings = new List<DateTime>();
        string name; 
        public ClusterFuck(string name)
        {
            this.name = name;
            if (!File.Exists(name + ".txt"))
            {
                File.Create(name + ".txt").Close();
                
            }
            using (StreamReader sr = new StreamReader(name + ".txt"))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    DateTime allanErBoomer = DateTime.Parse(line);
                    Ratings.Add(allanErBoomer);
                }
            }

        }
        public void ToSaving()
        {
            using (StreamWriter sr = new StreamWriter(name + ".txt"))
            {
                foreach (var Tilfredshed in Ratings)
                {
                    sr.WriteLine(Tilfredshed);
                }

            }
        }
        public void Rating()
        {
            Ratings.Add(DateTime.Now);
           
            ToSaving();
        }
        public int Valudering()
        {
            return this.Ratings.Count;
        }

        public void NoCredit()
        {
            this.Ratings = new List<DateTime>();
            ToSaving();

        }
    }
}
