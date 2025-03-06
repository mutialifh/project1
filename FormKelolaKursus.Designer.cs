namespace project1
{
    partial class FormKelolaKursus
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNamaKursus = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.txtNamaKursus = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.dataGridViewKursus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKursus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(34, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kelola Kursus";
            // 
            // lblNamaKursus
            // 
            this.lblNamaKursus.AutoSize = true;
            this.lblNamaKursus.Location = new System.Drawing.Point(36, 160);
            this.lblNamaKursus.Name = "lblNamaKursus";
            this.lblNamaKursus.Size = new System.Drawing.Size(90, 16);
            this.lblNamaKursus.TabIndex = 1;
            this.lblNamaKursus.Text = "Nama Kursus:";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(36, 211);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(48, 16);
            this.lblHarga.TabIndex = 2;
            this.lblHarga.Text = "Harga:";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(39, 307);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(118, 49);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(201, 307);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 49);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(39, 378);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(118, 44);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(201, 378);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(103, 44);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            // 
            // txtNamaKursus
            // 
            this.txtNamaKursus.Location = new System.Drawing.Point(170, 160);
            this.txtNamaKursus.Name = "txtNamaKursus";
            this.txtNamaKursus.Size = new System.Drawing.Size(155, 22);
            this.txtNamaKursus.TabIndex = 7;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(170, 208);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(155, 22);
            this.txtHarga.TabIndex = 8;
            // 
            // dataGridViewKursus
            // 
            this.dataGridViewKursus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKursus.Location = new System.Drawing.Point(357, 44);
            this.dataGridViewKursus.Name = "dataGridViewKursus";
            this.dataGridViewKursus.RowHeadersWidth = 51;
            this.dataGridViewKursus.RowTemplate.Height = 24;
            this.dataGridViewKursus.Size = new System.Drawing.Size(407, 344);
            this.dataGridViewKursus.TabIndex = 9;
            // 
            // FormKelolaKursus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewKursus);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNamaKursus);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblNamaKursus);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormKelolaKursus";
            this.Text = "FormKelolaKursus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKursus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNamaKursus;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.TextBox txtNamaKursus;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.DataGridView dataGridViewKursus;
    }
}