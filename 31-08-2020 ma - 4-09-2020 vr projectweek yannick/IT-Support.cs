using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_08_2020_ma___4_09_2020_vr_projectweek_yannick
{
    public class IT_Support:Werknemers
    {
        public IT_Support(string naam, bool geslacht, DateTime geboorteDatum, string rijksregisternummer, DateTime datumIntreding, string bankrekening, int uren = 38, double startloon = 2050.00, int bijdragenSocialeZekerheid = 200) : base(naam, geslacht, geboorteDatum, rijksregisternummer, datumIntreding, bankrekening, uren, startloon, bijdragenSocialeZekerheid)
        {
            
        }

        public override double Bedrijfsvoorheffing(double loon)
        {
            return base.Bedrijfsvoorheffing(loon)+50;
        }
        public double StartloonPercent()
        {
            double startloonPercent = Startloon * 0.06;
            return startloonPercent;
        }

        public override double AncienniteitEnSocialeZekerheid()
        {
            int AantalJarenDienst = AncienniteitJaren();
            double Loon = Startloon- StartloonPercent();

            for (int i = 0; i < AantalJarenDienst; i++)
            {
                Loon *= 1.1;
            }
            Loon = Loon + StartloonPercent() -BijdragenSocialeZekerheid;
            return Loon;
        }
    }
}
