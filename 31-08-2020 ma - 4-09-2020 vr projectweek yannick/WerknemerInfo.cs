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
        public Werknemers Selected { get; set; }
        public WerknemerInfo(Werknemers selected)
        {
            Selected = selected;
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
        public double startLoon;
        

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (tbNaam.Text == "")
            {
                epText.SetError(tbNaam, "Geen tekst ingevuld!");
            }
            else if (!mtbRijksregister.MaskCompleted)
            {
                epText.SetError(mtbRijksregister, "Geen tekst ingevuld!");
            }
            else if (!mtbRekeningNummer.MaskCompleted)
            {
                epText.SetError(mtbRekeningNummer, "Geen tekst ingevuld!");
            }
            else if (DateTime.Now.Year - dtpGeboorteDatum.Value.Year < 18 && DateTime.Now.Month > dtpGeboorteDatum.Value.Month)
            {
                epText.SetError(dtpGeboorteDatum, "geboortedatum foutief ingevult");
            }
            else if (!mtbRijksregister.Text.Contains($"{dtpGeboorteDatum.Value:yy,MM,dd}") && !mtbRijksregister.Text.Contains($"{dtpGeboorteDatum.Value:yy},00,00") && !mtbRijksregister.Text.Contains($"{dtpGeboorteDatum.Value:yy,MM},00") && !mtbRijksregister.Text.Contains($"{dtpGeboorteDatum.Value:yy,00,dd}"))
            { 
                epText.SetError(dtpGeboorteDatum, "geboortedatum of rijsregister foutief ingevult");
                epText.SetError(mtbRijksregister, "geboortedatum of rijsregister foutief ingevult");
            }
            else if (dtpDatumIntreding.Value.Year - dtpGeboorteDatum.Value.Year < 18 && dtpDatumIntreding.Value.Month < dtpGeboorteDatum.Value.Month)
            {
                epText.SetError(dtpGeboorteDatum, "geboortedatum of datum van ndiensttreding  is foutief ingevult");
                epText.SetError(dtpDatumIntreding, "geboortedatum of datum van ndiensttreding  is foutief ingevult");
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
                startLoon = Convert.ToDouble(nudLoon.Value);
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
            if (Selected != null)
            {
                tbNaam.Text = Selected.Naam;
                cbFunctie.Text = Selected.Functie;
                if (Selected.Geslacht)
                {
                    rbMan.Checked = true;
                    rbVrouw.Checked = false;
                }
                else
                {
                    rbMan.Checked = false;
                    rbVrouw.Checked = true;
                }
                dtpGeboorteDatum.Value = Selected.GeboorteDatum;
                mtbRijksregister.Text = Selected.Rijksregisternummer;
                dtpDatumIntreding.Value = Selected.DatumIntreding;
                mtbRekeningNummer.Text = Selected.Bankrekening;
                nudUren.Value = Selected.Uren;
                if (Selected.Bedrijfswagen)
                {
                    rbBedrijfswagenJa.Checked = true;
                    rbBedrijfswagenNee.Checked = false;
                }
                else
                {
                    rbBedrijfswagenJa.Checked = false;
                    rbBedrijfswagenNee.Checked = true;
                }
                nudLoon.Value = Convert.ToDecimal(Selected.Startloon);
            }


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
            if (!mtbRijksregister.MaskCompleted)
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
            if (!mtbRekeningNummer.MaskCompleted)
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
            if (DateTime.Now.Year - dtpGeboorteDatum.Value.Year <= 18 && DateTime.Now.Month - dtpGeboorteDatum.Value.Month > 0)
            {
                epText.SetError(dtpGeboorteDatum, "geboortedatum foutief ingevult ");
            }
            else if (dtpDatumIntreding.Value.Year - dtpGeboorteDatum.Value.Year <= 18 && dtpDatumIntreding.Value.Month < dtpGeboorteDatum.Value.Month)
            {
                epText.SetError(dtpGeboorteDatum, "geboortedatum of datum van ndiensttreding  is foutief ingevult");
                epText.SetError(dtpDatumIntreding, "geboortedatum of datum van ndiensttreding  is foutief ingevult");
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
                nudLoon.Value = Convert.ToDecimal(2200.00);
                nudUren.Value = 38;
                nudUren.Enabled = true;
            }
            else if (cbFunctie.Text == "IT SUPPORT")
            {
                gbBedrijfswagen.Visible = false;
                nudLoon.Value = Convert.ToDecimal(2050.00);
                nudUren.Value = 38;
                nudUren.Enabled = false;
            }
            else if (cbFunctie.Text == "COSTUMER SUPPORT")
            {
                gbBedrijfswagen.Visible = false;
                nudLoon.Value = Convert.ToDecimal(2050.00);
                nudUren.Value = 32;
                nudUren.Enabled = true;
            }
            else
            {
                gbBedrijfswagen.Visible = false;
                nudLoon.Value = Convert.ToDecimal(1900.00);
                nudUren.Value = 25;
                nudUren.Enabled = true;
            }
        }
       

        private void dtpDatumIntreding_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDatumIntreding.Value.Year - dtpGeboorteDatum.Value.Year <= 18 && dtpDatumIntreding.Value.Month < dtpGeboorteDatum.Value.Month)
            {
                epText.SetError(dtpGeboorteDatum, "geboortedatum of datum van ndiensttreding  is foutief ingevult");
                epText.SetError(dtpDatumIntreding, "geboortedatum of datum van ndiensttreding  is foutief ingevult");
            }
            else
            {
                epText.Clear();
            }
        }

        private void cbFunctie_TextUpdate(object sender, EventArgs e)
        {
            if (cbFunctie.Text.ToUpper() == "PROGRAMMEUR")
            {
                gbBedrijfswagen.Visible = true;
                nudLoon.Value = Convert.ToDecimal(2200.00);
                nudUren.Value = 38;
                nudUren.Enabled = true;
            }
            else if (cbFunctie.Text.ToUpper() == "IT SUPPORT")
            {
                gbBedrijfswagen.Visible = false;
                nudLoon.Value = Convert.ToDecimal(2050.00);
                nudUren.Value = 38;
                nudUren.Enabled = false;
            }
            else if (cbFunctie.Text.ToUpper() == "COSTUMER SUPPORT")
            {
                gbBedrijfswagen.Visible = false;
                nudLoon.Value = Convert.ToDecimal(2050.00);
                nudUren.Value = 32;
                nudUren.Enabled = true;
            }
            else
            {
                gbBedrijfswagen.Visible = false;
                nudLoon.Value = Convert.ToDecimal(1900.00);
                nudUren.Value = 25;
                nudUren.Enabled = true;
            }
        }
    }
}
