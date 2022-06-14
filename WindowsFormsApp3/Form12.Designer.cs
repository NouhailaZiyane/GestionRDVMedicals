
namespace WindowsFormsApp3
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.Liste = new System.Windows.Forms.DataGridView();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp3.Database1DataSet();
            this.medecinTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.MedecinTableAdapter();
            this.choix1 = new MetroFramework.Controls.MetroComboBox();
            this.choix = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.database1DataSet4 = new WindowsFormsApp3.Database1DataSet4();
            this.secretaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secretaireTableAdapter = new WindowsFormsApp3.Database1DataSet4TableAdapters.secretaireTableAdapter();
            this.database1DataSet5 = new WindowsFormsApp3.Database1DataSet5();
            this.rDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDVTableAdapter = new WindowsFormsApp3.Database1DataSet5TableAdapters.RDVTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msheurerdv = new MetroFramework.Controls.MetroComboBox();
            this.dpdaterdv = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textnumrdv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hide = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.AutoGenerateColumns = false;
            this.Liste.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.date,
            this.heure,
            this.medecin_id,
            this.patient_id});
            this.Liste.DataSource = this.rDVBindingSource;
            this.Liste.GridColor = System.Drawing.Color.MediumTurquoise;
            this.Liste.Location = new System.Drawing.Point(167, 142);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(545, 152);
            this.Liste.TabIndex = 0;
            this.Liste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellClick);
            // 
            // medecinBindingSource
            // 
            this.medecinBindingSource.DataMember = "Medecin";
            this.medecinBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medecinTableAdapter
            // 
            this.medecinTableAdapter.ClearBeforeFill = true;
            // 
            // choix1
            // 
            this.choix1.FormattingEnabled = true;
            this.choix1.ItemHeight = 23;
            this.choix1.Items.AddRange(new object[] {
            "Patient",
            "Medecin",
            "Date"});
            this.choix1.Location = new System.Drawing.Point(290, 87);
            this.choix1.Name = "choix1";
            this.choix1.Size = new System.Drawing.Size(103, 29);
            this.choix1.TabIndex = 1;
            this.choix1.UseSelectable = true;
            this.choix1.SelectedIndexChanged += new System.EventHandler(this.choix1_SelectedIndexChanged);
            // 
            // choix
            // 
            // 
            // 
            // 
            this.choix.CustomButton.Image = null;
            this.choix.CustomButton.Location = new System.Drawing.Point(190, 2);
            this.choix.CustomButton.Name = "";
            this.choix.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.choix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.choix.CustomButton.TabIndex = 1;
            this.choix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.choix.CustomButton.UseSelectable = true;
            this.choix.CustomButton.Visible = false;
            this.choix.Lines = new string[0];
            this.choix.Location = new System.Drawing.Point(457, 87);
            this.choix.MaxLength = 32767;
            this.choix.Name = "choix";
            this.choix.PasswordChar = '\0';
            this.choix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.choix.SelectedText = "";
            this.choix.SelectionLength = 0;
            this.choix.SelectionStart = 0;
            this.choix.ShortcutsEnabled = true;
            this.choix.Size = new System.Drawing.Size(212, 24);
            this.choix.TabIndex = 2;
            this.choix.UseSelectable = true;
            this.choix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.choix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.choix.TextChanged += new System.EventHandler(this.choix_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestion des RDVs";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(305, 356);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "SUPPRIMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(97, 356);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 41);
            this.button3.TabIndex = 16;
            this.button3.Text = "ENREGISTRER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(509, 356);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 41);
            this.button4.TabIndex = 17;
            this.button4.Text = "ANNULER";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // secretaireBindingSource
            // 
            this.secretaireBindingSource.DataMember = "secretaire";
            this.secretaireBindingSource.DataSource = this.database1DataSet4;
            // 
            // secretaireTableAdapter
            // 
            this.secretaireTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rDVBindingSource
            // 
            this.rDVBindingSource.DataMember = "RDV";
            this.rDVBindingSource.DataSource = this.database1DataSet5;
            // 
            // rDVTableAdapter
            // 
            this.rDVTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // heure
            // 
            this.heure.DataPropertyName = "heure";
            this.heure.HeaderText = "heure";
            this.heure.Name = "heure";
            // 
            // medecin_id
            // 
            this.medecin_id.DataPropertyName = "medecin_id";
            this.medecin_id.HeaderText = "medecin_id";
            this.medecin_id.Name = "medecin_id";
            // 
            // patient_id
            // 
            this.patient_id.DataPropertyName = "patient_id";
            this.patient_id.HeaderText = "patient_id";
            this.patient_id.Name = "patient_id";
            // 
            // msheurerdv
            // 
            this.msheurerdv.FormattingEnabled = true;
            this.msheurerdv.ItemHeight = 23;
            this.msheurerdv.Items.AddRange(new object[] {
            "08:00-09:00",
            "09:00-10:00",
            "10:00-11:00",
            "11:00-12:00",
            "14:00-15:00",
            "15:00-16:00",
            "16:00-17:00",
            "17:00-18:00"});
            this.msheurerdv.Location = new System.Drawing.Point(347, 310);
            this.msheurerdv.Name = "msheurerdv";
            this.msheurerdv.Size = new System.Drawing.Size(106, 29);
            this.msheurerdv.TabIndex = 32;
            this.msheurerdv.UseSelectable = true;
            // 
            // dpdaterdv
            // 
            this.dpdaterdv.CustomFormat = "dd/MM/yyyy";
            this.dpdaterdv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpdaterdv.Location = new System.Drawing.Point(563, 319);
            this.dpdaterdv.Margin = new System.Windows.Forms.Padding(2);
            this.dpdaterdv.Name = "dpdaterdv";
            this.dpdaterdv.Size = new System.Drawing.Size(106, 20);
            this.dpdaterdv.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Heure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Date RDV";
            // 
            // textnumrdv
            // 
            this.textnumrdv.Location = new System.Drawing.Point(162, 319);
            this.textnumrdv.Margin = new System.Windows.Forms.Padding(2);
            this.textnumrdv.Name = "textnumrdv";
            this.textnumrdv.Size = new System.Drawing.Size(76, 20);
            this.textnumrdv.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Num rdv";
            // 
            // hide
            // 
            this.hide.CustomFormat = "dd/MM/yyyy";
            this.hide.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hide.Location = new System.Drawing.Point(492, 91);
            this.hide.Margin = new System.Windows.Forms.Padding(2);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(106, 20);
            this.hide.TabIndex = 33;
            this.hide.Visible = false;
            this.hide.ValueChanged += new System.EventHandler(this.hide_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(290, 419);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 32);
            this.button2.TabIndex = 34;
            this.button2.Text = "AJOUTER RDV";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.offre_emploi_medecine__3_;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.msheurerdv);
            this.Controls.Add(this.dpdaterdv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textnumrdv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choix);
            this.Controls.Add(this.choix1);
            this.Controls.Add(this.Liste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.Text = "search";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private Database1DataSetTableAdapters.MedecinTableAdapter medecinTableAdapter;
        private MetroFramework.Controls.MetroComboBox choix1;
        private MetroFramework.Controls.MetroTextBox choix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource secretaireBindingSource;
        private Database1DataSet4TableAdapters.secretaireTableAdapter secretaireTableAdapter;
        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource rDVBindingSource;
        private Database1DataSet5TableAdapters.RDVTableAdapter rDVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id;
        private MetroFramework.Controls.MetroComboBox msheurerdv;
        private System.Windows.Forms.DateTimePicker dpdaterdv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textnumrdv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker hide;
        private System.Windows.Forms.Button button2;
    }
}