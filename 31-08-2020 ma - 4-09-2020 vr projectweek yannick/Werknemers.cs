using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _31_08_2020_ma___4_09_2020_vr_projectweek_yannick
{
    public class Werknemers
    {
        public string Naam { get; set; }
        public bool Geslacht { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Rijksregisternummer { get; set; }
        public DateTime DatumIntreding { get; set; }
        public string Bankrekening { get; set; }
        public int Uren { get; set; }
        public double Startloon { get; }
        public int BijdragenSocialeZekerheid { get; }

        public Werknemers(string naam, bool geslacht, DateTime geboorteDatum, string rijksregisternummer, DateTime datumIntreding, string bankrekening, int uren, double startloon = 1900.00 ,int bijdragenSocialeZekerheid = 200)
        {
            Naam = naam;
            Geslacht = geslacht;
            GeboorteDatum = geboorteDatum;
            Rijksregisternummer = rijksregisternummer;
            DatumIntreding = datumIntreding;
            Bankrekening = bankrekening;
            Uren = uren;
            Startloon = startloon;
            BijdragenSocialeZekerheid = bijdragenSocialeZekerheid;
        }
        public int AncienniteitJaren()
        {
            int AncienniteidJaren = DatumIntreding.Year - DateTime.Now.Year;
            if (DateTime.Now.Month < DatumIntreding.Month )
            {AncienniteidJaren -= 1;}
            
            
            return AncienniteidJaren;
        }
        public double StartloonNaUren()
        {
            double StartloonNaUren = (Uren / 38) * Startloon;
            return StartloonNaUren;
        }
        public virtual double AncienniteitEnSocialeZekerheid()
        {
            int AantalJarenDienst = AncienniteitJaren();
            double Loon = StartloonNaUren();
            
            for (int i = 0; i < AantalJarenDienst; i++)
            {
                Loon *= 1.1;
            }
            Loon -= BijdragenSocialeZekerheid;
            return Loon;
        }
        public virtual double Bedrijfsvoorheffing(double loon)
        {
            double BedrijfsvoorheffingLoon = loon - (loon * 0.1368);
            return BedrijfsvoorheffingLoon;
        }
       
    }
}
