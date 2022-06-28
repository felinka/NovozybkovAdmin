
namespace NovGorAdmin
{
	partial class FormAddAc
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
			this.button1 = new System.Windows.Forms.Button();
			this.tbxIdUs = new System.Windows.Forms.TextBox();
			this.tbxLoginU = new System.Windows.Forms.TextBox();
			this.tbxPassU = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.lblLog = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxDolzh = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Khaki;
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(559, 623);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(192, 41);
			this.button1.TabIndex = 0;
			this.button1.Text = "Добавить аккаунт";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbxIdUs
			// 
			this.tbxIdUs.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxIdUs.Location = new System.Drawing.Point(138, 112);
			this.tbxIdUs.Name = "tbxIdUs";
			this.tbxIdUs.Size = new System.Drawing.Size(209, 31);
			this.tbxIdUs.TabIndex = 1;
			// 
			// tbxLoginU
			// 
			this.tbxLoginU.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxLoginU.Location = new System.Drawing.Point(534, 112);
			this.tbxLoginU.Name = "tbxLoginU";
			this.tbxLoginU.Size = new System.Drawing.Size(217, 31);
			this.tbxLoginU.TabIndex = 2;
			// 
			// tbxPassU
			// 
			this.tbxPassU.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxPassU.Location = new System.Drawing.Point(1007, 112);
			this.tbxPassU.Name = "tbxPassU";
			this.tbxPassU.Size = new System.Drawing.Size(187, 31);
			this.tbxPassU.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Khaki;
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(150, 157);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(178, 39);
			this.button2.TabIndex = 5;
			this.button2.Text = "Проверить";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lblLog
			// 
			this.lblLog.AutoSize = true;
			this.lblLog.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLog.ForeColor = System.Drawing.Color.Green;
			this.lblLog.Location = new System.Drawing.Point(605, 73);
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(69, 26);
			this.lblLog.TabIndex = 9;
			this.lblLog.Text = "Логин";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(1063, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 26);
			this.label1.TabIndex = 10;
			this.label1.Text = "Пароль";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Green;
			this.label2.Location = new System.Drawing.Point(163, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 26);
			this.label2.TabIndex = 11;
			this.label2.Text = "ID (проверьте!)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Location = new System.Drawing.Point(588, 460);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 26);
			this.label3.TabIndex = 12;
			this.label3.Text = "Должность";
			// 
			// cbxDolzh
			// 
			this.cbxDolzh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDolzh.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxDolzh.FormattingEnabled = true;
			this.cbxDolzh.Items.AddRange(new object[] {
            "Системный программист",
            "Начальник",
            "Специалист отдела кадров",
            "Главный проектировщик",
            "Другое"});
			this.cbxDolzh.Location = new System.Drawing.Point(483, 489);
			this.cbxDolzh.Name = "cbxDolzh";
			this.cbxDolzh.Size = new System.Drawing.Size(333, 32);
			this.cbxDolzh.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Green;
			this.label4.Location = new System.Drawing.Point(554, 266);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(185, 26);
			this.label4.TabIndex = 15;
			this.label4.Text = "Электронная почта";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(465, 313);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(372, 31);
			this.textBox1.TabIndex = 14;
			// 
			// FormAddAc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1331, 697);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.cbxDolzh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblLog);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tbxPassU);
			this.Controls.Add(this.tbxLoginU);
			this.Controls.Add(this.tbxIdUs);
			this.Controls.Add(this.button1);
			this.Name = "FormAddAc";
			this.Text = "Добавление аккаунта";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbxIdUs;
		private System.Windows.Forms.TextBox tbxLoginU;
		private System.Windows.Forms.TextBox tbxPassU;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lblLog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbxDolzh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
	}
}