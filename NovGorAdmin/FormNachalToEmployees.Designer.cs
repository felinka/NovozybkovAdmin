
namespace NovGorAdmin
{
	partial class FormNachalToEmployees
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
			this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.btnSend = new System.Windows.Forms.Button();
			this.tbxTextMess = new System.Windows.Forms.TextBox();
			this.lblF = new System.Windows.Forms.Label();
			this.lblS = new System.Windows.Forms.Label();
			this.tbxID = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.AutoScroll = true;
			this.MainPanel.ColumnCount = 1;
			this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.MainPanel.Location = new System.Drawing.Point(12, 12);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.RowCount = 1;
			this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.MainPanel.Size = new System.Drawing.Size(1281, 590);
			this.MainPanel.TabIndex = 2;
			// 
			// btnSend
			// 
			this.btnSend.BackColor = System.Drawing.Color.Khaki;
			this.btnSend.Location = new System.Drawing.Point(1128, 628);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(146, 44);
			this.btnSend.TabIndex = 4;
			this.btnSend.Text = "Отправить";
			this.btnSend.UseVisualStyleBackColor = false;
			this.btnSend.Visible = false;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// tbxTextMess
			// 
			this.tbxTextMess.Location = new System.Drawing.Point(24, 628);
			this.tbxTextMess.Multiline = true;
			this.tbxTextMess.Name = "tbxTextMess";
			this.tbxTextMess.Size = new System.Drawing.Size(714, 67);
			this.tbxTextMess.TabIndex = 5;
			this.tbxTextMess.Visible = false;
			// 
			// lblF
			// 
			this.lblF.AutoSize = true;
			this.lblF.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblF.ForeColor = System.Drawing.Color.Green;
			this.lblF.Location = new System.Drawing.Point(31, 606);
			this.lblF.Name = "lblF";
			this.lblF.Size = new System.Drawing.Size(248, 19);
			this.lblF.TabIndex = 10;
			this.lblF.Text = "Место для ввода текста сообщения:";
			this.lblF.Visible = false;
			// 
			// lblS
			// 
			this.lblS.AutoSize = true;
			this.lblS.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblS.ForeColor = System.Drawing.Color.Green;
			this.lblS.Location = new System.Drawing.Point(794, 628);
			this.lblS.Name = "lblS";
			this.lblS.Size = new System.Drawing.Size(102, 19);
			this.lblS.TabIndex = 12;
			this.lblS.Text = "ID работника:";
			this.lblS.Visible = false;
			// 
			// tbxID
			// 
			this.tbxID.Location = new System.Drawing.Point(796, 650);
			this.tbxID.Multiline = true;
			this.tbxID.Name = "tbxID";
			this.tbxID.Size = new System.Drawing.Size(106, 32);
			this.tbxID.TabIndex = 13;
			this.tbxID.Visible = false;
			// 
			// FormNachalToEmployees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1331, 697);
			this.Controls.Add(this.tbxID);
			this.Controls.Add(this.lblS);
			this.Controls.Add(this.lblF);
			this.Controls.Add(this.tbxTextMess);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.MainPanel);
			this.Name = "FormNachalToEmployees";
			this.Text = "от Начальника";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel MainPanel;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox tbxTextMess;
		private System.Windows.Forms.Label lblF;
		private System.Windows.Forms.Label lblS;
		private System.Windows.Forms.TextBox tbxID;
	}
}