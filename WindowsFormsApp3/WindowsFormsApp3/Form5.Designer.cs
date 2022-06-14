
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    partial class Form5
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
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text5 = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.Label();
            this.dateRdv = new System.Windows.Forms.DateTimePicker();
            this.codeP = new System.Windows.Forms.TextBox();
            this.nomP = new System.Windows.Forms.TextBox();
            this.nomM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ajouterRDV = new System.Windows.Forms.Button();
            this.nouveau = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.prenom = new System.Windows.Forms.TextBox();
            this.prenom1 = new System.Windows.Forms.Label();
            this.prenomP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.heureRdv = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(208, 79);
            this.text1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(83, 17);
            this.text1.TabIndex = 0;
            this.text1.Text = "Code Patient";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.BackColor = System.Drawing.Color.Transparent;
            this.text2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(208, 121);
            this.text2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(81, 17);
            this.text2.TabIndex = 1;
            this.text2.Text = "Nom Patient";
            // 
            // text5
            // 
            this.text5.AutoSize = true;
            this.text5.BackColor = System.Drawing.Color.Transparent;
            this.text5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text5.Location = new System.Drawing.Point(208, 267);
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
            this.text4.Location = new System.Drawing.Point(208, 219);
            this.text4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(64, 17);
            this.text4.TabIndex = 5;
            this.text4.Text = "Date RDV";
            // 
            // dateRdv
            // 
            this.dateRdv.Location = new System.Drawing.Point(309, 218);
            this.dateRdv.Margin = new System.Windows.Forms.Padding(2);
            this.dateRdv.Name = "dateRdv";
            this.dateRdv.Size = new System.Drawing.Size(111, 20);
            this.dateRdv.TabIndex = 7;
            // 
            // codeP
            // 
            this.codeP.Location = new System.Drawing.Point(309, 78);
            this.codeP.Margin = new System.Windows.Forms.Padding(2);
            this.codeP.Name = "codeP";
            this.codeP.Size = new System.Drawing.Size(100, 20);
            this.codeP.TabIndex = 9;
            // 
            // nomP
            // 
            this.nomP.Location = new System.Drawing.Point(309, 120);
            this.nomP.Margin = new System.Windows.Forms.Padding(2);
            this.nomP.Name = "nomP";
            this.nomP.Size = new System.Drawing.Size(100, 20);
            this.nomP.TabIndex = 10;
            // 
            // nomM
            // 
            this.nomM.Enabled = false;
            this.nomM.Location = new System.Drawing.Point(578, 119);
            this.nomM.Margin = new System.Windows.Forms.Padding(2);
            this.nomM.Name = "nomM";
            this.nomM.Size = new System.Drawing.Size(100, 20);
            this.nomM.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom Medecin";
            // 
            // codeM
            // 
            this.codeM.Enabled = false;
            this.codeM.Location = new System.Drawing.Point(578, 78);
            this.codeM.Margin = new System.Windows.Forms.Padding(2);
            this.codeM.Name = "codeM";
            this.codeM.Size = new System.Drawing.Size(100, 20);
            this.codeM.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Code Medecin";
            // 
            // ajouterRDV
            // 
            this.ajouterRDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.ajouterRDV.FlatAppearance.BorderSize = 0;
            this.ajouterRDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouterRDV.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterRDV.ForeColor = System.Drawing.Color.Maroon;
            this.ajouterRDV.Location = new System.Drawing.Point(461, 206);
            this.ajouterRDV.Margin = new System.Windows.Forms.Padding(2);
            this.ajouterRDV.Name = "ajouterRDV";
            this.ajouterRDV.Size = new System.Drawing.Size(208, 29);
            this.ajouterRDV.TabIndex = 17;
            this.ajouterRDV.Text = "Ajouter RDV";
            this.ajouterRDV.UseVisualStyleBackColor = false;
            this.ajouterRDV.Click += new System.EventHandler(this.ajouterRDV_Click);
            // 
            // nouveau
            // 
            this.nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(228)))), ((int)(((byte)(199)))));
            this.nouveau.FlatAppearance.BorderSize = 0;
            this.nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveau.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.Location = new System.Drawing.Point(461, 255);
            this.nouveau.Margin = new System.Windows.Forms.Padding(2);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(98, 29);
            this.nouveau.TabIndex = 18;
            this.nouveau.Text = "Nouveau";
            this.nouveau.UseVisualStyleBackColor = false;
            // 
            // quitter
            // 
            this.quitter.FlatAppearance.BorderSize = 0;
            this.quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitter.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter.Location = new System.Drawing.Point(578, 255);
            this.quitter.Margin = new System.Windows.Forms.Padding(2);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(92, 29);
            this.quitter.TabIndex = 19;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            // 
            // prenom
            // 
            this.prenom.Enabled = false;
            this.prenom.Location = new System.Drawing.Point(578, 160);
            this.prenom.Margin = new System.Windows.Forms.Padding(2);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 20);
            this.prenom.TabIndex = 21;
            // 
            // prenom1
            // 
            this.prenom1.AutoSize = true;
            this.prenom1.BackColor = System.Drawing.Color.Transparent;
            this.prenom1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom1.Location = new System.Drawing.Point(466, 161);
            this.prenom1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prenom1.Name = "prenom1";
            this.prenom1.Size = new System.Drawing.Size(108, 17);
            this.prenom1.TabIndex = 20;
            this.prenom1.Text = "Prénom Medecin";
            // 
            // prenomP
            // 
            this.prenomP.Location = new System.Drawing.Point(320, 162);
            this.prenomP.Margin = new System.Windows.Forms.Padding(2);
            this.prenomP.Name = "prenomP";
            this.prenomP.Size = new System.Drawing.Size(100, 20);
            this.prenomP.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Prénom patient";
            // 
            // heureRdv
            // 
            this.heureRdv.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.heureRdv.Location = new System.Drawing.Point(298, 264);
            this.heureRdv.Margin = new System.Windows.Forms.Padding(2);
            this.heureRdv.Name = "heureRdv";
            this.heureRdv.Size = new System.Drawing.Size(111, 20);
            this.heureRdv.TabIndex = 24;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.offre_emploi_medecine__3_;
            this.ClientSize = new System.Drawing.Size(720, 370);
            this.Controls.Add(this.heureRdv);
            this.Controls.Add(this.prenomP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.prenom1);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.ajouterRDV);
            this.Controls.Add(this.codeM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomP);
            this.Controls.Add(this.codeP);
            this.Controls.Add(this.dateRdv);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text5;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.DateTimePicker dateRdv;
        private System.Windows.Forms.TextBox codeP;
        private System.Windows.Forms.TextBox nomP;
        private System.Windows.Forms.TextBox nomM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ajouterRDV;
        private System.Windows.Forms.Button nouveau;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label prenom1;
        private System.Windows.Forms.TextBox prenomP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker heureRdv;
       
    }
}