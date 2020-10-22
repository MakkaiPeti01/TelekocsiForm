namespace telekocsiform
{
    partial class frmFo
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
            this.btnBeolvasas = new System.Windows.Forms.Button();
            this.lbKimenet = new System.Windows.Forms.ListBox();
            this.btn_Masodik = new System.Windows.Forms.Button();
            this.btn_Harmadik = new System.Windows.Forms.Button();
            this.btn_Negyedik = new System.Windows.Forms.Button();
            this.btn_Otodik = new System.Windows.Forms.Button();
            this.btn_Hatodik = new System.Windows.Forms.Button();
            this.btn_Kilepes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBeolvasas
            // 
            this.btnBeolvasas.Location = new System.Drawing.Point(12, 21);
            this.btnBeolvasas.Name = "btnBeolvasas";
            this.btnBeolvasas.Size = new System.Drawing.Size(75, 23);
            this.btnBeolvasas.TabIndex = 0;
            this.btnBeolvasas.Text = "Beolvasás";
            this.btnBeolvasas.UseVisualStyleBackColor = true;
            this.btnBeolvasas.Click += new System.EventHandler(this.btnBeolvasas_Click);
            // 
            // lbKimenet
            // 
            this.lbKimenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKimenet.FormattingEnabled = true;
            this.lbKimenet.Location = new System.Drawing.Point(93, 50);
            this.lbKimenet.Name = "lbKimenet";
            this.lbKimenet.Size = new System.Drawing.Size(458, 290);
            this.lbKimenet.TabIndex = 1;
            // 
            // btn_Masodik
            // 
            this.btn_Masodik.Enabled = false;
            this.btn_Masodik.Location = new System.Drawing.Point(12, 50);
            this.btn_Masodik.Name = "btn_Masodik";
            this.btn_Masodik.Size = new System.Drawing.Size(75, 23);
            this.btn_Masodik.TabIndex = 2;
            this.btn_Masodik.Text = "2. Feladat";
            this.btn_Masodik.UseVisualStyleBackColor = true;
            this.btn_Masodik.Click += new System.EventHandler(this.btn_Masodik_Click);
            // 
            // btn_Harmadik
            // 
            this.btn_Harmadik.Enabled = false;
            this.btn_Harmadik.Location = new System.Drawing.Point(12, 79);
            this.btn_Harmadik.Name = "btn_Harmadik";
            this.btn_Harmadik.Size = new System.Drawing.Size(75, 23);
            this.btn_Harmadik.TabIndex = 3;
            this.btn_Harmadik.Text = "3. Feladat";
            this.btn_Harmadik.UseVisualStyleBackColor = true;
            this.btn_Harmadik.Click += new System.EventHandler(this.btn_Harmadik_Click);
            // 
            // btn_Negyedik
            // 
            this.btn_Negyedik.Enabled = false;
            this.btn_Negyedik.Location = new System.Drawing.Point(12, 109);
            this.btn_Negyedik.Name = "btn_Negyedik";
            this.btn_Negyedik.Size = new System.Drawing.Size(75, 23);
            this.btn_Negyedik.TabIndex = 4;
            this.btn_Negyedik.Text = "4. Feladat";
            this.btn_Negyedik.UseVisualStyleBackColor = true;
            this.btn_Negyedik.Click += new System.EventHandler(this.btn_Negyedik_Click);
            // 
            // btn_Otodik
            // 
            this.btn_Otodik.Enabled = false;
            this.btn_Otodik.Location = new System.Drawing.Point(12, 138);
            this.btn_Otodik.Name = "btn_Otodik";
            this.btn_Otodik.Size = new System.Drawing.Size(75, 23);
            this.btn_Otodik.TabIndex = 5;
            this.btn_Otodik.Text = "5. Feladat";
            this.btn_Otodik.UseVisualStyleBackColor = true;
            this.btn_Otodik.Click += new System.EventHandler(this.btn_Otodik_Click);
            // 
            // btn_Hatodik
            // 
            this.btn_Hatodik.Enabled = false;
            this.btn_Hatodik.Location = new System.Drawing.Point(12, 167);
            this.btn_Hatodik.Name = "btn_Hatodik";
            this.btn_Hatodik.Size = new System.Drawing.Size(75, 23);
            this.btn_Hatodik.TabIndex = 6;
            this.btn_Hatodik.Text = "6. Feladat";
            this.btn_Hatodik.UseVisualStyleBackColor = true;
            this.btn_Hatodik.Click += new System.EventHandler(this.btn_Hatodik_Click);
            // 
            // btn_Kilepes
            // 
            this.btn_Kilepes.Location = new System.Drawing.Point(12, 317);
            this.btn_Kilepes.Name = "btn_Kilepes";
            this.btn_Kilepes.Size = new System.Drawing.Size(75, 23);
            this.btn_Kilepes.TabIndex = 7;
            this.btn_Kilepes.Text = "Kilépés";
            this.btn_Kilepes.UseVisualStyleBackColor = true;
            this.btn_Kilepes.Click += new System.EventHandler(this.btn_Kilepes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Feladatok kimenetele";
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kilepes);
            this.Controls.Add(this.btn_Hatodik);
            this.Controls.Add(this.btn_Otodik);
            this.Controls.Add(this.btn_Negyedik);
            this.Controls.Add(this.btn_Harmadik);
            this.Controls.Add(this.btn_Masodik);
            this.Controls.Add(this.lbKimenet);
            this.Controls.Add(this.btnBeolvasas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmFo";
            this.Text = "Telekocsi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeolvasas;
        private System.Windows.Forms.ListBox lbKimenet;
        private System.Windows.Forms.Button btn_Masodik;
        private System.Windows.Forms.Button btn_Harmadik;
        private System.Windows.Forms.Button btn_Negyedik;
        private System.Windows.Forms.Button btn_Otodik;
        private System.Windows.Forms.Button btn_Hatodik;
        private System.Windows.Forms.Button btn_Kilepes;
        private System.Windows.Forms.Label label1;
    }
}

