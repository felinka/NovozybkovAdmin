
namespace NovGorAdmin
{
	partial class FormProf
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
			this.lblFIO = new System.Windows.Forms.Label();
			this.bsUser = new System.Windows.Forms.BindingSource(this.components);
			this.adminNovozybkovDataSet = new NovGorAdmin.AdminNovozybkovDataSet();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblIdU = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.listUsersTableAdapter = new NovGorAdmin.AdminNovozybkovDataSetTableAdapters.ListUsersTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adminNovozybkovDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFIO
			// 
			this.lblFIO.AutoSize = true;
			this.lblFIO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "FamU", true));
			this.lblFIO.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblFIO.Location = new System.Drawing.Point(415, 9);
			this.lblFIO.Name = "lblFIO";
			this.lblFIO.Size = new System.Drawing.Size(31, 33);
			this.lblFIO.TabIndex = 2;
			this.lblFIO.Text = "T";
			this.lblFIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bsUser
			// 
			this.bsUser.DataMember = "ListUsers";
			this.bsUser.DataSource = this.adminNovozybkovDataSet;
			// 
			// adminNovozybkovDataSet
			// 
			this.adminNovozybkovDataSet.DataSetName = "AdminNovozybkovDataSet";
			this.adminNovozybkovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "Dolzhn", true));
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Olive;
			this.label1.Location = new System.Drawing.Point(419, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 28);
			this.label1.TabIndex = 3;
			this.label1.Text = "должность";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "NameU", true));
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(419, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 33);
			this.label2.TabIndex = 4;
			this.label2.Text = "t";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "OtchU", true));
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(420, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 33);
			this.label3.TabIndex = 5;
			this.label3.Text = "t";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblIdU
			// 
			this.lblIdU.AutoSize = true;
			this.lblIdU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "IdUser", true));
			this.lblIdU.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdU.ForeColor = System.Drawing.Color.Olive;
			this.lblIdU.Location = new System.Drawing.Point(997, 9);
			this.lblIdU.Name = "lblIdU";
			this.lblIdU.Size = new System.Drawing.Size(0, 28);
			this.lblIdU.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "PasspotU", true));
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Olive;
			this.label5.Location = new System.Drawing.Point(506, 325);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 28);
			this.label5.TabIndex = 7;
			this.label5.Text = "пол";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(154, 207);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 28);
			this.label6.TabIndex = 8;
			this.label6.Text = "Пол:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label7.Location = new System.Drawing.Point(278, 207);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 28);
			this.label7.TabIndex = 10;
			this.label7.Text = "Дата рождения: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "BirthdayU", true));
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Olive;
			this.label8.Location = new System.Drawing.Point(295, 235);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 28);
			this.label8.TabIndex = 9;
			this.label8.Text = "пол";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label9.Location = new System.Drawing.Point(492, 207);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(147, 28);
			this.label9.TabIndex = 12;
			this.label9.Text = "Дата приёма: ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "DateOfStartWork", true));
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Olive;
			this.label10.Location = new System.Drawing.Point(506, 235);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(50, 28);
			this.label10.TabIndex = 11;
			this.label10.Text = "пол";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label11.Location = new System.Drawing.Point(679, 207);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(185, 28);
			this.label11.TabIndex = 14;
			this.label11.Text = "Дата увольнения: ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "DateOfEndWork", true));
			this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Olive;
			this.label12.Location = new System.Drawing.Point(743, 235);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(50, 28);
			this.label12.TabIndex = 13;
			this.label12.Text = "пол";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label13.Location = new System.Drawing.Point(154, 325);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(254, 28);
			this.label13.TabIndex = 15;
			this.label13.Text = "Серия и номер паспорта:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label14.Location = new System.Drawing.Point(154, 370);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(63, 28);
			this.label14.TabIndex = 17;
			this.label14.Text = "ИНН:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "INNU", true));
			this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Olive;
			this.label15.Location = new System.Drawing.Point(278, 370);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(50, 28);
			this.label15.TabIndex = 16;
			this.label15.Text = "пол";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label16.Location = new System.Drawing.Point(154, 417);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(79, 28);
			this.label16.TabIndex = 19;
			this.label16.Text = "Оклад:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "Oklad", true));
			this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Olive;
			this.label17.Location = new System.Drawing.Point(278, 417);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(50, 28);
			this.label17.TabIndex = 18;
			this.label17.Text = "пол";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "GenderU", true));
			this.label18.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Olive;
			this.label18.Location = new System.Drawing.Point(154, 235);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(50, 28);
			this.label18.TabIndex = 20;
			this.label18.Text = "пол";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label19.Location = new System.Drawing.Point(1072, 14);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(41, 28);
			this.label19.TabIndex = 21;
			this.label19.Text = "№:";
			// 
			// listUsersTableAdapter
			// 
			this.listUsersTableAdapter.ClearBeforeFill = true;
			// 
			// FormProf
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1140, 540);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblIdU);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblFIO);
			this.Name = "FormProf";
			this.Text = "Мой профиль";
			this.Load += new System.EventHandler(this.FormProf_Load);
			((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adminNovozybkovDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblFIO;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private AdminNovozybkovDataSet adminNovozybkovDataSet;
		private System.Windows.Forms.BindingSource bsUser;
		private AdminNovozybkovDataSetTableAdapters.ListUsersTableAdapter listUsersTableAdapter;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		public System.Windows.Forms.Label lblIdU;
	}
}