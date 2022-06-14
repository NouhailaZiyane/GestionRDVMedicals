
namespace WindowsFormsApp3
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.text1 = new System.Windows.Forms.Label();
            this.text5 = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.Label();
            this.dateRdv = new System.Windows.Forms.DateTimePicker();
            this.codeP = new System.Windows.Forms.TextBox();
            this.ajouterRDV = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.heureRdv = new MetroFramework.Controls.MetroComboBox();
            this.codeMed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(262, 53);
            this.text1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(83, 17);
            this.text1.TabIndex = 0;
            this.text1.Text = "Code Patient";
            // 
            // text5
            // 
            this.text5.AutoSize = true;
            this.text5.BackColor = System.Drawing.Color.Transparent;
            this.text5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text5.Location = new System.Drawing.Point(262, 169);
            this.text5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(72, 17);
            this.text5.TabIndex = 6;
            this.text5.Text = "Heure RDV";
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.BackColor = System.Drawing.Color.Transparent;
            this.text4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text4.Location = new System.Drawing.Point(262, 121);
            this.text4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(64, 17);
            this.text4.TabIndex = 5;
            this.text4.Text = "Date RDV";
            // 
            // dateRdv
            // 
            this.dateRdv.CustomFormat = "dd/MM/yyyy";
            this.dateRdv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRdv.Location = new System.Drawing.Point(363, 120);
            this.dateRdv.Margin = new System.Windows.Forms.Padding(2);
            this.dateRdv.Name = "dateRdv";
            this.dateRdv.Size = new System.Drawing.Size(111, 20);
            this.dateRdv.TabIndex = 7;
            // 
            // codeP
            // 
            this.codeP.Location = new System.Drawing.Point(363, 52);
            this.codeP.Margin = new System.Windows.Forms.Padding(2);
            this.codeP.Name = "codeP";
            this.codeP.Size = new System.Drawing.Size(100, 20);
            this.codeP.TabIndex = 9;
            // 
            // ajouterRDV
            // 
            this.ajouterRDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.ajouterRDV.FlatAppearance.BorderSize = 0;
            this.ajouterRDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouterRDV.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterRDV.ForeColor = System.Drawing.Color.Black;
            this.ajouterRDV.Location = new System.Drawing.Point(265, 221);
            this.ajouterRDV.Margin = new System.Windows.Forms.Padding(2);
            this.ajouterRDV.Name = "ajouterRDV";
            this.ajouterRDV.Size = new System.Drawing.Size(208, 29);
            this.ajouterRDV.TabIndex = 17;
            this.ajouterRDV.Text = "Ajouter RDV";
            this.ajouterRDV.UseVisualStyleBackColor = false;
            this.ajouterRDV.Click += new System.EventHandler(this.ajouterRDV_Click);
            // 
            // quitter
            // 
            this.quitter.FlatAppearance.BorderSize = 0;
            this.quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitter.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter.Location = new System.Drawing.Point(326, 311);
            this.quitter.Margin = new System.Windows.Forms.Padding(2);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(92, 29);
            this.quitter.TabIndex = 19;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // heureRdv
            // 
            this.heureRdv.FormattingEnabled = true;
            this.heureRdv.ItemHeight = 23;
            this.heureRdv.Items.AddRange(new object[] {
            "08:00-09:00",
            "09:00-10:00",
            "10:00-11:00",
            "11:00-12:00",
            "14:00-15:00",
            "15:00-16:00",
            "16:00-17:00",
            "17:00-18:00"});
            this.heureRdv.Location = new System.Drawing.Point(363, 163);
            this.heureRdv.Name = "heureRdv";
            this.heureRdv.Size = new System.Drawing.Size(106, 29);
            this.heureRdv.TabIndex = 25;
            this.heureRdv.UseSelectable = true;
            // 
            // codeMed
            // 
            this.codeMed.Location = new System.Drawing.Point(363, 85);
            this.codeMed.Margin = new System.Windows.Forms.Padding(2);
            this.codeMed.Name = "codeMed";
            this.codeMed.Size = new System.Drawing.Size(100, 20);
            this.codeMed.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Code Medecin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(266, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 29);
            this.button1.TabIndex = 30;
            this.button1.Text = "CONSULTER LES RDV";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.offre_emploi_medecine__3_;
            this.ClientSize = new System.Drawing.Size(720, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codeMed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heureRdv);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.ajouterRDV);
            this.Controls.Add(this.codeP);
            this.Controls.Add(this.dateRdv);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form13";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text5;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.DateTimePicker dateRdv;
        private System.Windows.Forms.TextBox codeP;
        private System.Windows.Forms.Button ajouterRDV;
        private System.Windows.Forms.Button quitter;
        private MetroFramework.Controls.MetroComboBox heureRdv;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private System.Windows.Forms.TextBox codeMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}