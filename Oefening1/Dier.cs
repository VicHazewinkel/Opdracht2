using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal abstract class Dier
    {
        private string Uitspraak { get; set; }
        public int Gewicht { get; set; }  
        private string Geluid { get; set; }

        public Dier(string uitspraak, int gewicht, string geluid) { 
            this.Uitspraak = uitspraak; 
            this.Gewicht = gewicht;
            this.Geluid = geluid;
        }

        public string Zegt() { return "uitspraak " + Uitspraak; }
        public string Weegt() { return " weegt " + Gewicht; }
    }
}
