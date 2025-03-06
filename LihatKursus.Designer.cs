namespace project1
{
    partial class LihatKursus
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
            this.lbName = new System.Windows.Forms.Label();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbName.Location = new System.Drawing.Point(234, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(355, 59);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Daftar Kursus";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.des,
            this.Price,
            this.Harga});
            this.dataGridViewCourses.Location = new System.Drawing.Point(99, 135);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 62;
            this.dataGridViewCourses.RowTemplate.Height = 28;
            this.dataGridViewCourses.Size = new System.Drawing.Size(511, 450);
            this.dataGridViewCourses.TabIndex = 1;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Kursus";
            this.Nama.MinimumWidth = 8;
            this.Nama.Name = "Nama";
            this.Nama.Width = 150;
            // 
            // des
            // 
            this.des.HeaderText = "Deskripsi";
            this.des.MinimumWidth = 8;
            this.des.Name = "des";
            this.des.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Harga Kursus";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Visible = false;
            this.Price.Width = 150;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga Kursus";
            this.Harga.MinimumWidth = 8;
            this.Harga.Name = "Harga";
            this.Harga.Width = 150;
            // 
            // btKembali
            // 
            this.btKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btKembali.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btKembali.Location = new System.Drawing.Point(594, 616);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(175, 62);
            this.btKembali.TabIndex = 2;
            this.btKembali.Text = "Kembali";
            this.btKembali.UseVisualStyleBackColor = false;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // LihatKursus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(827, 734);
            this.Controls.Add(this.btKembali);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.lbName);
            this.Name = "LihatKursus";
            this.Text = "LihatKursus";
            this.Load += new System.EventHandler(this.LihatKursus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.Button btKembali;
    }
}