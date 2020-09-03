namespace _31_08_2020_ma___4_09_2020_vr_projectweek_yannick
{
    partial class WerknemerInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mtbRijksregister = new System.Windows.Forms.MaskedTextBox();
            this.mtbRekeningNummer = new System.Windows.Forms.MaskedTextBox();
            this.dtpGeboorteDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumIntreding = new System.Windows.Forms.DateTimePicker();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbFunctie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudUren = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.gbBedrijfswagen = new System.Windows.Forms.GroupBox();
            this.rbBedrijfswagenNee = new System.Windows.Forms.RadioButton();
            this.rbBedrijfswagenJa = new System.Windows.Forms.RadioButton();
            this.epText = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbGeslacht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUren)).BeginInit();
            this.gbBedrijfswagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epText)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbRijksregister
            // 
            this.mtbRijksregister.Location = new System.Drawing.Point(106, 434);
            this.mtbRijksregister.Mask = "000000-00-00";
            this.mtbRijksregister.Name = "mtbRijksregister";
            this.mtbRijksregister.Size = new System.Drawing.Size(114, 26);
            this.mtbRijksregister.TabIndex = 7;
            this.mtbRijksregister.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbRijksregister_MaskInputRejected);
            // 
            // mtbRekeningNummer
            // 
            this.mtbRekeningNummer.Location = new System.Drawing.Point(106, 629);
            this.mtbRekeningNummer.Mask = "BE00 0000 0000 0000";
            this.mtbRekeningNummer.Name = "mtbRekeningNummer";
            this.mtbRekeningNummer.Size = new System.Drawing.Size(186, 26);
            this.mtbRekeningNummer.TabIndex = 9;
            this.mtbRekeningNummer.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbRekeningNummer_MaskInputRejected);
            // 
            // dtpGeboorteDatum
            // 
            this.dtpGeboorteDatum.Location = new System.Drawing.Point(106, 352);
            this.dtpGeboorteDatum.Name = "dtpGeboorteDatum";
            this.dtpGeboorteDatum.Size = new System.Drawing.Size(200, 26);
            this.dtpGeboorteDatum.TabIndex = 6;
            this.dtpGeboorteDatum.ValueChanged += new System.EventHandler(this.dtpGeboorteDatum_ValueChanged);
            // 
            // dtpDatumIntreding
            // 
            this.dtpDatumIntreding.Location = new System.Drawing.Point(106, 539);
            this.dtpDatumIntreding.Name = "dtpDatumIntreding";
            this.dtpDatumIntreding.Size = new System.Drawing.Size(200, 26);
            this.dtpDatumIntreding.TabIndex = 8;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(106, 52);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 26);
            this.tbNaam.TabIndex = 1;
            this.tbNaam.TextChanged += new System.EventHandler(this.tbNaam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "geboortedatum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "rijksregisternummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "datum van indiensttreding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "IBAN";
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.Controls.Add(this.rbVrouw);
            this.gbGeslacht.Controls.Add(this.rbMan);
            this.gbGeslacht.Location = new System.Drawing.Point(106, 177);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(200, 124);
            this.gbGeslacht.TabIndex = 4;
            this.gbGeslacht.TabStop = false;
            this.gbGeslacht.Text = "geslacht";
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Location = new System.Drawing.Point(29, 78);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(79, 24);
            this.rbVrouw.TabIndex = 5;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Checked = true;
            this.rbMan.Location = new System.Drawing.Point(29, 38);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(65, 24);
            this.rbMan.TabIndex = 4;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Location = new System.Drawing.Point(106, 697);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(186, 51);
            this.btnAddEdit.TabIndex = 12;
            this.btnAddEdit.Text = "Opslaan";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 788);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(186, 51);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "anuleeren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbFunctie
            // 
            this.cbFunctie.FormattingEnabled = true;
            this.cbFunctie.Items.AddRange(new object[] {
            "PROGRAMMEUR",
            "IT SUPPORT",
            "COSTUMER SUPPORT",
            "BALIEMEDEWERKER",
            "KUISPLOEG"});
            this.cbFunctie.Location = new System.Drawing.Point(106, 124);
            this.cbFunctie.Name = "cbFunctie";
            this.cbFunctie.Size = new System.Drawing.Size(121, 28);
            this.cbFunctie.TabIndex = 2;
            this.cbFunctie.SelectedIndexChanged += new System.EventHandler(this.cbFunctie_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "functie";
            // 
            // nudUren
            // 
            this.nudUren.Location = new System.Drawing.Point(281, 126);
            this.nudUren.Maximum = new decimal(new int[] {
            38,
            0,
            0,
            0});
            this.nudUren.Name = "nudUren";
            this.nudUren.Size = new System.Drawing.Size(120, 26);
            this.nudUren.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "aantal uren";
            // 
            // gbBedrijfswagen
            // 
            this.gbBedrijfswagen.Controls.Add(this.rbBedrijfswagenNee);
            this.gbBedrijfswagen.Controls.Add(this.rbBedrijfswagenJa);
            this.gbBedrijfswagen.Location = new System.Drawing.Point(408, 177);
            this.gbBedrijfswagen.Name = "gbBedrijfswagen";
            this.gbBedrijfswagen.Size = new System.Drawing.Size(200, 124);
            this.gbBedrijfswagen.TabIndex = 10;
            this.gbBedrijfswagen.TabStop = false;
            this.gbBedrijfswagen.Text = "bedrijfswagen";
            this.gbBedrijfswagen.Visible = false;
            // 
            // rbBedrijfswagenNee
            // 
            this.rbBedrijfswagenNee.AutoSize = true;
            this.rbBedrijfswagenNee.Location = new System.Drawing.Point(29, 78);
            this.rbBedrijfswagenNee.Name = "rbBedrijfswagenNee";
            this.rbBedrijfswagenNee.Size = new System.Drawing.Size(63, 24);
            this.rbBedrijfswagenNee.TabIndex = 11;
            this.rbBedrijfswagenNee.Text = "Nee";
            this.rbBedrijfswagenNee.UseVisualStyleBackColor = true;
            // 
            // rbBedrijfswagenJa
            // 
            this.rbBedrijfswagenJa.AutoSize = true;
            this.rbBedrijfswagenJa.Checked = true;
            this.rbBedrijfswagenJa.Location = new System.Drawing.Point(29, 38);
            this.rbBedrijfswagenJa.Name = "rbBedrijfswagenJa";
            this.rbBedrijfswagenJa.Size = new System.Drawing.Size(51, 24);
            this.rbBedrijfswagenJa.TabIndex = 10;
            this.rbBedrijfswagenJa.TabStop = true;
            this.rbBedrijfswagenJa.Text = "Ja";
            this.rbBedrijfswagenJa.UseVisualStyleBackColor = true;
            // 
            // epText
            // 
            this.epText.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epText.ContainerControl = this;
            // 
            // WerknemerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 920);
            this.Controls.Add(this.gbBedrijfswagen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudUren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFunctie);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.gbGeslacht);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.dtpDatumIntreding);
            this.Controls.Add(this.dtpGeboorteDatum);
            this.Controls.Add(this.mtbRekeningNummer);
            this.Controls.Add(this.mtbRijksregister);
            this.Name = "WerknemerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WerknemerInfo";
            this.Load += new System.EventHandler(this.WerknemerInfo_Load);
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUren)).EndInit();
            this.gbBedrijfswagen.ResumeLayout(false);
            this.gbBedrijfswagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbRijksregister;
        private System.Windows.Forms.MaskedTextBox mtbRekeningNummer;
        private System.Windows.Forms.DateTimePicker dtpGeboorteDatum;
        private System.Windows.Forms.DateTimePicker dtpDatumIntreding;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbFunctie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudUren;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbBedrijfswagen;
        private System.Windows.Forms.RadioButton rbBedrijfswagenNee;
        private System.Windows.Forms.RadioButton rbBedrijfswagenJa;
        private System.Windows.Forms.ErrorProvider epText;
    }
}