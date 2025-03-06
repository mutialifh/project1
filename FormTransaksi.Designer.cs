namespace project1
{
    partial class FormTransaksi
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbJenis = new System.Windows.Forms.Label();
            this.lbHarga = new System.Windows.Forms.Label();
            this.lbJumlah = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbMetode = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbKursus = new System.Windows.Forms.ComboBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.numJumlah = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbMetode = new System.Windows.Forms.ComboBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btBatal = new System.Windows.Forms.Button();
            this.btKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(75, 66);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(98, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID Transaksi";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(75, 121);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(128, 20);
            this.lbNama.TabIndex = 1;
            this.lbNama.Text = "Nama Pengguna";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(75, 174);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 20);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lbJenis
            // 
            this.lbJenis.AutoSize = true;
            this.lbJenis.Location = new System.Drawing.Point(75, 222);
            this.lbJenis.Name = "lbJenis";
            this.lbJenis.Size = new System.Drawing.Size(99, 20);
            this.lbJenis.TabIndex = 3;
            this.lbJenis.Text = "Jenis Kursus";
            // 
            // lbHarga
            // 
            this.lbHarga.AutoSize = true;
            this.lbHarga.Location = new System.Drawing.Point(75, 264);
            this.lbHarga.Name = "lbHarga";
            this.lbHarga.Size = new System.Drawing.Size(110, 20);
            this.lbHarga.TabIndex = 4;
            this.lbHarga.Text = "Harga Khusus";
            // 
            // lbJumlah
            // 
            this.lbJumlah.AutoSize = true;
            this.lbJumlah.Location = new System.Drawing.Point(75, 316);
            this.lbJumlah.Name = "lbJumlah";
            this.lbJumlah.Size = new System.Drawing.Size(113, 20);
            this.lbJumlah.TabIndex = 5;
            this.lbJumlah.Text = "Jumlah Kursus";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(75, 374);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(92, 20);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "Total Harga";
            // 
            // lbMetode
            // 
            this.lbMetode.AutoSize = true;
            this.lbMetode.Location = new System.Drawing.Point(75, 426);
            this.lbMetode.Name = "lbMetode";
            this.lbMetode.Size = new System.Drawing.Size(156, 20);
            this.lbMetode.TabIndex = 7;
            this.lbMetode.Text = "Metode Pembayaran";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(287, 66);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(390, 26);
            this.txtID.TabIndex = 8;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(287, 121);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(390, 26);
            this.txtNama.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(287, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // cmbKursus
            // 
            this.cmbKursus.FormattingEnabled = true;
            this.cmbKursus.Items.AddRange(new object[] {
            "Coding",
            "Robotic",
            "Digital Marketing",
            "Bimbingan Belajar"});
            this.cmbKursus.Location = new System.Drawing.Point(287, 219);
            this.cmbKursus.Name = "cmbKursus";
            this.cmbKursus.Size = new System.Drawing.Size(390, 28);
            this.cmbKursus.TabIndex = 11;
            this.cmbKursus.Text = "Silahkan Dipilih";
            this.cmbKursus.SelectedIndexChanged += new System.EventHandler(this.cmbKursus_SelectedIndexChanged);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(287, 264);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(390, 26);
            this.txtHarga.TabIndex = 12;
            // 
            // numJumlah
            // 
            this.numJumlah.Location = new System.Drawing.Point(287, 316);
            this.numJumlah.Name = "numJumlah";
            this.numJumlah.Size = new System.Drawing.Size(390, 26);
            this.numJumlah.TabIndex = 13;
            this.numJumlah.ValueChanged += new System.EventHandler(this.numJumlah_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(287, 374);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(390, 26);
            this.txtTotal.TabIndex = 14;
            // 
            // cmbMetode
            // 
            this.cmbMetode.FormattingEnabled = true;
            this.cmbMetode.Items.AddRange(new object[] {
            "Transfer BANK",
            " e-Wallet"});
            this.cmbMetode.Location = new System.Drawing.Point(287, 426);
            this.cmbMetode.Name = "cmbMetode";
            this.cmbMetode.Size = new System.Drawing.Size(390, 28);
            this.cmbMetode.TabIndex = 15;
            this.cmbMetode.Text = "Payment";
            // 
            // btSimpan
            // 
            this.btSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSimpan.Location = new System.Drawing.Point(174, 583);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(431, 73);
            this.btSimpan.TabIndex = 17;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = false;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btBatal
            // 
            this.btBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btBatal.Location = new System.Drawing.Point(174, 488);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(164, 73);
            this.btBatal.TabIndex = 18;
            this.btBatal.Text = "Batal";
            this.btBatal.UseVisualStyleBackColor = false;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // btKembali
            // 
            this.btKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btKembali.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btKembali.Location = new System.Drawing.Point(441, 488);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(164, 73);
            this.btKembali.TabIndex = 19;
            this.btKembali.Text = "Kembali";
            this.btKembali.UseVisualStyleBackColor = false;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(756, 713);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.cmbMetode);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.numJumlah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.cmbKursus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbMetode);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbJumlah);
            this.Controls.Add(this.lbHarga);
            this.Controls.Add(this.lbJenis);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbID);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbJenis;
        private System.Windows.Forms.Label lbHarga;
        private System.Windows.Forms.Label lbJumlah;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbMetode;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbKursus;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.NumericUpDown numJumlah;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbMetode;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.Button btKembali;
    }
}