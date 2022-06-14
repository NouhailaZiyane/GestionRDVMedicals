
namespace WindowsFormsApp3
{
    partial class Form10
    {        /// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.label1 = new System.Windows.Forms.Label();
            this.textcode = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.textprenom = new System.Windows.Forms.TextBox();
            this.textnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDVBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new WindowsFormsApp3.Database1DataSet2();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rDVBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.rDVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDVBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rDVTableAdapter = new WindowsFormsApp3.Database1DataSet2TableAdapters.RDVTableAdapter();
            this.textnumrdv = new System.Windows.Forms.TextBox();
            this.dpdaterdv = new System.Windows.Forms.DateTimePicker();
            this.msheurerdv = new MetroFramework.Controls.MetroComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "code patient ";
            // 
            // textcode
            // 
            this.textcode.Location = new System.Drawing.Point(171, 46);
            this.textcode.Margin = new System.Windows.Forms.Padding(2);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(76, 20);
            this.textcode.TabIndex = 1;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.DarkCyan;
            this.button_ok.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_ok.Location = new System.Drawing.Point(298, 44);
            this.button_ok.Margin = new System.Windows.Forms.Padding(2);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(89, 34);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click_1);
            // 
            // button_annuler
            // 
            this.button_annuler.BackColor = System.Drawing.Color.DarkCyan;
            this.button_annuler.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_annuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_annuler.Location = new System.Drawing.Point(403, 44);
            this.button_annuler.Margin = new System.Windows.Forms.Padding(2);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(91, 34);
            this.button_annuler.TabIndex = 3;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = false;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // textprenom
            // 
            this.textprenom.Location = new System.Drawing.Point(171, 152);
            this.textprenom.Margin = new System.Windows.Forms.Padding(2);
            this.textprenom.Name = "textprenom";
            this.textprenom.Size = new System.Drawing.Size(76, 20);
            this.textprenom.TabIndex = 4;
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(171, 113);
            this.textnom.Margin = new System.Windows.Forms.Padding(2);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(76, 20);
            this.textnom.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prenom";
            // 
            // Liste
            // 
            this.Liste.AutoGenerateColumns = false;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.Liste.DataSource = this.rDVBindingSource4;
            this.Liste.Location = new System.Drawing.Point(118, 213);
            this.Liste.Margin = new System.Windows.Forms.Padding(2);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(368, 102);
            this.Liste.TabIndex = 8;
            this.Liste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn2.HeaderText = "date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "heure";
            this.dataGridViewTextBoxColumn3.HeaderText = "heure";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // rDVBindingSource4
            // 
            this.rDVBindingSource4.DataMember = "RDV";
            this.rDVBindingSource4.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Num rdv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date RDV";
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.BackColor = System.Drawing.Color.DarkCyan;
            this.button_enregistrer.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_enregistrer.Location = new System.Drawing.Point(130, 379);
            this.button_enregistrer.Margin = new System.Windows.Forms.Padding(2);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(106, 40);
            this.button_enregistrer.TabIndex = 15;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = false;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.BackColor = System.Drawing.Color.DarkCyan;
            this.button_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_supprimer.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_supprimer.Location = new System.Drawing.Point(309, 383);
            this.button_supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(99, 36);
            this.button_supprimer.TabIndex = 16;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = false;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Heure";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // rDVBindingSource3
            // 
            this.rDVBindingSource3.DataMember = "RDV";
            // 
            // rDVBindingSource1
            // 
            this.rDVBindingSource1.DataMember = "RDV";
            // 
            // rDVBindingSource
            // 
            this.rDVBindingSource.DataMember = "RDV";
            // 
            // rDVBindingSource2
            // 
            this.rDVBindingSource2.DataMember = "RDV";
            // 
            // rDVTableAdapter
            // 
            this.rDVTableAdapter.ClearBeforeFill = true;
            // 
            // textnumrdv
            // 
            this.textnumrdv.Location = new System.Drawing.Point(76, 348);
            this.textnumrdv.Margin = new System.Windows.Forms.Padding(2);
            this.textnumrdv.Name = "textnumrdv";
            this.textnumrdv.Size = new System.Drawing.Size(76, 20);
            this.textnumrdv.TabIndex = 10;
            // 
            // dpdaterdv
            // 
            this.dpdaterdv.CustomFormat = "dd/MM/yyyy";
            this.dpdaterdv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpdaterdv.Location = new System.Drawing.Point(477, 348);
            this.dpdaterdv.Margin = new System.Windows.Forms.Padding(2);
            this.dpdaterdv.Name = "dpdaterdv";
            this.dpdaterdv.Size = new System.Drawing.Size(106, 20);
            this.dpdaterdv.TabIndex = 24;
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
            this.msheurerdv.Location = new System.Drawing.Point(261, 339);
            this.msheurerdv.Name = "msheurerdv";
            this.msheurerdv.Size = new System.Drawing.Size(106, 29);
            this.msheurerdv.TabIndex = 26;
            this.msheurerdv.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(298, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 49);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ajouter RDV";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.offre_emploi_medecine__3_;
            this.ClientSize = new System.Drawing.Size(598, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msheurerdv);
            this.Controls.Add(this.dpdaterdv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_enregistrer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textnumrdv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.textprenom);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textcode);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form10";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.TextBox textprenom;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Liste;
       // private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource rDVBindingSource;
       // private Database1DataSet2TableAdapters.RDVTableAdapter rDVTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Label label6;
       // private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource rDVBindingSource1;
       // private Database1DataSet3TableAdapters.RDVTableAdapter rDVTableAdapter1;
        //private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource rDVBindingSource2;
        //private Database1DataSet4TableAdapters.RDVTableAdapter rDVTableAdapter2;
        //private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource rDVBindingSource3;
        //private Database1DataSet5TableAdapters.RDVTableAdapter rDVTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource rDVBindingSource4;
        private Database1DataSet2TableAdapters.RDVTableAdapter rDVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textnumrdv;
        private System.Windows.Forms.DateTimePicker dpdaterdv;
        private MetroFramework.Controls.MetroComboBox msheurerdv;
        private System.Windows.Forms.Button button1;
    }
}
