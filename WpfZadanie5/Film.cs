using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfZadanie5
{
    internal class Film
    {
        public string tytul { get; set; }
        public DateTime data { get; set; }
        public string opis { get; set; }

        public Film(string t, DateTime d, string o)
        {
            tytul = t;
            data = d;
            opis = o;
        }

        public override string ToString()
        {
            return "Tytuł: " + tytul;
        }
    }
}
