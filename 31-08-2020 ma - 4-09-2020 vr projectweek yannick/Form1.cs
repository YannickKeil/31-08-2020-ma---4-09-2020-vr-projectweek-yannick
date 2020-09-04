using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_08_2020_ma___4_09_2020_vr_projectweek_yannick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Werknemers> WerknemersBedrijf = new List<Werknemers>();
        private void Form1_Load(object sender, EventArgs e)
        {

            Programmeur newWerknemer = new Programmeur("PIETER JANSSENS", true, new DateTime(1991, 01, 12), "91,01,12-189,31", new DateTime(2018, 07, 18), "BE00 0000 0000 0000", 38, true);
            WerknemersBedrijf.Add(newWerknemer);
            LaadWerknemers();
        }
        private void FolderMakenPlusLoonstrokenAfdrukkenPlusRecap()
        {
            
                double totaal = 0;
                string devider = "----------------------------------------------";
                List<double> BedrijfskostenWerknemers = new List<double>();
                string Folder = Environment.CurrentDirectory + $"\\LOONBRIEVEN {DateTime.Now.ToString("MMMM yyyy")}\\";
                if (!Directory.Exists(Folder))
                {
                    Directory.CreateDirectory(Folder);
                }
                string bestandnaamRecap = $"RECAP {DateTime.Now.ToString("MM-yyyy")}.txt";
                using (StreamWriter writer = new StreamWriter(Folder + bestandnaamRecap))
                {
                    writer.WriteLine(devider);
                    writer.WriteLine($"RECAP {DateTime.Now.ToString("MMMM yyyy").ToUpper()}");
                    writer.WriteLine(devider);
                    writer.WriteLine("NAAM".PadRight(30, ' ') + "BEDRIJFSCOSTEN".PadLeft(15, ' '));
                    writer.WriteLine(devider);
                    foreach (var werknemer in WerknemersBedrijf)
                    {
                        werknemer.Loonstroken(Folder, devider);
                        totaal += werknemer.Recap();
                        writer.WriteLine(werknemer.Naam.PadRight(30, ' ') + ": + €" + werknemer.CijferPrinterRechts(Math.Round(werknemer.Recap(), 2)));
                    }
                    writer.WriteLine(devider);

                    writer.WriteLine("TOTAAL".PadRight(30, ' ') + ": €  " + WerknemersBedrijf[0].CijferPrinterRechts(Math.Round(totaal, 2)));
                }
           
        }
        private void DeleteAllTxtFiles()
        {
            string Folder = Environment.CurrentDirectory + $"\\LOONBRIEVEN {DateTime.Now.ToString("MMMM yyyy")}\\";
            if (!Directory.Exists(Folder))
            {

            }
            else
            {
                string[] files = Directory.GetFiles(Folder);
                
                foreach (string file in files)
                {
                    if (file.Contains($"{ DateTime.Now: MM-yyyy}"))
                    {
                        File.Delete(file);
                        Console.WriteLine($"{file} is deleted.");
                    }
                }
            }
        }
        private void btnAfdrukken_Click(object sender, EventArgs e)
        {
            if (WerknemersBedrijf.Count > 0)
            {
                //DeleteAllTxtFiles(); /*dit is erin voor meerdere tests te kunnen doen zonder oude loonstrookjes manueel te moeten deleten*/
                FolderMakenPlusLoonstrokenAfdrukkenPlusRecap();
            }
            else
            {
                MessageBox.Show("er is niets om af te drukken");
            }
        }
        public void LaadWerknemers()
        {
            lbWerknemers.DataSource = null;
            lbWerknemers.DataSource = WerknemersBedrijf;
            if (lbWerknemers.SelectedItem != null)
            {
                Werknemers selected = (Werknemers)lbWerknemers.SelectedItem;
                lFunctie.Text = selected.Functie;
                lUren.Text = $"{(selected.Uren == 38 ? "Voltijds" : "Deeltijds")} {Convert.ToString(selected.Uren)}/38 uren";
                lGeslacht.Text = $"{(selected.Geslacht ? "MAN" : "VROUW")}";
                lGeboorteDatum.Text = selected.GeboorteDatum.ToString("dd-MM-yyyy");
                lRijksregisternummer.Text = selected.Rijksregisternummer;
                lDatumIntreding.Text = selected.DatumIntreding.ToString("dd-MM-yyyy");
                lRekeningNummer.Text = selected.Bankrekening;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WerknemerInfo werknemerinfo = new WerknemerInfo();
            if (werknemerinfo.ShowDialog() == DialogResult.OK)
            {
                if (werknemerinfo.functie == "PROGRAMMEUR")
                {
                    Programmeur WerknermerToevoegen = new Programmeur(werknemerinfo.naam, werknemerinfo.geslacht, werknemerinfo.geboortedatum, werknemerinfo.rijksregisternummer, werknemerinfo.datumIntreding, werknemerinfo.rekeningnummer, werknemerinfo.uren, werknemerinfo.bedrijfswagen, startloon: werknemerinfo.startLoon);
                    WerknemersBedrijf.Add(WerknermerToevoegen);
                }
                else if (werknemerinfo.functie == "IT SUPPORT")
                {
                    IT_Support WerknermerToevoegen = new IT_Support(werknemerinfo.naam, werknemerinfo.geslacht, werknemerinfo.geboortedatum, werknemerinfo.rijksregisternummer, werknemerinfo.datumIntreding, werknemerinfo.rekeningnummer, startloon: werknemerinfo.startLoon);
                    WerknemersBedrijf.Add(WerknermerToevoegen);
                }
                else if (werknemerinfo.functie == "COSTUMER SUPPORT")
                {
                    Costumer_Support WerknermerToevoegen = new Costumer_Support(werknemerinfo.naam, werknemerinfo.geslacht, werknemerinfo.geboortedatum, werknemerinfo.rijksregisternummer, werknemerinfo.datumIntreding, werknemerinfo.rekeningnummer, werknemerinfo.uren , startloon: werknemerinfo.startLoon);
                    WerknemersBedrijf.Add(WerknermerToevoegen);
                }
                else
                {
                    Werknemers WerknermerToevoegen = new Werknemers(werknemerinfo.naam, werknemerinfo.geslacht, werknemerinfo.geboortedatum, werknemerinfo.rijksregisternummer, werknemerinfo.datumIntreding, werknemerinfo.rekeningnummer,werknemerinfo.functie.ToUpper(), werknemerinfo.uren, startloon: werknemerinfo.startLoon);
                    WerknemersBedrijf.Add(WerknermerToevoegen);
                }
            }
            LaadWerknemers();
        }

        private void lbWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaadWerknemers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Werknemers selected = (Werknemers)lbWerknemers.SelectedItem;
            WerknemerInfo werknemerinfo = new WerknemerInfo(selected);
            if (werknemerinfo.ShowDialog() == DialogResult.OK)
            {
                WerknemersBedrijf.Remove(selected);
                if (werknemerinfo.functie == "PROGRAMMEUR")
                {
                    Programmeur WerknermerToevoegen = new Programmeur(werknemerinfo.naam, werknemerinfo.geslacht, werknemerinfo.geboortedatum, werknemerinfo.rijksregisternummer, werknemerinfo.datumIntreding, werknemerinfo.rekeningnummer, werknemerinfo.uren, werknemerinfo.bedrijfswagen, startloon: werknemerinfo.startLoon);
                    WerknemersBedrijf.Add(WerknermerToevoegen);
                }
                else if (werknemerinfo.functie == "IT SUPPORT")
                {
                    IT_Support WerknermerToevoegen = new IT_Support(werknemerinfo.naam, werknemerinfo.geslacht, werknemerinfo.geboortedatum, werknemerinfo.rijksregisternummer, werknemerinfo.datumIntreding, werknemerinfo.rekeningnummer, startloon: werknemerinfo.startLoon);
                    WerknemersBedrijf.Add(WerknermerToevoegen);
                }
                else if (werknemerinfo.functie == "COSTUMER SUPPORT")
                {
                    Costumer_Support WerknermerToevoegen = new Costumer_Support(werknemerinfo.naam, werknemerinfo.geslacht, werknemerinfo.geboortedatum, werknemerinfo.rijksregisternummer, werknemerinfo.datumIntreding, werknemerinfo.rekeningnummer, werknemerinfo.uren, startloon: werknemerinfo.startLoon);
                    WerknemersBedrijf.Add(WerknermerToevoegen);
                }
                else
                {
                    Werknemers WerknermerToevoegen = new Werknemers(werknemerinfo.naam, werknemerinfo.geslacht, werknemerinfo.geboortedatum, werknemerinfo.rijksregisternummer, werknemerinfo.datumIntreding, werknemerinfo.rekeningnummer, werknemerinfo.functie.ToUpper(), werknemerinfo.uren, startloon: werknemerinfo.startLoon);
                    WerknemersBedrijf.Add(WerknermerToevoegen);
                }
            }
            LaadWerknemers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Werknemers selected = (Werknemers)lbWerknemers.SelectedItem;
            WerknemersBedrijf.Remove(selected);
            LaadWerknemers();
        }
    }
}
