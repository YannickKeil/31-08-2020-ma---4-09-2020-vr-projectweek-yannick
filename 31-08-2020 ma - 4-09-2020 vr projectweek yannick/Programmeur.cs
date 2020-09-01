using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_08_2020_ma___4_09_2020_vr_projectweek_yannick
{
    public class Programmeur : Werknemers
    {
        public bool Bedrijfswagen { get; set; }
        public Programmeur(string naam, bool geslacht, DateTime geboorteDatum, string rijksregisternummer, DateTime datumIntreding, string bankrekening, int uren, bool bedrijfswagen, double startloon = 2200.00, int bijdragenSocialeZekerheid = 200) :base(naam,geslacht,geboorteDatum,rijksregisternummer,datumIntreding,bankrekening,uren,startloon,bijdragenSocialeZekerheid)
        {
            Bedrijfswagen = bedrijfswagen;
        }

        public override double Bedrijfsvoorheffing(double loon)
        {
            double BedrijfsvoorheffingLoon;
            if (Bedrijfswagen)
            { BedrijfsvoorheffingLoon = loon - (loon * 0.1368); }
            else
            { BedrijfsvoorheffingLoon = loon - (loon * 0.1730); }
            return BedrijfsvoorheffingLoon;
        }
    }
}
