namespace FootballAPPFinal.AllForms
{
    partial class AdminPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnReservation = new System.Windows.Forms.Panel();
            this.btnCloseAdm = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnAddWorker = new System.Windows.Forms.Panel();
            this.dtgReservations = new System.Windows.Forms.DataGridView();
            this.cmbCusName = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnStadiums = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWFullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWPassword = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddWork = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnReservation.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnAddWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pnAddWorker);
            this.panel1.Controls.Add(this.btnRooms);
            this.panel1.Controls.Add(this.btnStadiums);
            this.panel1.Controls.Add(this.btnAddWorker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 562);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME, ADMIN!";
            // 
            // pnReservation
            // 
            this.pnReservation.Controls.Add(this.panel3);
            this.pnReservation.Location = new System.Drawing.Point(188, 36);
            this.pnReservation.Name = "pnReservation";
            this.pnReservation.Size = new System.Drawing.Size(664, 526);
            this.pnReservation.TabIndex = 4;
            // 
            // btnCloseAdm
            // 
            this.btnCloseAdm.BackColor = System.Drawing.Color.LightGray;
            this.btnCloseAdm.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCloseAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAdm.Image = global::FootballAPPFinal.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back;
            this.btnCloseAdm.Location = new System.Drawing.Point(818, 0);
            this.btnCloseAdm.Name = "btnCloseAdm";
            this.btnCloseAdm.Size = new System.Drawing.Size(34, 33);
            this.btnCloseAdm.TabIndex = 60;
            this.btnCloseAdm.UseVisualStyleBackColor = false;
            this.btnCloseAdm.Click += new System.EventHandler(this.btnCloseAdm_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.dtgReservations);
            this.panel3.Controls.Add(this.cmbCusName);
            this.panel3.Controls.Add(this.btnFind);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 526);
            this.panel3.TabIndex = 12;
            // 
            // pnAddWorker
            // 
            this.pnAddWorker.Controls.Add(this.btnAddWork);
            this.pnAddWorker.Controls.Add(this.dataGridView1);
            this.pnAddWorker.Controls.Add(this.txtConPassword);
            this.pnAddWorker.Controls.Add(this.label7);
            this.pnAddWorker.Controls.Add(this.txtWPassword);
            this.pnAddWorker.Controls.Add(this.label6);
            this.pnAddWorker.Controls.Add(this.txtWUsername);
            this.pnAddWorker.Controls.Add(this.label5);
            this.pnAddWorker.Controls.Add(this.txtWFullname);
            this.pnAddWorker.Controls.Add(this.label4);
            this.pnAddWorker.Controls.Add(this.pictureBox1);
            this.pnAddWorker.Location = new System.Drawing.Point(188, 36);
            this.pnAddWorker.Name = "pnAddWorker";
            this.pnAddWorker.Size = new System.Drawing.Size(664, 526);
            this.pnAddWorker.TabIndex = 5;
            this.pnAddWorker.Visible = false;
            // 
            // dtgReservations
            // 
            this.dtgReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgReservations.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgReservations.Location = new System.Drawing.Point(0, 367);
            this.dtgReservations.Name = "dtgReservations";
            this.dtgReservations.Size = new System.Drawing.Size(664, 159);
            this.dtgReservations.TabIndex = 20;
            // 
            // cmbCusName
            // 
            this.cmbCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCusName.FormattingEnabled = true;
            this.cmbCusName.Location = new System.Drawing.Point(198, 332);
            this.cmbCusName.Name = "cmbCusName";
            this.cmbCusName.Size = new System.Drawing.Size(183, 26);
            this.cmbCusName.TabIndex = 19;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(439, 327);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(108, 34);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(20, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(192, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Look at Reservations";
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.Gray;
            this.btnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRooms.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.Color.White;
            this.btnRooms.Image = global::FootballAPPFinal.Properties.Resources.Inipagi_Job_Seeker_Room_tag;
            this.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.Location = new System.Drawing.Point(3, 303);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(182, 52);
            this.btnRooms.TabIndex = 0;
            this.btnRooms.Text = "    Rooms";
            this.btnRooms.UseVisualStyleBackColor = false;
            // 
            // btnStadiums
            // 
            this.btnStadiums.BackColor = System.Drawing.Color.Gray;
            this.btnStadiums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStadiums.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStadiums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStadiums.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStadiums.ForeColor = System.Drawing.Color.White;
            this.btnStadiums.Image = global::FootballAPPFinal.Properties.Resources.Google_Noto_Emoji_Travel_Places_42476_stadium;
            this.btnStadiums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStadiums.Location = new System.Drawing.Point(0, 200);
            this.btnStadiums.Name = "btnStadiums";
            this.btnStadiums.Size = new System.Drawing.Size(182, 52);
            this.btnStadiums.TabIndex = 0;
            this.btnStadiums.Text = "      Stadiums";
            this.btnStadiums.UseVisualStyleBackColor = false;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.BackColor = System.Drawing.Color.Gray;
            this.btnAddWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWorker.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorker.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWorker.ForeColor = System.Drawing.Color.White;
            this.btnAddWorker.Image = global::FootballAPPFinal.Properties.Resources.person_icon_UvJ_icon;
            this.btnAddWorker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddWorker.Location = new System.Drawing.Point(3, 90);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(182, 52);
            this.btnAddWorker.TabIndex = 0;
            this.btnAddWorker.Text = "      Add Worker";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::FootballAPPFinal.Properties.Resources.reservation_icon_29785;
            this.pictureBox1.Location = new System.Drawing.Point(352, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label4.Location = new System.Drawing.Point(23, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Full Name";
            // 
            // txtWFullname
            // 
            this.txtWFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWFullname.Location = new System.Drawing.Point(23, 48);
            this.txtWFullname.Name = "txtWFullname";
            this.txtWFullname.Size = new System.Drawing.Size(199, 23);
            this.txtWFullname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label5.Location = new System.Drawing.Point(23, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "User Name";
            // 
            // txtWUsername
            // 
            this.txtWUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWUsername.Location = new System.Drawing.Point(23, 116);
            this.txtWUsername.Name = "txtWUsername";
            this.txtWUsername.Size = new System.Drawing.Size(199, 23);
            this.txtWUsername.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label6.Location = new System.Drawing.Point(23, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // txtWPassword
            // 
            this.txtWPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWPassword.Location = new System.Drawing.Point(23, 193);
            this.txtWPassword.Name = "txtWPassword";
            this.txtWPassword.Size = new System.Drawing.Size(199, 23);
            this.txtWPassword.TabIndex = 2;
            this.txtWPassword.UseSystemPasswordChar = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 169);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnAddWork
            // 
            this.btnAddWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.btnAddWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWork.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWork.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWork.ForeColor = System.Drawing.Color.White;
            this.btnAddWork.Location = new System.Drawing.Point(23, 301);
            this.btnAddWork.Name = "btnAddWork";
            this.btnAddWork.Size = new System.Drawing.Size(160, 50);
            this.btnAddWork.TabIndex = 19;
            this.btnAddWork.Text = "Add Worker";
            this.btnAddWork.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label7.Location = new System.Drawing.Point(23, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Conform Password";
            // 
            // txtConPassword
            // 
            this.txtConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPassword.Location = new System.Drawing.Point(23, 267);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.Size = new System.Drawing.Size(199, 23);
            this.txtConPassword.TabIndex = 2;
            this.txtConPassword.UseSystemPasswordChar = true;
            // 
            // AdminPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(855, 562);
            this.Controls.Add(this.btnCloseAdm);
            this.Controls.Add(this.pnReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.AdminPageForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnReservation.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnAddWorker.ResumeLayout(false);
            this.pnAddWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Button btnStadiums;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseAdm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnAddWorker;
        private System.Windows.Forms.DataGridView dtgReservations;
        private System.Windows.Forms.ComboBox cmbCusName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnReservation;
        private System.Windows.Forms.TextBox txtWPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddWork;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.Label label7;
    }
}