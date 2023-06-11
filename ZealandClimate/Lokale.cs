using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimate
{
    internal class Lokale
    {

        public int id;
        public string lokaleNummer;
        public int maxAntalPersoner;


        public Lokale(int id, string lokaleNummer, int maxAntalPersoner)
        {
            ID = id;
            LokaleNummer = lokaleNummer;
            MaxAntalPersoner = maxAntalPersoner;
        }

        public int ID { get; set; }
        public string LokaleNummer { get; set; }
        public int MaxAntalPersoner { get; set; }


        public override string ToString()
        {
            return $"Lokalenummer info: {ID}, {LokaleNummer}, {MaxAntalPersoner}";
        }
    }
}
