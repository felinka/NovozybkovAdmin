
namespace NovGorAdmin
{
	partial class FormHelpLog
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
			this.lblLog = new System.Windows.Forms.Label();
			this.tbxM = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbxPL = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rbtL = new System.Windows.Forms.RadioButton();
			this.rbtP = new System.Windows.Forms.RadioButton();
			this.tbxK = new System.Windows.Forms.TextBox();
			this.lblK = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblLog
			// 
			this.lblLog.AutoSize = true;
			this.lblLog.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLog.ForeColor = System.Drawing.Color.Green;
			this.lblLog.Location = new System.Drawing.Point(361, 130);
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(253, 26);
			this.lblLog.TabIndex = 9;
			this.lblLog.Text = "Введите вашу почту e-mail";
			// 
			// tbxM
			// 
			this.tbxM.Location = new System.Drawing.Point(366, 169);
			this.tbxM.Name = "tbxM";
			this.tbxM.Size = new System.Drawing.Size(236, 22);
			this.tbxM.TabIndex = 19;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Khaki;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(399, 504);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(190, 38);
			this.button1.TabIndex = 23;
			this.button1.Text = "Отправить заявку";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbtP);
			this.groupBox1.Controls.Add(this.rbtL);
			this.groupBox1.Location = new System.Drawing.Point(704, 240);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "выберите, что ввести";
			// 
			// tbxPL
			// 
			this.tbxPL.Location = new System.Drawing.Point(372, 279);
			this.tbxPL.Name = "tbxPL";
			this.tbxPL.Size = new System.Drawing.Size(236, 22);
			this.tbxPL.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(394, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 26);
			this.label1.TabIndex = 25;
			this.label1.Text = "Введите ваш логин\r\n";
			// 
			// rbtL
			// 
			this.rbtL.AutoSize = true;
			this.rbtL.Checked = true;
			this.rbtL.Location = new System.Drawing.Point(21, 30);
			this.rbtL.Name = "rbtL";
			this.rbtL.Size = new System.Drawing.Size(68, 21);
			this.rbtL.TabIndex = 0;
			this.rbtL.TabStop = true;
			this.rbtL.Text = "Логин";
			this.rbtL.UseVisualStyleBackColor = true;
			this.rbtL.CheckedChanged += new System.EventHandler(this.rbtL_CheckedChanged);
			// 
			// rbtP
			// 
			this.rbtP.AutoSize = true;
			this.rbtP.Location = new System.Drawing.Point(21, 63);
			this.rbtP.Name = "rbtP";
			this.rbtP.Size = new System.Drawing.Size(78, 21);
			this.rbtP.TabIndex = 1;
			this.rbtP.Text = "Пароль";
			this.rbtP.UseVisualStyleBackColor = true;
			this.rbtP.CheckedChanged += new System.EventHandler(this.rbtP_CheckedChanged);
			// 
			// tbxK
			// 
			this.tbxK.Location = new System.Drawing.Point(372, 378);
			this.tbxK.Name = "tbxK";
			this.tbxK.Size = new System.Drawing.Size(236, 22);
			this.tbxK.TabIndex = 28;
			this.tbxK.Visible = false;
			this.tbxK.WordWrap = false;
			// 
			// lblK
			// 
			this.lblK.AutoSize = true;
			this.lblK.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblK.ForeColor = System.Drawing.Color.Green;
			this.lblK.Location = new System.Drawing.Point(386, 338);
			this.lblK.Name = "lblK";
			this.lblK.Size = new System.Drawing.Size(203, 26);
			this.lblK.TabIndex = 27;
			this.lblK.Text = "Код из письма e-mail";
			this.lblK.Visible = false;
			// 
			// FormHelpLog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1014, 582);
			this.Controls.Add(this.tbxK);
			this.Controls.Add(this.lblK);
			this.Controls.Add(this.tbxPL);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tbxM);
			this.Controls.Add(this.lblLog);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "FormHelpLog";
			this.Text = "Помощь с восстановлением доступа";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLog;
		private System.Windows.Forms.TextBox tbxM;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbtP;
		private System.Windows.Forms.RadioButton rbtL;
		private System.Windows.Forms.TextBox tbxPL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxK;
		private System.Windows.Forms.Label lblK;
	}
}