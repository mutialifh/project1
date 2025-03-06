namespace project1
{
    partial class FormLihatTransaksi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbDaftar = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kursus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalPembelian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetodePembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statuss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bthapus = new System.Windows.Forms.Button();
            this.btkembali = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama,
            this.kursus,
            this.TanggalPembelian,
            this.MetodePembayaran,
            this.TotalHarga,
            this.Statuss});
            this.dataGridView1.Location = new System.Drawing.Point(59, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(679, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbDaftar
            // 
            this.lbDaftar.AutoSize = true;
            this.lbDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDaftar.Location = new System.Drawing.Point(234, 33);
            this.lbDaftar.Name = "lbDaftar";
            this.lbDaftar.Size = new System.Drawing.Size(359, 52);
            this.lbDaftar.TabIndex = 1;
            this.lbDaftar.Text = "Daftar Transaksi";
            // 
            // id
            // 
            this.id.HeaderText = "Id Transaksi";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama Pengguna";
            this.nama.MinimumWidth = 8;
            this.nama.Name = "nama";
            this.nama.Width = 150;
            // 
            // kursus
            // 
            this.kursus.HeaderText = "Kursus yang Dibeli";
            this.kursus.MinimumWidth = 8;
            this.kursus.Name = "kursus";
            this.kursus.Width = 150;
            // 
            // TanggalPembelian
            // 
            this.TanggalPembelian.HeaderText = "Tanggal Pembelian";
            this.TanggalPembelian.MinimumWidth = 8;
            this.TanggalPembelian.Name = "TanggalPembelian";
            this.TanggalPembelian.Width = 150;
            // 
            // MetodePembayaran
            // 
            this.MetodePembayaran.HeaderText = "Metode Pembayaran";
            this.MetodePembayaran.MinimumWidth = 8;
            this.MetodePembayaran.Name = "MetodePembayaran";
            this.MetodePembayaran.Width = 150;
            // 
            // TotalHarga
            // 
            this.TotalHarga.HeaderText = "Total Harga";
            this.TotalHarga.MinimumWidth = 8;
            this.TotalHarga.Name = "TotalHarga";
            this.TotalHarga.Width = 150;
            // 
            // Statuss
            // 
            this.Statuss.HeaderText = "Status";
            this.Statuss.MinimumWidth = 8;
            this.Statuss.Name = "Statuss";
            this.Statuss.Width = 150;
            // 
            // bthapus
            // 
            this.bthapus.Location = new System.Drawing.Point(410, 632);
            this.bthapus.Name = "bthapus";
            this.bthapus.Size = new System.Drawing.Size(270, 55);
            this.bthapus.TabIndex = 3;
            this.bthapus.Text = "Hapus Transaksi";
            this.bthapus.UseVisualStyleBackColor = true;
            // 
            // btkembali
            // 
            this.btkembali.Location = new System.Drawing.Point(59, 632);
            this.btkembali.Name = "btkembali";
            this.btkembali.Size = new System.Drawing.Size(270, 55);
            this.btkembali.TabIndex = 4;
            this.btkembali.Text = "Kembali";
            this.btkembali.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Sukses",
            "Pending"});
            this.cmbStatus.Location = new System.Drawing.Point(59, 553);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(261, 28);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.Text = "Status";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(410, 539);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(270, 55);
            this.btUpdate.TabIndex = 6;
            this.btUpdate.Text = "Update Transaksi";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // FormLihatTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 752);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btkembali);
            this.Controls.Add(this.bthapus);
            this.Controls.Add(this.lbDaftar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLihatTransaksi";
            this.Text = "FormLihatTransaksi";
            this.Load += new System.EventHandler(this.FormLihatTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbDaftar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kursus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalPembelian;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetodePembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statuss;
        private System.Windows.Forms.Button bthapus;
        private System.Windows.Forms.Button btkembali;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btUpdate;
    }
}