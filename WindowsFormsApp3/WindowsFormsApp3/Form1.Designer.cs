
namespace WindowsFormsApp3
{
  partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bienvenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ville = new MetroFramework.Controls.MetroComboBox();
            this.t = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.afficher = new System.Windows.Forms.CheckBox();
            this.mdp = new System.Windows.Forms.TextBox();
            this.mdpc = new System.Windows.Forms.TextBox();
            this.tel1 = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.specialite = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // Bienvenu
            // 
            this.Bienvenu.AutoSize = true;
            this.Bienvenu.BackColor = System.Drawing.Color.Transparent;
            this.Bienvenu.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenu.ForeColor = System.Drawing.Color.Black;
            this.Bienvenu.Location = new System.Drawing.Point(221, 32);
            this.Bienvenu.Name = "Bienvenu";
            this.Bienvenu.Size = new System.Drawing.Size(133, 27);
            this.Bienvenu.TabIndex = 1;
            this.Bienvenu.Text = "Bienvenu!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(318, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prénom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.Black;
            this.s.Location = new System.Drawing.Point(19, 160);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(85, 21);
            this.s.TabIndex = 6;
            this.s.Text = "Spécialité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(320, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ville";
            // 
            // Ville
            // 
            this.Ville.FormattingEnabled = true;
            this.Ville.ItemHeight = 23;
            this.Ville.Items.AddRange(new object[] {
            "Agadir, 346 106 hab (2008)",
            "Azrou , 57 932 hab (2004)",
            "Aklim, 8 969 hab (2004)",
            "Ahfir, 19 482 hab (2008) * Ain leuh , 12 163 hab (2004)",
            "Ain Dorij, 2 321 hab (2004)",
            "Ain Jemaa, 2 610 hab (2004)",
            "Ait Benhaddou, site classé au patrimoine mondial de l\'Unesco",
            "Ain Bni Mathar, 13 526 hab (2004)",
            "Ain Cheggag, 4 436 hab (2004)",
            "Ain Defali",
            "Ain El Aouda, 25 105 hab (2004)",
            "Ain Erreggada, 2 983 hab (2004)",
            "Ain Taoujdate, 22 030 hab (2004)",
            "Ait Boubidmane, 4 258 hab (2004)",
            "Ait Bouhlal",
            "Ait Daoud",
            "Ait Iaaza",
            "Ait Ourir",
            "Ajdir",
            "Al Aaroui",
            "Al-Hoceima",
            "Amalou Ighriben",
            "Amgala",
            "Amizmiz",
            "Aoufous",
            "Arbaoua",
            "Arfoud ",
            "Asilah",
            "Assahrij"});
            this.Ville.Location = new System.Drawing.Point(324, 184);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(190, 29);
            this.Ville.TabIndex = 9;
            this.Ville.UseSelectable = true;
            // 
            // t
            // 
            this.t.FormattingEnabled = true;
            this.t.ItemHeight = 23;
            this.t.Items.AddRange(new object[] {
            "Algérie",
            "Allemagne",
            "Bahreïn",
            "Belgique",
            "Brésil",
            "Corée du Sud",
            "Danemark",
            "Djibouti",
            "Finlande",
            "France",
            "Hong Kong",
            "Hongrie",
            "Inde",
            "Indonésie",
            "Irak",
            "Irland",
            "Italie",
            "Kenya",
            "Koweit",
            "Liban",
            "Luxembourg",
            "Maroc",
            "Mexique",
            "Oman",
            "",
            ""});
            this.t.Location = new System.Drawing.Point(25, 263);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(79, 29);
            this.t.TabIndex = 11;
            this.t.UseSelectable = true;
            this.t.SelectedIndexChanged += new System.EventHandler(this.t_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Téléphone";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(210, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "S\'INSCRIRE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(210, 474);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(318, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mot de passe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(320, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Confirmer de mot de passe";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(319, 111);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(215, 25);
            this.prenom.TabIndex = 21;
            // 
            // afficher
            // 
            this.afficher.AutoSize = true;
            this.afficher.BackColor = System.Drawing.Color.Transparent;
            this.afficher.ForeColor = System.Drawing.Color.Black;
            this.afficher.Location = new System.Drawing.Point(214, 374);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(153, 21);
            this.afficher.TabIndex = 22;
            this.afficher.Text = "Afficher le password";
            this.afficher.UseVisualStyleBackColor = false;
            this.afficher.CheckedChanged += new System.EventHandler(this.afficher_CheckedChanged);
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(25, 334);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(215, 25);
            this.mdp.TabIndex = 23;
            this.mdp.UseSystemPasswordChar = true;
            // 
            // mdpc
            // 
            this.mdpc.Location = new System.Drawing.Point(322, 334);
            this.mdpc.Name = "mdpc";
            this.mdpc.Size = new System.Drawing.Size(215, 25);
            this.mdpc.TabIndex = 24;
            this.mdpc.UseSystemPasswordChar = true;
            // 
            // tel1
            // 
            this.tel1.Location = new System.Drawing.Point(110, 266);
            this.tel1.Name = "tel1";
            this.tel1.Size = new System.Drawing.Size(148, 25);
            this.tel1.TabIndex = 25;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(324, 263);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(190, 25);
            this.adresse.TabIndex = 26;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(25, 111);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(214, 25);
            this.nom.TabIndex = 27;
            // 
            // specialite
            // 
            this.specialite.FormattingEnabled = true;
            this.specialite.ItemHeight = 23;
            this.specialite.Items.AddRange(new object[] {
            "L’anesthésiologie",
            "L’andrologie",
            "La cardiologie",
            "La chirurgie",
            "La dermatologie",
            "L’endocrinologie",
            "La gastro-entérologie",
            "La gériatrie",
            "La gynécologie",
            "L’hématologie",
            "L’hépatologie",
            "L’infectiologie",
            "La médecine générale",
            "La néonatologie",
            "La néphrologie",
            "La neurologie",
            "L’odontologie",
            "L’oncologie",
            "L’obstétrique.",
            "L’ophtalmologie.",
            "L’orthopédie.",
            "L’Oto-rhino-laryngologie.",
            "La pédiatrie.",
            "La pneumologie.",
            "La psychiatrie.",
            "La radiologie.",
            "La radiothérapie.",
            "La rhumatologie",
            "L’urologie"});
            this.specialite.Location = new System.Drawing.Point(29, 189);
            this.specialite.Name = "specialite";
            this.specialite.Size = new System.Drawing.Size(197, 29);
            this.specialite.TabIndex = 28;
            this.specialite.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.offre_emploi_medecine__3_;
            this.ClientSize = new System.Drawing.Size(631, 537);
            this.Controls.Add(this.specialite);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.tel1);
            this.Controls.Add(this.mdpc);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bienvenu);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox Ville;
        private MetroFramework.Controls.MetroComboBox t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.CheckBox afficher;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.TextBox mdpc;
        private System.Windows.Forms.TextBox tel1;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox nom;
        private MetroFramework.Controls.MetroComboBox specialite;
    }
}

