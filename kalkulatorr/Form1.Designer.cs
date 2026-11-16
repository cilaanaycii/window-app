namespace kalkulatorr
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
            this.lblAngka1 = new System.Windows.Forms.Label();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.lblAngka2 = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lblAksi = new System.Windows.Forms.Label();
            this.btnPengurangan = new System.Windows.Forms.Button();
            this.btnPerkalian = new System.Windows.Forms.Button();
            this.btnPembagian = new System.Windows.Forms.Button();
            this.btnPenjumlahan = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAngka1
            // 
            this.lblAngka1.AutoSize = true;
            this.lblAngka1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngka1.Location = new System.Drawing.Point(12, 52);
            this.lblAngka1.Name = "lblAngka1";
            this.lblAngka1.Size = new System.Drawing.Size(61, 18);
            this.lblAngka1.TabIndex = 0;
            this.lblAngka1.Text = "Angka 1";
            // 
            // txtAngka1
            // 
            this.txtAngka1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtAngka1.Location = new System.Drawing.Point(15, 73);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(423, 20);
            this.txtAngka1.TabIndex = 1;
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(15, 128);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(423, 20);
            this.txtAngka2.TabIndex = 3;
            // 
            // lblAngka2
            // 
            this.lblAngka2.AutoSize = true;
            this.lblAngka2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngka2.Location = new System.Drawing.Point(12, 107);
            this.lblAngka2.Name = "lblAngka2";
            this.lblAngka2.Size = new System.Drawing.Size(61, 18);
            this.lblAngka2.TabIndex = 2;
            this.lblAngka2.Text = "Angka 2";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasil.Location = new System.Drawing.Point(12, 174);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(53, 18);
            this.lblHasil.TabIndex = 4;
            this.lblHasil.Text = "Hasil :";
            // 
            // lblAksi
            // 
            this.lblAksi.AutoSize = true;
            this.lblAksi.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAksi.Location = new System.Drawing.Point(202, 207);
            this.lblAksi.Name = "lblAksi";
            this.lblAksi.Size = new System.Drawing.Size(39, 18);
            this.lblAksi.TabIndex = 5;
            this.lblAksi.Text = "Aksi";
            // 
            // btnPengurangan
            // 
            this.btnPengurangan.Location = new System.Drawing.Point(12, 257);
            this.btnPengurangan.Name = "btnPengurangan";
            this.btnPengurangan.Size = new System.Drawing.Size(426, 23);
            this.btnPengurangan.TabIndex = 6;
            this.btnPengurangan.Text = "Pengurangan";
            this.btnPengurangan.UseVisualStyleBackColor = true;
            this.btnPengurangan.Click += new System.EventHandler(this.btnPengurangan_Click);
            // 
            // btnPerkalian
            // 
            this.btnPerkalian.Location = new System.Drawing.Point(12, 286);
            this.btnPerkalian.Name = "btnPerkalian";
            this.btnPerkalian.Size = new System.Drawing.Size(426, 23);
            this.btnPerkalian.TabIndex = 7;
            this.btnPerkalian.Text = "Perkalian";
            this.btnPerkalian.UseVisualStyleBackColor = true;
            this.btnPerkalian.Click += new System.EventHandler(this.btnPerkalian_Click);
            // 
            // btnPembagian
            // 
            this.btnPembagian.Location = new System.Drawing.Point(12, 315);
            this.btnPembagian.Name = "btnPembagian";
            this.btnPembagian.Size = new System.Drawing.Size(426, 23);
            this.btnPembagian.TabIndex = 8;
            this.btnPembagian.Text = "Pembagian";
            this.btnPembagian.UseVisualStyleBackColor = true;
            this.btnPembagian.Click += new System.EventHandler(this.btnPembagian_Click);
            // 
            // btnPenjumlahan
            // 
            this.btnPenjumlahan.Location = new System.Drawing.Point(12, 228);
            this.btnPenjumlahan.Name = "btnPenjumlahan";
            this.btnPenjumlahan.Size = new System.Drawing.Size(426, 23);
            this.btnPenjumlahan.TabIndex = 9;
            this.btnPenjumlahan.Text = "Penjumlahan";
            this.btnPenjumlahan.UseVisualStyleBackColor = true;
            this.btnPenjumlahan.Click += new System.EventHandler(this.btnPenjumlahan_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(128, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(200, 24);
            this.lblJudul.TabIndex = 10;
            this.lblJudul.Text = "Kalkulator Sederhana";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.btnPenjumlahan);
            this.Controls.Add(this.btnPembagian);
            this.Controls.Add(this.btnPerkalian);
            this.Controls.Add(this.btnPengurangan);
            this.Controls.Add(this.lblAksi);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.lblAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.lblAngka1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAngka1;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.Label lblAngka2;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label lblAksi;
        private System.Windows.Forms.Button btnPengurangan;
        private System.Windows.Forms.Button btnPerkalian;
        private System.Windows.Forms.Button btnPembagian;
        private System.Windows.Forms.Button btnPenjumlahan;
        private System.Windows.Forms.Label lblJudul;
    }
}

