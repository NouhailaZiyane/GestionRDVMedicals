
namespace WindowsFormsApp3
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.secretaireBtn = new System.Windows.Forms.Button();
            this.patienBtn = new System.Windows.Forms.Button();
            this.doctorBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.offre_emploi_medecine__3_;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.secretaireBtn);
            this.panel1.Controls.Add(this.patienBtn);
            this.panel1.Controls.Add(this.doctorBtn);
            this.panel1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 681);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::WindowsFormsApp3.Properties.Resources.offre_emploi_medecine__3_;
            this.label3.Location = new System.Drawing.Point(271, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Technology in service of humanity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::WindowsFormsApp3.Properties.Resources.offre_emploi_medecine__3_;
            this.label2.Location = new System.Drawing.Point(344, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 7;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::WindowsFormsApp3.Properties.Resources.offre_emploi_medecine__3_;
            this.label1.Location = new System.Drawing.Point(399, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Empower MedTech";
            // 
            // secretaireBtn
            // 
            this.secretaireBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.secretaireBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secretaireBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretaireBtn.ForeColor = System.Drawing.Color.White;
            this.secretaireBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.secretaireBtn.Location = new System.Drawing.Point(711, 224);
            this.secretaireBtn.Name = "secretaireBtn";
            this.secretaireBtn.Size = new System.Drawing.Size(288, 91);
            this.secretaireBtn.TabIndex = 5;
            this.secretaireBtn.Text = "Secretaire";
            this.secretaireBtn.UseVisualStyleBackColor = false;
            this.secretaireBtn.Click += new System.EventHandler(this.secretaireBtn_Click);
            // 
            // patienBtn
            // 
            this.patienBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.patienBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patienBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patienBtn.ForeColor = System.Drawing.Color.White;
            this.patienBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patienBtn.Location = new System.Drawing.Point(369, 223);
            this.patienBtn.Name = "patienBtn";
            this.patienBtn.Size = new System.Drawing.Size(312, 92);
            this.patienBtn.TabIndex = 4;
            this.patienBtn.Text = "Patient";
            this.patienBtn.UseVisualStyleBackColor = false;
            this.patienBtn.Click += new System.EventHandler(this.patienBtn_Click);
            // 
            // doctorBtn
            // 
            this.doctorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.doctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorBtn.ForeColor = System.Drawing.Color.White;
            this.doctorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorBtn.Location = new System.Drawing.Point(32, 224);
            this.doctorBtn.Name = "doctorBtn";
            this.doctorBtn.Size = new System.Drawing.Size(312, 91);
            this.doctorBtn.TabIndex = 0;
            this.doctorBtn.Text = "Médecin";
            this.doctorBtn.UseVisualStyleBackColor = false;
            this.doctorBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 538);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(144)))), ((int)(((byte)(102)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form8";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.BackColorChanged += new System.EventHandler(this.Form2_BackgroundImageChanged);
            this.BackgroundImageChanged += new System.EventHandler(this.Form2_BackgroundImageChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button doctorBtn;
        private System.Windows.Forms.Button secretaireBtn;
        private System.Windows.Forms.Button patienBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
