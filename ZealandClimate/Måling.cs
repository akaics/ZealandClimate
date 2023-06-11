using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimate
{
    internal class Måling : Lokale 
    {
        //properties 

        public int id;
        public DateTime dateTime;
        public double temp;
        public int co2;

        //constructor
        public Måling(int ID, DateTime DateTime, double Temp, int Co2)
        {
            ID = id;
            DateTime = dateTime;
            Temp = temp;
            Co2 = co2;
        }

        //getters and setters (prop)
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public double Temp { get; set; }

        public int Co2 { get; set; }

        // ToString method 

        public override string ToString()
        {
            return $"Måling: {ID}, {DateTime}, {Temp}"; 
        }
    }
}
