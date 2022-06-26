
namespace NovGorAdmin
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxLog = new System.Windows.Forms.TextBox();
			this.lblLog = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelShadow = new System.Windows.Forms.Panel();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.panelDesktop.SuspendLayout();
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.panelMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.panelDesktop.Controls.Add(this.button2);
			this.panelDesktop.Controls.Add(this.textBox1);
			this.panelDesktop.Controls.Add(this.label3);
			this.panelDesktop.Controls.Add(this.tbxPass);
			this.panelDesktop.Controls.Add(this.label2);
			this.panelDesktop.Controls.Add(this.tbxLog);
			this.panelDesktop.Controls.Add(this.lblLog);
			this.panelDesktop.Controls.Add(this.button1);
			this.panelDesktop.Controls.Add(this.panel1);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(258, 85);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(1047, 634);
			this.panelDesktop.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Khaki;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.button2.Location = new System.Drawing.Point(418, 323);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 30);
			this.button2.TabIndex = 16;
			this.button2.Text = "Запросить";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(365, 295);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(245, 22);
			this.textBox1.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Location = new System.Drawing.Point(420, 252);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 26);
			this.label3.TabIndex = 14;
			this.label3.Text = "Код из e-mail";
			// 
			// tbxPass
			// 
			this.tbxPass.Location = new System.Drawing.Point(365, 209);
			this.tbxPass.Name = "tbxPass";
			this.tbxPass.Size = new System.Drawing.Size(245, 22);
			this.tbxPass.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Green;
			this.label2.Location = new System.Drawing.Point(445, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 26);
			this.label2.TabIndex = 12;
			this.label2.Text = "Пароль";
			// 
			// tbxLog
			// 
			this.tbxLog.Location = new System.Drawing.Point(361, 127);
			this.tbxLog.Name = "tbxLog";
			this.tbxLog.Size = new System.Drawing.Size(245, 22);
			this.tbxLog.TabIndex = 9;
			// 
			// lblLog
			// 
			this.lblLog.AutoSize = true;
			this.lblLog.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLog.ForeColor = System.Drawing.Color.Green;
			this.lblLog.Location = new System.Drawing.Point(445, 84);
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(69, 26);
			this.lblLog.TabIndex = 8;
			this.lblLog.Text = "Логин";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Khaki;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(425, 460);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 38);
			this.button1.TabIndex = 5;
			this.button1.Text = "Вход";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(5, 634);
			this.panel1.TabIndex = 4;
			// 
			// panelShadow
			// 
			this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
			this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelShadow.Location = new System.Drawing.Point(258, 80);
			this.panelShadow.Name = "panelShadow";
			this.panelShadow.Size = new System.Drawing.Size(1047, 5);
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
			this.panelTitleBar.Location = new System.Drawing.Point(258, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(1047, 80);
			this.panelTitleBar.TabIndex = 6;
			this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
			// 
			// iconPictureBox1
			// 
			this.iconPictureBox1.BackColor = System.Drawing.Color.SeaGreen;
			this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
			this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox1.IconSize = 29;
			this.iconPictureBox1.Location = new System.Drawing.Point(969, 3);
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
			this.iconPictureBox2.Location = new System.Drawing.Point(1007, 3);
			this.iconPictureBox2.Name = "iconPictureBox2";
			this.iconPictureBox2.Size = new System.Drawing.Size(32, 29);
			this.iconPictureBox2.TabIndex = 4;
			this.iconPictureBox2.TabStop = false;
			this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
			// 
			// lblTitleChildForm
			// 
			this.lblTitleChildForm.AutoSize = true;
			this.lblTitleChildForm.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleChildForm.ForeColor = System.Drawing.Color.Khaki;
			this.lblTitleChildForm.Location = new System.Drawing.Point(64, 30);
			this.lblTitleChildForm.Name = "lblTitleChildForm";
			this.lblTitleChildForm.Size = new System.Drawing.Size(94, 19);
			this.lblTitleChildForm.TabIndex = 1;
			this.lblTitleChildForm.Text = "Авторизация";
			// 
			// iconCurrentChildForm
			// 
			this.iconCurrentChildForm.BackColor = System.Drawing.Color.SeaGreen;
			this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Khaki;
			this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
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
			this.panelMenu.Controls.Add(this.iconButton2);
			this.panelMenu.Controls.Add(this.iconButton1);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(258, 719);
			this.panelMenu.TabIndex = 5;
			// 
			// iconButton1
			// 
			this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Headset;
			this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 32;
			this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton1.Location = new System.Drawing.Point(0, 161);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButton1.Size = new System.Drawing.Size(258, 60);
			this.iconButton1.TabIndex = 0;
			this.iconButton1.Text = "Нужна помощь?";
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
			this.panelLogo.Size = new System.Drawing.Size(258, 161);
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
			// iconButton2
			// 
			this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton2.FlatAppearance.BorderSize = 0;
			this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Hotel;
			this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton2.IconSize = 32;
			this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton2.Location = new System.Drawing.Point(0, 221);
			this.iconButton2.Name = "iconButton2";
			this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButton2.Size = new System.Drawing.Size(258, 60);
			this.iconButton2.TabIndex = 1;
			this.iconButton2.Text = "Авторизация";
			this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton2.UseVisualStyleBackColor = true;
			this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1305, 719);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelShadow);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panelMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.panelDesktop.ResumeLayout(false);
			this.panelDesktop.PerformLayout();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
			this.panelMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelLogo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelDesktop;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelShadow;
		private System.Windows.Forms.Panel panelTitleBar;
		private System.Windows.Forms.Label lblTitleChildForm;
		private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
		private System.Windows.Forms.Panel panelMenu;
		private FontAwesome.Sharp.IconButton iconButton1;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbxLog;
		private System.Windows.Forms.Label lblLog;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxPass;
		private System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.IconButton iconButton2;
	}
}

