using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_08_2020_ma___4_09_2020_vr_projectweek_yannick
{
    public partial class WerknemerInfo : Form
    {
        public WerknemerInfo()
        {
            InitializeComponent();
        }
        public string naam;
        public string functie;
        public bool geslacht;
        public DateTime geboortedatum;
        public string rijksregisternummer;
        public DateTime datumIntreding;
        public string rekeningnummer;
        public int uren;
        public bool bedrijfswagen;
        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (tbNaam.Text == "")
            {
                epText.SetError(tbNaam, "Geen tekst ingevuld!");
            }
            if (mtbRijksregister.Text == "")
            {
                epText.SetError(mtbRijksregister, "Geen tekst ingevuld!");
            }
            if (mtbRekeningNummer.Text == "")
            {
                epText.SetError(mtbRekeningNummer, "Geen tekst ingevuld!");
            }
            if (DateTime.Now.Year - dtpGeboorteDatum.Value.Year >= 18 && DateTime.Now.Month > dtpGeboorteDatum.Value.Month)
            {
                epText.SetError(mtbRekeningNummer, "geboortedatum foutief ingevult");
            }
            else 
            {
                naam = tbNaam.Text;
                functie = cbFunctie.Text;
                if (rbMan.Checked)
                { geslacht = true; }
                else if (rbVrouw.Checked)
                { geslacht = false; }
                geboortedatum = dtpGeboorteDatum.Value;
                rijksregisternummer = mtbRijksregister.Text;
                datumIntreding = dtpDatumIntreding.Value;
                rekeningnummer = mtbRekeningNummer.Text;
                uren = Convert.ToInt32(nudUren.Value);
                if(rbBedrijfswagenJa.Checked)
                { bedrijfswagen = true; }
                else 
                { bedrijfswagen = false; }
                this.DialogResult = DialogResult.OK;
                epText.Clear();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void WerknemerInfo_Load(object sender, EventArgs e)
        {
            cbFunctie.SelectedIndex = 0;
        }

        private void tbNaam_TextChanged(object sender, EventArgs e)
        {
            if (tbNaam.Text == "")
            {
                epText.SetError(tbNaam, "Geen tekst ingevuld!");
            }
            else
            {
                epText.Clear();
            }
        }

        private void mtbRijksregister_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbRijksregister.Text == "")
            {
                epText.SetError(mtbRijksregister, "Geen tekst ingevuld!");
            }
            else
            {
                epText.Clear();
            }
        }

        private void mtbRekeningNummer_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbRekeningNummer.Text == "")
            {
                epText.SetError(mtbRekeningNummer, "Geen tekst ingevuld!");
            }
            else
            {
                epText.Clear();
            }
        }

        private void dtpGeboorteDatum_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - dtpGeboorteDatum.Value.Year >= 18 && DateTime.Now.Month > dtpGeboorteDatum.Value.Month)
            {
                epText.SetError(mtbRekeningNummer, "geboortedatum foutief ingevult ");
            }
            else
            {
                epText.Clear();
            }
        }

        private void cbFunctie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFunctie.Text == "PROGRAMMEUR")
            {
                gbBedrijfswagen.Visible = true;
            }
            else 
            {
                gbBedrijfswagen.Visible = false;
            }
        }
    }
}
