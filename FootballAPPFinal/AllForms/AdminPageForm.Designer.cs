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
            this.dtgReports = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnStadiums = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReports)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnRooms);
            this.panel1.Controls.Add(this.btnStadiums);
            this.panel1.Controls.Add(this.btnAddWorker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 514);
            this.panel1.TabIndex = 0;
            // 
            // dtgReports
            // 
            this.dtgReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgReports.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReports.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgReports.Location = new System.Drawing.Point(188, 303);
            this.dtgReports.Name = "dtgReports";
            this.dtgReports.Size = new System.Drawing.Size(560, 211);
            this.dtgReports.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 273);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(183, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Look at Reports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(178, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME, ADMIN!";
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
            // 
            // AdminPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(748, 514);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgReports);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReports)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Button btnStadiums;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.DataGridView dtgReports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}