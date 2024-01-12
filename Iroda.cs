using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irodahaz
{
    internal class Iroda
    {
        public string cegNev { get; set; }
        public int bekoltozesEve { get; set; }
        public List<int> irodaLetszam { get; set; }

        public Iroda(string s)
        {
            var pieces = s.Split(" ");
            this.cegNev = pieces[0];
            this.bekoltozesEve = int.Parse(pieces[1]);
            irodaLetszam = new List<int>();
            for (int i = 2; i < pieces.Length; i++) { this.irodaLetszam.Add(int.Parse(pieces[i])); }
        }

        public override string ToString()
        {
            string irodistak = "";
            for (int i = 0; i < irodaLetszam.Count; i++) { irodistak += irodaLetszam[i] + " "; }
            return $"{this.cegNev};".PadRight(18) + $"{this.bekoltozesEve};".PadRight(10) + $"{irodistak}";
        }
    }

}
