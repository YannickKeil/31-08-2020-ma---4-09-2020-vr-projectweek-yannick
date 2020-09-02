using System;
using System.Collections.Generic;
using System.IO;
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
        public string Functie { get; set; }
        public int Uren { get; set; }
        public double Startloon { get; }
        public int BijdragenSocialeZekerheid { get; }
        public bool Bedrijfswagen { get; set; }

        public Werknemers(string naam, bool geslacht, DateTime geboorteDatum, string rijksregisternummer, DateTime datumIntreding, string bankrekening, string functie, int uren, double startloon = 1900.00 ,int bijdragenSocialeZekerheid = 200, bool bedrijfswagen = false)
        {
            Naam = naam;
            Geslacht = geslacht;
            GeboorteDatum = geboorteDatum;
            Rijksregisternummer = rijksregisternummer;
            DatumIntreding = datumIntreding;
            Bankrekening = bankrekening;
            Functie = functie;
            Uren = uren;
            Startloon = startloon;
            BijdragenSocialeZekerheid = bijdragenSocialeZekerheid;
            Bedrijfswagen = bedrijfswagen;
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
        public virtual double Ancienniteit()
        {
            int AantalJarenDienst = AncienniteitJaren();
            double Loon = StartloonNaUren();
            
            for (int i = 0; i < AantalJarenDienst; i++)
            {
                Loon *= 1.1;
            }           
            return Loon;
        }
        public double SocialeZekerheid()
        {
            double loonMinSocZek = Ancienniteit() - BijdragenSocialeZekerheid;
            return loonMinSocZek;
        }
        public virtual double Bedrijfsvoorheffing()
        {
            double BedrijfsvoorheffingLoon = SocialeZekerheid() - (SocialeZekerheid() * 0.1368);
            return BedrijfsvoorheffingLoon;
        }
        public virtual double AncienniteitVerschil()
        {
            double ancienniteit = Ancienniteit() - StartloonNaUren();
            return ancienniteit;
        }
        public double BedrijfsvoorheffingVerschil()
        {
            double bedrijfsvoorheffing = SocialeZekerheid() - Bedrijfsvoorheffing();
            return bedrijfsvoorheffing;
        }
        public virtual double Extras()
        {
            double nettoLoon = Bedrijfsvoorheffing();
            return nettoLoon;
        }
        public virtual string BedrijfswagenString()
        {
            return "";
        }
        public virtual string Support()
        {
            return "";
        }
        public virtual string CostumerSupport()
        {
            return "";
        }
        public void Loonstroken(string Folder, string devider)
        {
            double startloon = Math.Round(StartloonNaUren(), 2);
            double ancienniteit = Math.Round(AncienniteitVerschil(), 2);            
            double LoonPlusAncienniteit = Math.Round(Ancienniteit(), 2);
            double loonMinSocialezekerheid = Math.Round(SocialeZekerheid(), 2);
            double bedragBedrijfsvoorheffing = Math.Round(BedrijfsvoorheffingVerschil(), 2);
            double loonMinBedrijfsvoorheffing = Math.Round(Bedrijfsvoorheffing(), 2);
            double nettoLoon = Math.Round(Extras(), 2);           
            string bestandnaamLoonstrook = $"LOONBRIEF  {Naam} {Rijksregisternummer} {DateTime.Now.ToString("MM-yyyy")}.txt";            
            using (StreamWriter writer = new StreamWriter(Folder+bestandnaamLoonstrook))
            {
                writer.WriteLine(devider);
                writer.WriteLine($"LOONBRIEF {DateTime.Now.ToString("MMMM yyyy").ToUpper()}");
                writer.WriteLine(devider);
                writer.WriteLine($"NAAM                     : {Naam}");
                writer.WriteLine($"RIJKSREGISTERNUMMER      : {Rijksregisternummer}");
                writer.WriteLine($"GESLACHT                 : {(Geslacht ? "MAN" : "VROUW")}");
                writer.WriteLine($"GEBOORTEDATUM            : {GeboorteDatum.ToShortDateString()}");
                writer.WriteLine($"DATUM INDIENSTTREDING    : {DatumIntreding.ToShortDateString()}");
                writer.WriteLine($"FUNCTIE                  : {Functie.ToUpper()}");
                writer.WriteLine($"AANTAL GEPRESTEERDE UREN : {Uren}/38");
                if (BedrijfswagenString() != "")
                { writer.WriteLine($"BEDRIJFSWAGEN            : {(Bedrijfswagen ? "Ja" : "Nee")}"); }
                writer.WriteLine(devider);
                writer.WriteLine($"STARTLOON                :   €{CijferPrinterRechts(startloon)}");
                writer.WriteLine($"ANCIËNNITEIT             : + €{CijferPrinterRechts(ancienniteit)}");
                writer.WriteLine($"                             €{CijferPrinterRechts(LoonPlusAncienniteit)}");
                writer.WriteLine($"SOCIALE ZEKERHEID        : - €{CijferPrinterRechts(BijdragenSocialeZekerheid)}");
                writer.WriteLine($"                             €{CijferPrinterRechts(loonMinSocialezekerheid)}");
                writer.WriteLine($"BEDRIJFSVOORHEFFING      : - €{CijferPrinterRechts(bedragBedrijfsvoorheffing)}");
                writer.WriteLine($"                             €{CijferPrinterRechts(loonMinBedrijfsvoorheffing)}");
                if (Support() != "")
                { 
                    writer.WriteLine($"BONUS THUIS WERKEN       : + €{CijferPrinterRechts(50.00)}");
                    if (CostumerSupport() != "")
                    { writer.WriteLine($"TERUGBETAALING OPLEIDING : + €{CijferPrinterRechts(19.50)}"); }                   
                }
                
                writer.WriteLine($"NETTOLOON                :   €{CijferPrinterRechts(nettoLoon)}");
                writer.WriteLine(devider);
            }

        }
        public string CijferPrinterRechts(double getal)
        {
            string getalWeergave = getal.ToString("0.00");
            string gelijkstellenGettallen = string.Format("{0,10}", getalWeergave);
            return gelijkstellenGettallen;
        }
        public virtual double Recap()
        {
            double recap = Ancienniteit();
            return recap;
        }
    }
}
