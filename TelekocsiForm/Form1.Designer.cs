namespace TelekocsiForm
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
            this.btn_Beolvasas = new System.Windows.Forms.Button();
            this.lb_Kimenet = new System.Windows.Forms.ListBox();
            this.btn_Masodik = new System.Windows.Forms.Button();
            this.btn_Harmadik = new System.Windows.Forms.Button();
            this.btn_Negyedik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Beolvasas
            // 
            this.btn_Beolvasas.Location = new System.Drawing.Point(2, 13);
            this.btn_Beolvasas.Name = "btn_Beolvasas";
            this.btn_Beolvasas.Size = new System.Drawing.Size(95, 30);
            this.btn_Beolvasas.TabIndex = 0;
            this.btn_Beolvasas.Text = "Beolvasás";
            this.btn_Beolvasas.UseVisualStyleBackColor = true;
            this.btn_Beolvasas.Click += new System.EventHandler(this.btn_Beolvasas_Click);
            // 
            // lb_Kimenet
            // 
            this.lb_Kimenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Kimenet.FormattingEnabled = true;
            this.lb_Kimenet.ItemHeight = 16;
            this.lb_Kimenet.Location = new System.Drawing.Point(103, 13);
            this.lb_Kimenet.Name = "lb_Kimenet";
            this.lb_Kimenet.Size = new System.Drawing.Size(448, 292);
            this.lb_Kimenet.TabIndex = 1;
            // 
            // btn_Masodik
            // 
            this.btn_Masodik.Enabled = false;
            this.btn_Masodik.Location = new System.Drawing.Point(2, 49);
            this.btn_Masodik.Name = "btn_Masodik";
            this.btn_Masodik.Size = new System.Drawing.Size(95, 29);
            this.btn_Masodik.TabIndex = 2;
            this.btn_Masodik.Text = "2. feladat";
            this.btn_Masodik.UseVisualStyleBackColor = true;
            this.btn_Masodik.Click += new System.EventHandler(this.btn_Masodik_Click);
            // 
            // btn_Harmadik
            // 
            this.btn_Harmadik.Enabled = false;
            this.btn_Harmadik.Location = new System.Drawing.Point(2, 84);
            this.btn_Harmadik.Name = "btn_Harmadik";
            this.btn_Harmadik.Size = new System.Drawing.Size(95, 27);
            this.btn_Harmadik.TabIndex = 3;
            this.btn_Harmadik.Text = "3. feladat";
            this.btn_Harmadik.UseVisualStyleBackColor = true;
            this.btn_Harmadik.Click += new System.EventHandler(this.btn_Harmadik_Click);
            // 
            // btn_Negyedik
            // 
            this.btn_Negyedik.Enabled = false;
            this.btn_Negyedik.Location = new System.Drawing.Point(2, 117);
            this.btn_Negyedik.Name = "btn_Negyedik";
            this.btn_Negyedik.Size = new System.Drawing.Size(95, 26);
            this.btn_Negyedik.TabIndex = 4;
            this.btn_Negyedik.Text = "4. feladat";
            this.btn_Negyedik.UseVisualStyleBackColor = true;
            this.btn_Negyedik.Click += new System.EventHandler(this.btn_Negyedik_Click);
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.Controls.Add(this.btn_Negyedik);
            this.Controls.Add(this.btn_Harmadik);
            this.Controls.Add(this.btn_Masodik);
            this.Controls.Add(this.lb_Kimenet);
            this.Controls.Add(this.btn_Beolvasas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telekocsi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Beolvasas;
        private System.Windows.Forms.ListBox lb_Kimenet;
        private System.Windows.Forms.Button btn_Masodik;
        private System.Windows.Forms.Button btn_Harmadik;
        private System.Windows.Forms.Button btn_Negyedik;
    }
}

