
namespace NovGorAdmin
{
	partial class FormOthers
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
			this.components = new System.ComponentModel.Container();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.lblID = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelShadow = new System.Windows.Forms.Panel();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.BtnMin = new FontAwesome.Sharp.IconPictureBox();
			this.btnExit = new FontAwesome.Sharp.IconPictureBox();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.iconButton3 = new FontAwesome.Sharp.IconButton();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblT = new System.Windows.Forms.Label();
			this.panelDesktop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.panelMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.panelDesktop.Controls.Add(this.lblT);
			this.panelDesktop.Controls.Add(this.lblID);
			this.panelDesktop.Controls.Add(this.label3);
			this.panelDesktop.Controls.Add(this.pictureBox2);
			this.panelDesktop.Controls.Add(this.panel1);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(251, 85);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(1367, 773);
			this.panelDesktop.TabIndex = 8;
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblID.Location = new System.Drawing.Point(31, 28);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(91, 28);
			this.lblID.TabIndex = 8;
			this.lblID.Text = "Сейчас: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(287, 348);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(201, 61);
			this.label3.TabIndex = 7;
			this.label3.Text = "Сейчас: ";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::NovGorAdmin.Properties.Resources.flagNVZ;
			this.pictureBox2.Location = new System.Drawing.Point(415, 96);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(211, 100);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(5, 773);
			this.panel1.TabIndex = 4;
			// 
			// panelShadow
			// 
			this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
			this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelShadow.Location = new System.Drawing.Point(251, 80);
			this.panelShadow.Name = "panelShadow";
			this.panelShadow.Size = new System.Drawing.Size(1367, 5);
			this.panelShadow.TabIndex = 7;
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.SeaGreen;
			this.panelTitleBar.Controls.Add(this.BtnMin);
			this.panelTitleBar.Controls.Add(this.btnExit);
			this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
			this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(251, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(1367, 80);
			this.panelTitleBar.TabIndex = 6;
			this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
			// 
			// BtnMin
			// 
			this.BtnMin.BackColor = System.Drawing.Color.SeaGreen;
			this.BtnMin.ForeColor = System.Drawing.Color.Gainsboro;
			this.BtnMin.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.BtnMin.IconColor = System.Drawing.Color.Gainsboro;
			this.BtnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.BtnMin.IconSize = 29;
			this.BtnMin.Location = new System.Drawing.Point(1277, 3);
			this.BtnMin.Name = "BtnMin";
			this.BtnMin.Size = new System.Drawing.Size(32, 29);
			this.BtnMin.TabIndex = 3;
			this.BtnMin.TabStop = false;
			this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.SeaGreen;
			this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Ban;
			this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
			this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnExit.IconSize = 29;
			this.btnExit.Location = new System.Drawing.Point(1315, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(32, 29);
			this.btnExit.TabIndex = 2;
			this.btnExit.TabStop = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblTitleChildForm
			// 
			this.lblTitleChildForm.AutoSize = true;
			this.lblTitleChildForm.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleChildForm.ForeColor = System.Drawing.Color.Khaki;
			this.lblTitleChildForm.Location = new System.Drawing.Point(64, 30);
			this.lblTitleChildForm.Name = "lblTitleChildForm";
			this.lblTitleChildForm.Size = new System.Drawing.Size(58, 19);
			this.lblTitleChildForm.TabIndex = 1;
			this.lblTitleChildForm.Text = "Начало";
			// 
			// iconCurrentChildForm
			// 
			this.iconCurrentChildForm.BackColor = System.Drawing.Color.SeaGreen;
			this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Khaki;
			this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.iconCurrentChildForm.IconColor = System.Drawing.Color.Khaki;
			this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconCurrentChildForm.IconSize = 40;
			this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 21);
			this.iconCurrentChildForm.Name = "iconCurrentChildForm";
			this.iconCurrentChildForm.Size = new System.Drawing.Size(47, 40);
			this.iconCurrentChildForm.TabIndex = 0;
			this.iconCurrentChildForm.TabStop = false;
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.SeaGreen;
			this.panelMenu.Controls.Add(this.iconButton3);
			this.panelMenu.Controls.Add(this.iconButton2);
			this.panelMenu.Controls.Add(this.iconButton1);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(251, 858);
			this.panelMenu.TabIndex = 5;
			// 
			// iconButton3
			// 
			this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton3.FlatAppearance.BorderSize = 0;
			this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.At;
			this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton3.IconSize = 32;
			this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton3.Location = new System.Drawing.Point(0, 281);
			this.iconButton3.Name = "iconButton3";
			this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButton3.Size = new System.Drawing.Size(251, 60);
			this.iconButton3.TabIndex = 2;
			this.iconButton3.Text = "От Начальника";
			this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton3.UseVisualStyleBackColor = true;
			this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
			// 
			// iconButton2
			// 
			this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton2.FlatAppearance.BorderSize = 0;
			this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
			this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton2.IconSize = 32;
			this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton2.Location = new System.Drawing.Point(0, 221);
			this.iconButton2.Name = "iconButton2";
			this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButton2.Size = new System.Drawing.Size(251, 60);
			this.iconButton2.TabIndex = 1;
			this.iconButton2.Text = "К программисту";
			this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton2.UseVisualStyleBackColor = true;
			this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
			// 
			// iconButton1
			// 
			this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Portrait;
			this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 32;
			this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton1.Location = new System.Drawing.Point(0, 161);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButton1.Size = new System.Drawing.Size(251, 60);
			this.iconButton1.TabIndex = 0;
			this.iconButton1.Text = "Профиль";
			this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton1.UseVisualStyleBackColor = true;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.label1);
			this.panelLogo.Controls.Add(this.pictureBox1);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(251, 161);
			this.panelLogo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Khaki;
			this.label1.Location = new System.Drawing.Point(32, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 57);
			this.label1.TabIndex = 1;
			this.label1.Text = "Новозыбковская \r\nгородская \r\nадминистрация\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::NovGorAdmin.Properties.Resources.flagNVZ;
			this.pictureBox1.Location = new System.Drawing.Point(66, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 59);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblT
			// 
			this.lblT.AutoSize = true;
			this.lblT.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblT.ForeColor = System.Drawing.Color.Olive;
			this.lblT.Location = new System.Drawing.Point(542, 348);
			this.lblT.Name = "lblT";
			this.lblT.Size = new System.Drawing.Size(0, 61);
			this.lblT.TabIndex = 9;
			// 
			// FormOthers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1618, 858);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelShadow);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panelMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormOthers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormOthers";
			this.panelDesktop.ResumeLayout(false);
			this.panelDesktop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
			this.panelMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelLogo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelDesktop;
		public System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelShadow;
		private System.Windows.Forms.Panel panelTitleBar;
		private FontAwesome.Sharp.IconPictureBox BtnMin;
		private FontAwesome.Sharp.IconPictureBox btnExit;
		private System.Windows.Forms.Label lblTitleChildForm;
		private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
		private System.Windows.Forms.Panel panelMenu;
		private FontAwesome.Sharp.IconButton iconButton3;
		private FontAwesome.Sharp.IconButton iconButton2;
		private FontAwesome.Sharp.IconButton iconButton1;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblT;
	}
}