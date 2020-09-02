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
        
        public Programmeur(string naam, bool geslacht, DateTime geboorteDatum, string rijksregisternummer, DateTime datumIntreding, string bankrekening, int uren, bool bedrijfswagen, string functie = "PROGRAMMEUR", double startloon = 2200.00, int bijdragenSocialeZekerheid = 200) :base(naam,geslacht,geboorteDatum,rijksregisternummer,datumIntreding,bankrekening,functie,uren,startloon,bijdragenSocialeZekerheid,bedrijfswagen)
        {
            
        }

        public override double Bedrijfsvoorheffing()
        {
            double BedrijfsvoorheffingLoon;
            if (Bedrijfswagen)
            { BedrijfsvoorheffingLoon = SocialeZekerheid() - (SocialeZekerheid() * 0.1368); }
            else
            { BedrijfsvoorheffingLoon = SocialeZekerheid() - (SocialeZekerheid() * 0.1730); }
            return BedrijfsvoorheffingLoon;
        }
        public override string BedrijfswagenString()
        {
            return Functie;
        }
    }
}
