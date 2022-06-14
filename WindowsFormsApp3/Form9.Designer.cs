
namespace WindowsFormsApp3
{
    partial class Form9
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textadr = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.specialite = new System.Windows.Forms.TextBox();
            this.Prénom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.rDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApp3.Database1DataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msDaterdv = new System.Windows.Forms.DateTimePicker();
            this.button_annuler = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.rDVTableAdapter = new WindowsFormsApp3.Database1DataSet1TableAdapters.RDVTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSet3 = new WindowsFormsApp3.Database1DataSet3();
            this.rDVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rDVTableAdapter1 = new WindowsFormsApp3.Database1DataSet3TableAdapters.RDVTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Liste);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 448);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textadr);
            this.groupBox2.Controls.Add(this.adresse);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.specialite);
            this.groupBox2.Controls.Add(this.Prénom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.prenom);
            this.groupBox2.Controls.Add(this.nom);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(104, 284);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(489, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medecin";
            // 
            // textadr
            // 
            this.textadr.AutoSize = true;
            this.textadr.Location = new System.Drawing.Point(262, 95);
            this.textadr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textadr.Name = "textadr";
            this.textadr.Size = new System.Drawing.Size(60, 17);
            this.textadr.TabIndex = 8;
            this.textadr.Text = "Adresse";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(341, 95);
            this.adresse.Margin = new System.Windows.Forms.Padding(2);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(76, 23);
            this.adresse.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Specialite";
            // 
            // specialite
            // 
            this.specialite.Location = new System.Drawing.Point(105, 92);
            this.specialite.Margin = new System.Windows.Forms.Padding(2);
            this.specialite.Name = "specialite";
            this.specialite.Size = new System.Drawing.Size(76, 23);
            this.specialite.TabIndex = 5;
            this.specialite.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Prénom
            // 
            this.Prénom.AutoSize = true;
            this.Prénom.Location = new System.Drawing.Point(262, 35);
            this.Prénom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Prénom.Name = "Prénom";
            this.Prénom.Size = new System.Drawing.Size(57, 17);
            this.Prénom.TabIndex = 4;
            this.Prénom.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(341, 29);
            this.prenom.Margin = new System.Windows.Forms.Padding(2);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(76, 23);
            this.prenom.TabIndex = 2;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(105, 35);
            this.nom.Margin = new System.Windows.Forms.Padding(2);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(76, 23);
            this.nom.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.AutoGenerateColumns = false;
            this.Liste.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.Liste.DataSource = this.rDVBindingSource1;
            this.Liste.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.Liste.Location = new System.Drawing.Point(94, 133);
            this.Liste.Margin = new System.Windows.Forms.Padding(2);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(458, 127);
            this.Liste.TabIndex = 1;
            this.Liste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellClick);
            // 
            // rDVBindingSource
            // 
            this.rDVBindingSource.DataMember = "RDV";
            this.rDVBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.msDaterdv);
            this.groupBox1.Controls.Add(this.button_annuler);
            this.groupBox1.Controls.Add(this.button_ok);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(45, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(603, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisir la date";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // msDaterdv
            // 
            this.msDaterdv.CustomFormat = "dd/MM/yyyy";
            this.msDaterdv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.msDaterdv.Location = new System.Drawing.Point(18, 27);
            this.msDaterdv.Margin = new System.Windows.Forms.Padding(2);
            this.msDaterdv.Name = "msDaterdv";
            this.msDaterdv.Size = new System.Drawing.Size(153, 26);
            this.msDaterdv.TabIndex = 8;
            this.msDaterdv.ValueChanged += new System.EventHandler(this.msDaterdv_ValueChanged);
            // 
            // button_annuler
            // 
            this.button_annuler.BackColor = System.Drawing.Color.Firebrick;
            this.button_annuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_annuler.Location = new System.Drawing.Point(296, 24);
            this.button_annuler.Margin = new System.Windows.Forms.Padding(2);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(84, 37);
            this.button_annuler.TabIndex = 2;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = false;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.Firebrick;
            this.button_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ok.Location = new System.Drawing.Point(177, 24);
            this.button_ok.Margin = new System.Windows.Forms.Padding(2);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(86, 37);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click_1);
            // 
            // rDVTableAdapter
            // 
            this.rDVTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(400, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ajouter Rendez-vous";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rDVBindingSource1
            // 
            this.rDVBindingSource1.DataMember = "RDV";
            this.rDVBindingSource1.DataSource = this.database1DataSet3;
            // 
            // rDVTableAdapter1
            // 
            this.rDVTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // heureDataGridViewTextBoxColumn
            // 
            this.heureDataGridViewTextBoxColumn.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn.HeaderText = "heure";
            this.heureDataGridViewTextBoxColumn.Name = "heureDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "medecin_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "medecin_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 448);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load_1);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label Prénom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker msDaterdv;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource rDVBindingSource;
        private Database1DataSet1TableAdapters.RDVTableAdapter rDVTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox specialite;
        private System.Windows.Forms.Label textadr;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Button button1;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource rDVBindingSource1;
        private Database1DataSet3TableAdapters.RDVTableAdapter rDVTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}