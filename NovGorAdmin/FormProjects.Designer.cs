
namespace NovGorAdmin
{
	partial class FormProjects
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
			this.lbl = new System.Windows.Forms.Label();
			this.btn = new System.Windows.Forms.Button();
			this.tbxText = new System.Windows.Forms.TextBox();
			this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbtT = new System.Windows.Forms.RadioButton();
			this.rbtF = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lbl.Location = new System.Drawing.Point(21, 583);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(383, 19);
			this.lbl.TabIndex = 12;
			this.lbl.Text = "Напишите основную идею проекта и почему он важен:";
			// 
			// btn
			// 
			this.btn.BackColor = System.Drawing.Color.Khaki;
			this.btn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn.Location = new System.Drawing.Point(1057, 625);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(241, 38);
			this.btn.TabIndex = 11;
			this.btn.Text = "Отправить";
			this.btn.UseVisualStyleBackColor = false;
			this.btn.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbxText
			// 
			this.tbxText.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxText.Location = new System.Drawing.Point(12, 643);
			this.tbxText.Multiline = true;
			this.tbxText.Name = "tbxText";
			this.tbxText.Size = new System.Drawing.Size(733, 66);
			this.tbxText.TabIndex = 10;
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
			this.MainPanel.Size = new System.Drawing.Size(1305, 566);
			this.MainPanel.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbtT);
			this.groupBox1.Controls.Add(this.rbtF);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(790, 602);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(206, 77);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// rbtT
			// 
			this.rbtT.AutoSize = true;
			this.rbtT.Location = new System.Drawing.Point(24, 46);
			this.rbtT.Name = "rbtT";
			this.rbtT.Size = new System.Drawing.Size(106, 28);
			this.rbtT.TabIndex = 1;
			this.rbtT.Text = "одобрить";
			this.rbtT.UseVisualStyleBackColor = true;
			// 
			// rbtF
			// 
			this.rbtF.AutoSize = true;
			this.rbtF.Checked = true;
			this.rbtF.Location = new System.Drawing.Point(27, 19);
			this.rbtF.Name = "rbtF";
			this.rbtF.Size = new System.Drawing.Size(98, 28);
			this.rbtF.TabIndex = 0;
			this.rbtF.TabStop = true;
			this.rbtF.Text = "отказать";
			this.rbtF.UseVisualStyleBackColor = true;
			// 
			// FormProjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1336, 728);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.btn);
			this.Controls.Add(this.tbxText);
			this.Controls.Add(this.MainPanel);
			this.Name = "FormProjects";
			this.Text = "Идеи проектов";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.TextBox tbxText;
		private System.Windows.Forms.TableLayoutPanel MainPanel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbtT;
		private System.Windows.Forms.RadioButton rbtF;
	}
}