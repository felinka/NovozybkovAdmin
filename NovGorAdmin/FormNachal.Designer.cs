﻿
namespace NovGorAdmin
{
	partial class FormNachal
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
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.lblID = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelShadow = new System.Windows.Forms.Panel();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
			this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.iconButton6 = new FontAwesome.Sharp.IconButton();
			this.iconButton5 = new FontAwesome.Sharp.IconButton();
			this.iconButton4 = new FontAwesome.Sharp.IconButton();
			this.iconButton3 = new FontAwesome.Sharp.IconButton();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelDesktop.SuspendLayout();
			this.panelTitleBar.SuspendLayout();
			this.panelMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.panelDesktop.Controls.Add(this.lblID);
			this.panelDesktop.Controls.Add(this.label3);
			this.panelDesktop.Controls.Add(this.pictureBox2);
			this.panelDesktop.Controls.Add(this.panel1);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(251, 85);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(1362, 725);
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
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(314, 256);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 28);
			this.label3.TabIndex = 7;
			this.label3.Text = "Сейчас: ";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(5, 725);
			this.panel1.TabIndex = 4;
			// 
			// panelShadow
			// 
			this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
			this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelShadow.Location = new System.Drawing.Point(251, 80);
			this.panelShadow.Name = "panelShadow";
			this.panelShadow.Size = new System.Drawing.Size(1362, 5);
			this.panelShadow.TabIndex = 7;
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.SeaGreen;
			this.panelTitleBar.Controls.Add(this.iconPictureBox1);
			this.panelTitleBar.Controls.Add(this.iconPictureBox2);
			this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
			this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(251, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(1362, 80);
			this.panelTitleBar.TabIndex = 6;
			this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.SeaGreen;
			this.panelMenu.Controls.Add(this.iconButton6);
			this.panelMenu.Controls.Add(this.iconButton5);
			this.panelMenu.Controls.Add(this.iconButton4);
			this.panelMenu.Controls.Add(this.iconButton3);
			this.panelMenu.Controls.Add(this.iconButton2);
			this.panelMenu.Controls.Add(this.iconButton1);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(251, 810);
			this.panelMenu.TabIndex = 5;
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
			// iconPictureBox1
			// 
			this.iconPictureBox1.BackColor = System.Drawing.Color.SeaGreen;
			this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
			this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox1.IconSize = 29;
			this.iconPictureBox1.Location = new System.Drawing.Point(1285, 3);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(32, 29);
			this.iconPictureBox1.TabIndex = 5;
			this.iconPictureBox1.TabStop = false;
			this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
			// 
			// iconPictureBox2
			// 
			this.iconPictureBox2.BackColor = System.Drawing.Color.SeaGreen;
			this.iconPictureBox2.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Ban;
			this.iconPictureBox2.IconColor = System.Drawing.Color.Gainsboro;
			this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox2.IconSize = 29;
			this.iconPictureBox2.Location = new System.Drawing.Point(1323, 3);
			this.iconPictureBox2.Name = "iconPictureBox2";
			this.iconPictureBox2.Size = new System.Drawing.Size(32, 29);
			this.iconPictureBox2.TabIndex = 4;
			this.iconPictureBox2.TabStop = false;
			this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
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
			// iconButton6
			// 
			this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton6.FlatAppearance.BorderSize = 0;
			this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton6.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Poo;
			this.iconButton6.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton6.IconSize = 32;
			this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton6.Location = new System.Drawing.Point(0, 461);
			this.iconButton6.Name = "iconButton6";
			this.iconButton6.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButton6.Size = new System.Drawing.Size(251, 60);
			this.iconButton6.TabIndex = 5;
			this.iconButton6.Text = "О, кнопочка!";
			this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton6.UseVisualStyleBackColor = true;
			// 
			// iconButton5
			// 
			this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton5.FlatAppearance.BorderSize = 0;
			this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Egg;
			this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton5.IconSize = 32;
			this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton5.Location = new System.Drawing.Point(0, 401);
			this.iconButton5.Name = "iconButton5";
			this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButton5.Size = new System.Drawing.Size(251, 60);
			this.iconButton5.TabIndex = 4;
			this.iconButton5.Text = "А что это?";
			this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton5.UseVisualStyleBackColor = true;
			// 
			// iconButton4
			// 
			this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton4.FlatAppearance.BorderSize = 0;
			this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton4.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Bars;
			this.iconButton4.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton4.IconSize = 32;
			this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton4.Location = new System.Drawing.Point(0, 341);
			this.iconButton4.Name = "iconButton4";
			this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButton4.Size = new System.Drawing.Size(251, 60);
			this.iconButton4.TabIndex = 3;
			this.iconButton4.Text = " Профили\r\n работников";
			this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton4.UseVisualStyleBackColor = true;
			this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
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
			this.iconButton3.Text = "Вызов работника";
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
			this.iconButton1.Text = "Мой профиль";
			this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton1.UseVisualStyleBackColor = true;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
			// 
			// FormNachal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1613, 810);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelShadow);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panelMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormNachal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormNachal";
			this.panelDesktop.ResumeLayout(false);
			this.panelDesktop.PerformLayout();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			this.panelMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelLogo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
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
		private System.Windows.Forms.Label lblTitleChildForm;
		private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
		private System.Windows.Forms.Panel panelMenu;
		private FontAwesome.Sharp.IconButton iconButton6;
		private FontAwesome.Sharp.IconButton iconButton5;
		private FontAwesome.Sharp.IconButton iconButton4;
		private FontAwesome.Sharp.IconButton iconButton3;
		private FontAwesome.Sharp.IconButton iconButton2;
		private FontAwesome.Sharp.IconButton iconButton1;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
	}
}