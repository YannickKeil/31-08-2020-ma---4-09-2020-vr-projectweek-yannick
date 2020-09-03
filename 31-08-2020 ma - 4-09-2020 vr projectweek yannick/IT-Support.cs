using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_08_2020_ma___4_09_2020_vr_projectweek_yannick
{
    public class IT_Support : Werknemers
    {
        public IT_Support(string naam, bool geslacht, DateTime geboorteDatum, string rijksregisternummer, DateTime datumIntreding, string bankrekening, string functie = "IT SUPPORT", int uren = 38, double startloon = 2050.00, int bijdragenSocialeZekerheid = 200, bool bedrijfswagen = false) : base(naam, geslacht, geboorteDatum, rijksregisternummer, datumIntreding, bankrekening,functie, uren, startloon, bijdragenSocialeZekerheid, bedrijfswagen)
        {

        }

        public double StartloonPercent()
        {
            double startloonPercent = Startloon * 0.06;
            return startloonPercent;
        }

        public override double Ancienniteit()
        {
            int AantalJarenDienst = AncienniteitJaren();
            double Loon = Startloon - StartloonPercent();

            for (int i = 0; i < AantalJarenDienst; i++)
            {
                Loon *= 1.01;
            }
            Loon = Loon + StartloonPercent();
            return Loon;
        }
        //public override double AncienniteitVerschil()
        //{
        //    double ancienniteit = Ancienniteit() - StartloonPercent() - StartloonNaUren();
        //    return ancienniteit;
        //}
        public override double Extras()
        {
            return base.Extras() + 50;
        }
        public override string Support()
        {
            return Functie;
        }
        public override double Recap()
        {
            return base.Recap()+50;
        }
    }
}
