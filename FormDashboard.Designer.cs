namespace project1
{
    partial class FormDashboard
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
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageCourses = new System.Windows.Forms.Button();
            this.btnViewTransactions = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpAdminOptions = new System.Windows.Forms.GroupBox();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.btUser = new System.Windows.Forms.Button();
            this.btKursus = new System.Windows.Forms.Button();
            this.btlog = new System.Windows.Forms.Button();
            this.btTransaksi = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.grpUserOptions = new System.Windows.Forms.GroupBox();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.grpAdminOptions.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            this.grpUserOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(198, 36);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(461, 32);
            this.lblWelcomeAdmin.TabIndex = 0;
            this.lblWelcomeAdmin.Text = "\"Selamat Datang, Administrator!\"";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(46, 81);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(433, 65);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Kelola User";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnManageCourses
            // 
            this.btnManageCourses.Location = new System.Drawing.Point(46, 190);
            this.btnManageCourses.Name = "btnManageCourses";
            this.btnManageCourses.Size = new System.Drawing.Size(433, 65);
            this.btnManageCourses.TabIndex = 2;
            this.btnManageCourses.Text = "Kelola Kursus";
            this.btnManageCourses.UseVisualStyleBackColor = true;
            // 
            // btnViewTransactions
            // 
            this.btnViewTransactions.Location = new System.Drawing.Point(46, 294);
            this.btnViewTransactions.Name = "btnViewTransactions";
            this.btnViewTransactions.Size = new System.Drawing.Size(433, 65);
            this.btnViewTransactions.TabIndex = 3;
            this.btnViewTransactions.Text = "Lihat Transaksi";
            this.btnViewTransactions.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(46, 405);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(433, 65);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // grpAdminOptions
            // 
            this.grpAdminOptions.BackColor = System.Drawing.Color.MistyRose;
            this.grpAdminOptions.Controls.Add(this.btnManageUsers);
            this.grpAdminOptions.Controls.Add(this.btnManageCourses);
            this.grpAdminOptions.Controls.Add(this.btnLogout);
            this.grpAdminOptions.Controls.Add(this.btnViewTransactions);
            this.grpAdminOptions.Location = new System.Drawing.Point(12, 94);
            this.grpAdminOptions.Name = "grpAdminOptions";
            this.grpAdminOptions.Size = new System.Drawing.Size(560, 619);
            this.grpAdminOptions.TabIndex = 5;
            this.grpAdminOptions.TabStop = false;
            this.grpAdminOptions.Text = "Menu Admin";
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCustomer.Controls.Add(this.panelAdmin);
            this.panelCustomer.Controls.Add(this.grpUserOptions);
            this.panelCustomer.Controls.Add(this.lblWelcomeUser);
            this.panelCustomer.Location = new System.Drawing.Point(-6, -4);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(871, 739);
            this.panelCustomer.TabIndex = 6;
            this.panelCustomer.Visible = false;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelAdmin.Controls.Add(this.gbAdmin);
            this.panelAdmin.Controls.Add(this.lbName);
            this.panelAdmin.Location = new System.Drawing.Point(7, 3);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(864, 734);
            this.panelAdmin.TabIndex = 7;
            this.panelAdmin.Visible = false;
            // 
            // gbAdmin
            // 
            this.gbAdmin.BackColor = System.Drawing.Color.MistyRose;
            this.gbAdmin.Controls.Add(this.btUser);
            this.gbAdmin.Controls.Add(this.btKursus);
            this.gbAdmin.Controls.Add(this.btlog);
            this.gbAdmin.Controls.Add(this.btTransaksi);
            this.gbAdmin.Location = new System.Drawing.Point(20, 83);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(560, 619);
            this.gbAdmin.TabIndex = 7;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Menu Admin";
            // 
            // btUser
            // 
            this.btUser.Location = new System.Drawing.Point(46, 81);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(433, 65);
            this.btUser.TabIndex = 1;
            this.btUser.Text = "Kelola User";
            this.btUser.UseVisualStyleBackColor = true;
            // 
            // btKursus
            // 
            this.btKursus.Location = new System.Drawing.Point(46, 190);
            this.btKursus.Name = "btKursus";
            this.btKursus.Size = new System.Drawing.Size(433, 65);
            this.btKursus.TabIndex = 2;
            this.btKursus.Text = "Kelola Kursus";
            this.btKursus.UseVisualStyleBackColor = true;
            // 
            // btlog
            // 
            this.btlog.Location = new System.Drawing.Point(46, 405);
            this.btlog.Name = "btlog";
            this.btlog.Size = new System.Drawing.Size(433, 65);
            this.btlog.TabIndex = 4;
            this.btlog.Text = "LOGOUT";
            this.btlog.UseVisualStyleBackColor = true;
            // 
            // btTransaksi
            // 
            this.btTransaksi.Location = new System.Drawing.Point(46, 294);
            this.btTransaksi.Name = "btTransaksi";
            this.btTransaksi.Size = new System.Drawing.Size(433, 65);
            this.btTransaksi.TabIndex = 3;
            this.btTransaksi.Text = "Lihat Transaksi";
            this.btTransaksi.UseVisualStyleBackColor = true;
            this.btTransaksi.Click += new System.EventHandler(this.btTransaksi_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(206, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(461, 32);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "\"Selamat Datang, Administrator!\"";
            // 
            // grpUserOptions
            // 
            this.grpUserOptions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpUserOptions.Controls.Add(this.btnTransaction);
            this.grpUserOptions.Controls.Add(this.btnViewCourses);
            this.grpUserOptions.Controls.Add(this.btLogout);
            this.grpUserOptions.Location = new System.Drawing.Point(32, 99);
            this.grpUserOptions.Name = "grpUserOptions";
            this.grpUserOptions.Size = new System.Drawing.Size(535, 576);
            this.grpUserOptions.TabIndex = 4;
            this.grpUserOptions.TabStop = false;
            this.grpUserOptions.Text = "Menu Pengguna";
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(61, 61);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(340, 86);
            this.btnTransaction.TabIndex = 2;
            this.btnTransaction.Text = "Lakukan Transaksi";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.Location = new System.Drawing.Point(61, 226);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(340, 86);
            this.btnViewCourses.TabIndex = 1;
            this.btnViewCourses.Text = "Lihat Kursus";
            this.btnViewCourses.UseVisualStyleBackColor = true;
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(61, 393);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(340, 86);
            this.btLogout.TabIndex = 3;
            this.btLogout.Text = "LOGOUT";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click_1);
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.Location = new System.Drawing.Point(229, 39);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(373, 32);
            this.lblWelcomeUser.TabIndex = 0;
            this.lblWelcomeUser.Text = "\"Selamat Datang, [nama]!\"";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(857, 715);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.grpAdminOptions);
            this.Controls.Add(this.lblWelcomeAdmin);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.grpAdminOptions.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.gbAdmin.ResumeLayout(false);
            this.grpUserOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeAdmin;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageCourses;
        private System.Windows.Forms.Button btnViewTransactions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpAdminOptions;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.GroupBox grpUserOptions;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btKursus;
        private System.Windows.Forms.Button btlog;
        private System.Windows.Forms.Button btTransaksi;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnTransaction;
    }
}