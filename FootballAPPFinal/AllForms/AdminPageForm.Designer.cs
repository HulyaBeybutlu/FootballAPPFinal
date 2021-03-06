﻿namespace FootballAPPFinal.AllForms
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
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnStadiums = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.pnRooms = new System.Windows.Forms.Panel();
            this.lblErrorRoom = new System.Windows.Forms.Label();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dtgRooms = new System.Windows.Forms.DataGridView();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgReservations = new System.Windows.Forms.DataGridView();
            this.pnAddWorker = new System.Windows.Forms.Panel();
            this.lblErrorWorker = new System.Windows.Forms.Label();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.btnEditWorker = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgWorkers = new System.Windows.Forms.DataGridView();
            this.btnAddWork = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnStadiums = new System.Windows.Forms.Panel();
            this.lblErrorStadium = new System.Windows.Forms.Label();
            this.btnDeleteSt = new System.Windows.Forms.Button();
            this.btnEditSt = new System.Windows.Forms.Button();
            this.nmStPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAddStadium = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgStadiums = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pnReservation = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCloseAdm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservations)).BeginInit();
            this.pnAddWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgWorkers)).BeginInit();
            this.pnStadiums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmStPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStadiums)).BeginInit();
            this.pnReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnRooms);
            this.panel1.Controls.Add(this.btnStadiums);
            this.panel1.Controls.Add(this.btnWorkers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 620);
            this.panel1.TabIndex = 0;
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
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
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
            this.btnStadiums.Click += new System.EventHandler(this.btnStadiums_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.BackColor = System.Drawing.Color.Gray;
            this.btnWorkers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorkers.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkers.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkers.ForeColor = System.Drawing.Color.White;
            this.btnWorkers.Image = global::FootballAPPFinal.Properties.Resources.person_icon_UvJ_icon;
            this.btnWorkers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkers.Location = new System.Drawing.Point(3, 90);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(182, 52);
            this.btnWorkers.TabIndex = 0;
            this.btnWorkers.Text = "      Workers";
            this.btnWorkers.UseVisualStyleBackColor = false;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // pnRooms
            // 
            this.pnRooms.Controls.Add(this.lblErrorRoom);
            this.pnRooms.Controls.Add(this.btnEditRoom);
            this.pnRooms.Controls.Add(this.btnDeleteRoom);
            this.pnRooms.Controls.Add(this.btnAddRoom);
            this.pnRooms.Controls.Add(this.dtgRooms);
            this.pnRooms.Controls.Add(this.txtCapacity);
            this.pnRooms.Controls.Add(this.label12);
            this.pnRooms.Controls.Add(this.txtRoomNum);
            this.pnRooms.Controls.Add(this.label11);
            this.pnRooms.Controls.Add(this.label10);
            this.pnRooms.Location = new System.Drawing.Point(199, 72);
            this.pnRooms.Name = "pnRooms";
            this.pnRooms.Size = new System.Drawing.Size(649, 547);
            this.pnRooms.TabIndex = 13;
            this.pnRooms.Visible = false;
            // 
            // lblErrorRoom
            // 
            this.lblErrorRoom.AutoSize = true;
            this.lblErrorRoom.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRoom.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrorRoom.Location = new System.Drawing.Point(327, 176);
            this.lblErrorRoom.Name = "lblErrorRoom";
            this.lblErrorRoom.Size = new System.Drawing.Size(89, 16);
            this.lblErrorRoom.TabIndex = 13;
            this.lblErrorRoom.Text = "Capacity";
            this.lblErrorRoom.Visible = false;
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.BackColor = System.Drawing.Color.Olive;
            this.btnEditRoom.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoom.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRoom.ForeColor = System.Drawing.Color.White;
            this.btnEditRoom.Location = new System.Drawing.Point(325, 229);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(105, 51);
            this.btnEditRoom.TabIndex = 12;
            this.btnEditRoom.Text = "Edit";
            this.btnEditRoom.UseVisualStyleBackColor = false;
            this.btnEditRoom.Visible = false;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteRoom.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.Location = new System.Drawing.Point(499, 231);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(105, 51);
            this.btnDeleteRoom.TabIndex = 11;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Visible = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.btnAddRoom.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(325, 246);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(105, 51);
            this.btnAddRoom.TabIndex = 10;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // dtgRooms
            // 
            this.dtgRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRooms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgRooms.Location = new System.Drawing.Point(0, 383);
            this.dtgRooms.Name = "dtgRooms";
            this.dtgRooms.Size = new System.Drawing.Size(649, 164);
            this.dtgRooms.TabIndex = 9;
            this.dtgRooms.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgRooms_RowHeaderMouseDoubleClick);
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(33, 258);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(182, 24);
            this.txtCapacity.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label12.Location = new System.Drawing.Point(28, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 28);
            this.label12.TabIndex = 7;
            this.label12.Text = "Capacity";
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNum.Location = new System.Drawing.Point(33, 130);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(182, 24);
            this.txtRoomNum.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label11.Location = new System.Drawing.Point(28, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 28);
            this.label11.TabIndex = 5;
            this.label11.Text = "Room Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(118)))));
            this.label10.Location = new System.Drawing.Point(285, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Rooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(425, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME, ADMIN!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(179, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Look at Reservations";
            // 
            // dtgReservations
            // 
            this.dtgReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgReservations.Location = new System.Drawing.Point(0, 345);
            this.dtgReservations.Name = "dtgReservations";
            this.dtgReservations.Size = new System.Drawing.Size(689, 169);
            this.dtgReservations.TabIndex = 2;
            // 
            // pnAddWorker
            // 
            this.pnAddWorker.Controls.Add(this.lblErrorWorker);
            this.pnAddWorker.Controls.Add(this.btnDeleteWorker);
            this.pnAddWorker.Controls.Add(this.btnEditWorker);
            this.pnAddWorker.Controls.Add(this.label6);
            this.pnAddWorker.Controls.Add(this.dtgWorkers);
            this.pnAddWorker.Controls.Add(this.btnAddWork);
            this.pnAddWorker.Controls.Add(this.txtPassword);
            this.pnAddWorker.Controls.Add(this.label5);
            this.pnAddWorker.Controls.Add(this.txtUserName);
            this.pnAddWorker.Controls.Add(this.label4);
            this.pnAddWorker.Controls.Add(this.txtFullName);
            this.pnAddWorker.Controls.Add(this.label3);
            this.pnAddWorker.Location = new System.Drawing.Point(207, 39);
            this.pnAddWorker.Name = "pnAddWorker";
            this.pnAddWorker.Size = new System.Drawing.Size(638, 537);
            this.pnAddWorker.TabIndex = 63;
            this.pnAddWorker.Visible = false;
            // 
            // lblErrorWorker
            // 
            this.lblErrorWorker.AutoSize = true;
            this.lblErrorWorker.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorWorker.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrorWorker.Location = new System.Drawing.Point(295, 229);
            this.lblErrorWorker.Name = "lblErrorWorker";
            this.lblErrorWorker.Size = new System.Drawing.Size(81, 15);
            this.lblErrorWorker.TabIndex = 7;
            this.lblErrorWorker.Text = "Password";
            this.lblErrorWorker.Visible = false;
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteWorker.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDeleteWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWorker.Font = new System.Drawing.Font("Jokerman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWorker.ForeColor = System.Drawing.Color.White;
            this.btnDeleteWorker.Location = new System.Drawing.Point(255, 285);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(100, 52);
            this.btnDeleteWorker.TabIndex = 6;
            this.btnDeleteWorker.Text = "Delete";
            this.btnDeleteWorker.UseVisualStyleBackColor = false;
            this.btnDeleteWorker.Visible = false;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click);
            // 
            // btnEditWorker
            // 
            this.btnEditWorker.BackColor = System.Drawing.Color.Olive;
            this.btnEditWorker.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEditWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditWorker.Font = new System.Drawing.Font("Jokerman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditWorker.ForeColor = System.Drawing.Color.White;
            this.btnEditWorker.Location = new System.Drawing.Point(54, 285);
            this.btnEditWorker.Name = "btnEditWorker";
            this.btnEditWorker.Size = new System.Drawing.Size(102, 52);
            this.btnEditWorker.TabIndex = 5;
            this.btnEditWorker.Text = "Edit";
            this.btnEditWorker.UseVisualStyleBackColor = false;
            this.btnEditWorker.Visible = false;
            this.btnEditWorker.Click += new System.EventHandler(this.btnEditWorker_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(118)))));
            this.label6.Location = new System.Drawing.Point(275, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Workers";
            // 
            // dtgWorkers
            // 
            this.dtgWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgWorkers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgWorkers.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgWorkers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgWorkers.Location = new System.Drawing.Point(0, 370);
            this.dtgWorkers.Name = "dtgWorkers";
            this.dtgWorkers.Size = new System.Drawing.Size(638, 167);
            this.dtgWorkers.TabIndex = 3;
            this.dtgWorkers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgWorkers_RowHeaderMouseDoubleClick);
            // 
            // btnAddWork
            // 
            this.btnAddWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.btnAddWork.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAddWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWork.Font = new System.Drawing.Font("Jokerman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWork.ForeColor = System.Drawing.Color.White;
            this.btnAddWork.Location = new System.Drawing.Point(54, 285);
            this.btnAddWork.Name = "btnAddWork";
            this.btnAddWork.Size = new System.Drawing.Size(159, 52);
            this.btnAddWork.TabIndex = 2;
            this.btnAddWork.Text = "Add Worker";
            this.btnAddWork.UseVisualStyleBackColor = false;
            this.btnAddWork.Click += new System.EventHandler(this.btnAddWork_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(54, 229);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 24);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label5.Location = new System.Drawing.Point(50, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(54, 158);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 24);
            this.txtUserName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label4.Location = new System.Drawing.Point(50, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(54, 83);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(180, 24);
            this.txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(50, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full Name";
            // 
            // pnStadiums
            // 
            this.pnStadiums.Controls.Add(this.lblErrorStadium);
            this.pnStadiums.Controls.Add(this.btnDeleteSt);
            this.pnStadiums.Controls.Add(this.btnEditSt);
            this.pnStadiums.Controls.Add(this.nmStPrice);
            this.pnStadiums.Controls.Add(this.btnAddStadium);
            this.pnStadiums.Controls.Add(this.label9);
            this.pnStadiums.Controls.Add(this.txtStName);
            this.pnStadiums.Controls.Add(this.label8);
            this.pnStadiums.Controls.Add(this.dtgStadiums);
            this.pnStadiums.Controls.Add(this.label7);
            this.pnStadiums.Location = new System.Drawing.Point(193, 50);
            this.pnStadiums.Name = "pnStadiums";
            this.pnStadiums.Size = new System.Drawing.Size(692, 514);
            this.pnStadiums.TabIndex = 8;
            this.pnStadiums.Visible = false;
            // 
            // lblErrorStadium
            // 
            this.lblErrorStadium.AutoSize = true;
            this.lblErrorStadium.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStadium.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrorStadium.Location = new System.Drawing.Point(367, 126);
            this.lblErrorStadium.Name = "lblErrorStadium";
            this.lblErrorStadium.Size = new System.Drawing.Size(126, 16);
            this.lblErrorStadium.TabIndex = 12;
            this.lblErrorStadium.Text = "Stadium Name";
            this.lblErrorStadium.Visible = false;
            // 
            // btnDeleteSt
            // 
            this.btnDeleteSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteSt.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDeleteSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSt.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSt.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSt.Location = new System.Drawing.Point(543, 237);
            this.btnDeleteSt.Name = "btnDeleteSt";
            this.btnDeleteSt.Size = new System.Drawing.Size(115, 47);
            this.btnDeleteSt.TabIndex = 11;
            this.btnDeleteSt.Text = "Delete";
            this.btnDeleteSt.UseVisualStyleBackColor = false;
            this.btnDeleteSt.Visible = false;
            this.btnDeleteSt.Click += new System.EventHandler(this.btnDeleteSt_Click);
            // 
            // btnEditSt
            // 
            this.btnEditSt.BackColor = System.Drawing.Color.Olive;
            this.btnEditSt.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEditSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSt.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSt.ForeColor = System.Drawing.Color.White;
            this.btnEditSt.Location = new System.Drawing.Point(378, 238);
            this.btnEditSt.Name = "btnEditSt";
            this.btnEditSt.Size = new System.Drawing.Size(115, 47);
            this.btnEditSt.TabIndex = 10;
            this.btnEditSt.Text = "Edit";
            this.btnEditSt.UseVisualStyleBackColor = false;
            this.btnEditSt.Visible = false;
            this.btnEditSt.Click += new System.EventHandler(this.btnEditSt_Click);
            // 
            // nmStPrice
            // 
            this.nmStPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmStPrice.Location = new System.Drawing.Point(33, 259);
            this.nmStPrice.Name = "nmStPrice";
            this.nmStPrice.Size = new System.Drawing.Size(207, 26);
            this.nmStPrice.TabIndex = 9;
            // 
            // btnAddStadium
            // 
            this.btnAddStadium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.btnAddStadium.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAddStadium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStadium.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStadium.ForeColor = System.Drawing.Color.White;
            this.btnAddStadium.Location = new System.Drawing.Point(543, 249);
            this.btnAddStadium.Name = "btnAddStadium";
            this.btnAddStadium.Size = new System.Drawing.Size(115, 47);
            this.btnAddStadium.TabIndex = 8;
            this.btnAddStadium.Text = "Add new Stadium";
            this.btnAddStadium.UseVisualStyleBackColor = false;
            this.btnAddStadium.Click += new System.EventHandler(this.btnAddStadium_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label9.Location = new System.Drawing.Point(28, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "Stadium Price";
            // 
            // txtStName
            // 
            this.txtStName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStName.Location = new System.Drawing.Point(28, 125);
            this.txtStName.Name = "txtStName";
            this.txtStName.Size = new System.Drawing.Size(212, 26);
            this.txtStName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.label8.Location = new System.Drawing.Point(28, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Stadium Name";
            // 
            // dtgStadiums
            // 
            this.dtgStadiums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStadiums.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgStadiums.Location = new System.Drawing.Point(0, 347);
            this.dtgStadiums.Name = "dtgStadiums";
            this.dtgStadiums.Size = new System.Drawing.Size(692, 167);
            this.dtgStadiums.TabIndex = 5;
            this.dtgStadiums.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgStadiums_RowHeaderMouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(118)))));
            this.label7.Location = new System.Drawing.Point(275, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Stadiums";
            // 
            // pnReservation
            // 
            this.pnReservation.Controls.Add(this.dtgReservations);
            this.pnReservation.Controls.Add(this.pictureBox1);
            this.pnReservation.Controls.Add(this.label2);
            this.pnReservation.Location = new System.Drawing.Point(202, 44);
            this.pnReservation.Name = "pnReservation";
            this.pnReservation.Size = new System.Drawing.Size(689, 514);
            this.pnReservation.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::FootballAPPFinal.Properties.Resources.Icons8_Ios7_Arrows_Back;
            this.button1.Location = new System.Drawing.Point(202, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 32);
            this.button1.TabIndex = 64;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCloseAdm
            // 
            this.btnCloseAdm.BackColor = System.Drawing.Color.LightGray;
            this.btnCloseAdm.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCloseAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAdm.Image = global::FootballAPPFinal.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back;
            this.btnCloseAdm.Location = new System.Drawing.Point(857, 0);
            this.btnCloseAdm.Name = "btnCloseAdm";
            this.btnCloseAdm.Size = new System.Drawing.Size(34, 33);
            this.btnCloseAdm.TabIndex = 60;
            this.btnCloseAdm.UseVisualStyleBackColor = false;
            this.btnCloseAdm.Click += new System.EventHandler(this.btnCloseAdm_Click);
            // 
            // AdminPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(901, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnStadiums);
            this.Controls.Add(this.pnAddWorker);
            this.Controls.Add(this.pnRooms);
            this.Controls.Add(this.pnReservation);
            this.Controls.Add(this.btnCloseAdm);
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
            this.pnRooms.ResumeLayout(false);
            this.pnRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservations)).EndInit();
            this.pnAddWorker.ResumeLayout(false);
            this.pnAddWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgWorkers)).EndInit();
            this.pnStadiums.ResumeLayout(false);
            this.pnStadiums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmStPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStadiums)).EndInit();
            this.pnReservation.ResumeLayout(false);
            this.pnReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnStadiums;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseAdm;
        private System.Windows.Forms.Panel pnRooms;
        private System.Windows.Forms.DataGridView dtgRooms;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label lblErrorRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgReservations;
        private System.Windows.Forms.Panel pnAddWorker;
        private System.Windows.Forms.Panel pnStadiums;
        private System.Windows.Forms.Label lblErrorStadium;
        private System.Windows.Forms.Button btnDeleteSt;
        private System.Windows.Forms.Button btnEditSt;
        private System.Windows.Forms.NumericUpDown nmStPrice;
        private System.Windows.Forms.Button btnAddStadium;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgStadiums;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblErrorWorker;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Button btnEditWorker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgWorkers;
        private System.Windows.Forms.Button btnAddWork;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnReservation;
        private System.Windows.Forms.Button button1;
    }
}