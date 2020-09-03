using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_08_2020_ma___4_09_2020_vr_projectweek_yannick
{
    public class Costumer_Support:Werknemers
    {
        public Costumer_Support(string naam, bool geslacht, DateTime geboorteDatum, string rijksregisternummer, DateTime datumIntreding, string bankrekening, int uren, string functie = "CUSTOMER SUPPORT", double startloon = 2050.00, int bijdragenSocialeZekerheid = 200, bool bedrijfswagen =false) : base(naam, geslacht, geboorteDatum, rijksregisternummer, datumIntreding, bankrekening,functie, uren, startloon, bijdragenSocialeZekerheid, bedrijfswagen)
        {

        }

        public override double Extras()
        {
            return base.Extras() + 50 + 19.50;
        }
        public override string Support()
        {
            return Functie;
        }
        public override string CostumerSupport()
        {
            return Functie;
        }
        public override double Recap()
        {
            return base.Recap() + 50+19.5;
        }
    }
}
