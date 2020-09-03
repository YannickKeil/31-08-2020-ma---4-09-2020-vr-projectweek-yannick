namespace _31_08_2020_ma___4_09_2020_vr_projectweek_yannick
{
    partial class Form1
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
            this.btnAfdrukken = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbWerknemers = new System.Windows.Forms.ListBox();
            this.lGeslacht = new System.Windows.Forms.Label();
            this.lRijksregisternummer = new System.Windows.Forms.Label();
            this.lDatumIntreding = new System.Windows.Forms.Label();
            this.lGeboorteDatum = new System.Windows.Forms.Label();
            this.lRekeningNummer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lFunctie = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAfdrukken
            // 
            this.btnAfdrukken.Location = new System.Drawing.Point(50, 441);
            this.btnAfdrukken.Name = "btnAfdrukken";
            this.btnAfdrukken.Size = new System.Drawing.Size(143, 82);
            this.btnAfdrukken.TabIndex = 1;
            this.btnAfdrukken.Text = "Afdrukken";
            this.btnAfdrukken.UseVisualStyleBackColor = true;
            this.btnAfdrukken.Click += new System.EventHandler(this.btnAfdrukken_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(512, 231);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 82);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "aanpassen";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(512, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 82);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(512, 441);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 82);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "verwijderen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lbWerknemers
            // 
            this.lbWerknemers.FormattingEnabled = true;
            this.lbWerknemers.ItemHeight = 20;
            this.lbWerknemers.Location = new System.Drawing.Point(50, 38);
            this.lbWerknemers.Name = "lbWerknemers";
            this.lbWerknemers.Size = new System.Drawing.Size(193, 364);
            this.lbWerknemers.TabIndex = 6;
            this.lbWerknemers.SelectedIndexChanged += new System.EventHandler(this.lbWerknemers_SelectedIndexChanged);
            // 
            // lGeslacht
            // 
            this.lGeslacht.AutoSize = true;
            this.lGeslacht.Location = new System.Drawing.Point(288, 131);
            this.lGeslacht.Name = "lGeslacht";
            this.lGeslacht.Size = new System.Drawing.Size(69, 20);
            this.lGeslacht.TabIndex = 8;
            this.lGeslacht.Text = "geslacht";
            // 
            // lRijksregisternummer
            // 
            this.lRijksregisternummer.AutoSize = true;
            this.lRijksregisternummer.Location = new System.Drawing.Point(288, 262);
            this.lRijksregisternummer.Name = "lRijksregisternummer";
            this.lRijksregisternummer.Size = new System.Drawing.Size(147, 20);
            this.lRijksregisternummer.TabIndex = 9;
            this.lRijksregisternummer.Text = "rijksregisternummer";
            // 
            // lDatumIntreding
            // 
            this.lDatumIntreding.AutoSize = true;
            this.lDatumIntreding.Location = new System.Drawing.Point(288, 326);
            this.lDatumIntreding.Name = "lDatumIntreding";
            this.lDatumIntreding.Size = new System.Drawing.Size(121, 20);
            this.lDatumIntreding.TabIndex = 10;
            this.lDatumIntreding.Text = "Datum Intreden";
            // 
            // lGeboorteDatum
            // 
            this.lGeboorteDatum.AutoSize = true;
            this.lGeboorteDatum.Location = new System.Drawing.Point(288, 195);
            this.lGeboorteDatum.Name = "lGeboorteDatum";
            this.lGeboorteDatum.Size = new System.Drawing.Size(129, 20);
            this.lGeboorteDatum.TabIndex = 11;
            this.lGeboorteDatum.Text = "Geboorte Datum";
            // 
            // lRekeningNummer
            // 
            this.lRekeningNummer.AutoSize = true;
            this.lRekeningNummer.Location = new System.Drawing.Point(288, 389);
            this.lRekeningNummer.Name = "lRekeningNummer";
            this.lRekeningNummer.Size = new System.Drawing.Size(47, 20);
            this.lRekeningNummer.TabIndex = 12;
            this.lRekeningNummer.Text = "IBAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "geslacht";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Geboorte Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "rijksregisternummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Datum Intreden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "IBAN";
            // 
            // lFunctie
            // 
            this.lFunctie.AutoSize = true;
            this.lFunctie.Location = new System.Drawing.Point(288, 70);
            this.lFunctie.Name = "lFunctie";
            this.lFunctie.Size = new System.Drawing.Size(57, 20);
            this.lFunctie.TabIndex = 18;
            this.lFunctie.Text = "functie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Functie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 535);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lFunctie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lRekeningNummer);
            this.Controls.Add(this.lGeboorteDatum);
            this.Controls.Add(this.lDatumIntreding);
            this.Controls.Add(this.lRijksregisternummer);
            this.Controls.Add(this.lGeslacht);
            this.Controls.Add(this.lbWerknemers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAfdrukken);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAfdrukken;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbWerknemers;
        private System.Windows.Forms.Label lGeslacht;
        private System.Windows.Forms.Label lRijksregisternummer;
        private System.Windows.Forms.Label lDatumIntreding;
        private System.Windows.Forms.Label lGeboorteDatum;
        private System.Windows.Forms.Label lRekeningNummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lFunctie;
        private System.Windows.Forms.Label label7;
    }
}

