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

            Programmeur newWerknemer = new Programmeur("PIETER JANSSENS", true, new DateTime(1991, 01, 12), "910112-189-31", new DateTime(2018, 07, 18), "BE## #### #### ####", 38, true);
            WerknemersBedrijf.Add(newWerknemer);
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
                    writer.WriteLine(werknemer.Naam.PadRight(30, ' ') +": + €"+ werknemer.CijferPrinterRechts(Math.Round(werknemer.Recap(),2)));
                }
                writer.WriteLine(devider);
                writer.WriteLine("TOTAAL".PadRight(30, ' ') + ": €  " + WerknemersBedrijf[0].CijferPrinterRechts(Math.Round(totaal, 2)));
            }
        }

        private void btnAfdrukken_Click(object sender, EventArgs e)
        {
            FolderMakenPlusLoonstrokenAfdrukkenPlusRecap();
        }
    }
}
