
namespace NovGorAdmin
{
	partial class FormProfilesRabot
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
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
			this.adminNovozybkovDataSet = new NovGorAdmin.AdminNovozybkovDataSet();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblIdU = new System.Windows.Forms.Label();
			this.lblOtch = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblFIO = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.listUsersTableAdapter = new NovGorAdmin.AdminNovozybkovDataSetTableAdapters.ListUsersTableAdapter();
			this.btnUvol = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblFi = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adminNovozybkovDataSet)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label19.Location = new System.Drawing.Point(1225, 41);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(41, 28);
			this.label19.TabIndex = 41;
			this.label19.Text = "№:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "GenderU", true));
			this.label18.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Olive;
			this.label18.Location = new System.Drawing.Point(228, 244);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(50, 28);
			this.label18.TabIndex = 40;
			this.label18.Text = "пол";
			// 
			// bsUsers
			// 
			this.bsUsers.DataMember = "ListUsers";
			this.bsUsers.DataSource = this.adminNovozybkovDataSet;
			// 
			// adminNovozybkovDataSet
			// 
			this.adminNovozybkovDataSet.DataSetName = "AdminNovozybkovDataSet";
			this.adminNovozybkovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label16.Location = new System.Drawing.Point(283, 482);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(79, 28);
			this.label16.TabIndex = 39;
			this.label16.Text = "Оклад:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Oklad", true));
			this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Olive;
			this.label17.Location = new System.Drawing.Point(407, 482);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(50, 28);
			this.label17.TabIndex = 38;
			this.label17.Text = "пол";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label14.Location = new System.Drawing.Point(283, 435);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(63, 28);
			this.label14.TabIndex = 37;
			this.label14.Text = "ИНН:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "INNU", true));
			this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Olive;
			this.label15.Location = new System.Drawing.Point(407, 435);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(50, 28);
			this.label15.TabIndex = 36;
			this.label15.Text = "пол";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label13.Location = new System.Drawing.Point(283, 390);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(254, 28);
			this.label13.TabIndex = 35;
			this.label13.Text = "Серия и номер паспорта:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label11.Location = new System.Drawing.Point(930, 216);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(185, 28);
			this.label11.TabIndex = 34;
			this.label11.Text = "Дата увольнения: ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "DateOfEndWork", true));
			this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Olive;
			this.label12.Location = new System.Drawing.Point(1000, 244);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(50, 28);
			this.label12.TabIndex = 33;
			this.label12.Text = "пол";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label9.Location = new System.Drawing.Point(680, 216);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(147, 28);
			this.label9.TabIndex = 32;
			this.label9.Text = "Дата приёма: ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "DateOfStartWork", true));
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Olive;
			this.label10.Location = new System.Drawing.Point(701, 244);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(50, 28);
			this.label10.TabIndex = 31;
			this.label10.Text = "пол";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label7.Location = new System.Drawing.Point(396, 216);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 28);
			this.label7.TabIndex = 30;
			this.label7.Text = "Дата рождения: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "BirthdayU", true));
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Olive;
			this.label8.Location = new System.Drawing.Point(413, 244);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 28);
			this.label8.TabIndex = 29;
			this.label8.Text = "пол";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(217, 216);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 28);
			this.label6.TabIndex = 28;
			this.label6.Text = "Пол:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "PasspotU", true));
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Olive;
			this.label5.Location = new System.Drawing.Point(635, 390);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 28);
			this.label5.TabIndex = 27;
			this.label5.Text = "пол";
			// 
			// lblIdU
			// 
			this.lblIdU.AutoSize = true;
			this.lblIdU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "IdUser", true));
			this.lblIdU.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdU.ForeColor = System.Drawing.Color.Olive;
			this.lblIdU.Location = new System.Drawing.Point(1272, 41);
			this.lblIdU.Name = "lblIdU";
			this.lblIdU.Size = new System.Drawing.Size(0, 28);
			this.lblIdU.TabIndex = 26;
			// 
			// lblOtch
			// 
			this.lblOtch.AutoSize = true;
			this.lblOtch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "OtchU", true));
			this.lblOtch.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOtch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblOtch.Location = new System.Drawing.Point(606, 93);
			this.lblOtch.Name = "lblOtch";
			this.lblOtch.Size = new System.Drawing.Size(25, 33);
			this.lblOtch.TabIndex = 25;
			this.lblOtch.Text = "t";
			this.lblOtch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "NameU", true));
			this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblName.Location = new System.Drawing.Point(605, 57);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(25, 33);
			this.lblName.TabIndex = 24;
			this.lblName.Text = "t";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Dolzhn", true));
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Olive;
			this.label1.Location = new System.Drawing.Point(228, 126);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(774, 28);
			this.label1.TabIndex = 23;
			this.label1.Text = "должность";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFIO
			// 
			this.lblFIO.AutoSize = true;
			this.lblFIO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "FamU", true));
			this.lblFIO.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblFIO.Location = new System.Drawing.Point(601, 17);
			this.lblFIO.Name = "lblFIO";
			this.lblFIO.Size = new System.Drawing.Size(31, 33);
			this.lblFIO.TabIndex = 22;
			this.lblFIO.Text = "T";
			this.lblFIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.Color.Khaki;
			this.btnNext.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Location = new System.Drawing.Point(1154, 611);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(161, 44);
			this.btnNext.TabIndex = 43;
			this.btnNext.Text = "Следующий";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnLast
			// 
			this.btnLast.BackColor = System.Drawing.Color.Khaki;
			this.btnLast.Enabled = false;
			this.btnLast.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLast.Location = new System.Drawing.Point(38, 610);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(172, 45);
			this.btnLast.TabIndex = 44;
			this.btnLast.Text = "Предыдущий";
			this.btnLast.UseVisualStyleBackColor = false;
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(576, 626);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 31);
			this.textBox1.TabIndex = 45;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Khaki;
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(690, 622);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(137, 37);
			this.button1.TabIndex = 46;
			this.button1.Text = "перейти";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label4.Location = new System.Drawing.Point(525, 628);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 28);
			this.label4.TabIndex = 47;
			this.label4.Text = "№:";
			// 
			// listUsersTableAdapter
			// 
			this.listUsersTableAdapter.ClearBeforeFill = true;
			// 
			// btnUvol
			// 
			this.btnUvol.BackColor = System.Drawing.Color.Khaki;
			this.btnUvol.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUvol.Location = new System.Drawing.Point(27, 108);
			this.btnUvol.Name = "btnUvol";
			this.btnUvol.Size = new System.Drawing.Size(126, 34);
			this.btnUvol.TabIndex = 48;
			this.btnUvol.Text = "Уволить";
			this.btnUvol.UseVisualStyleBackColor = false;
			this.btnUvol.Visible = false;
			this.btnUvol.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblFi);
			this.panel1.Location = new System.Drawing.Point(0, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1229, 100);
			this.panel1.TabIndex = 49;
			// 
			// lblFi
			// 
			this.lblFi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblFi.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblFi.Location = new System.Drawing.Point(0, 0);
			this.lblFi.Name = "lblFi";
			this.lblFi.Size = new System.Drawing.Size(1229, 100);
			this.lblFi.TabIndex = 22;
			this.lblFi.Text = "Фамилия имя отчество:";
			this.lblFi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormProfilesRabot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1344, 678);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnUvol);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnNext);
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
			this.Controls.Add(this.lblOtch);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblFIO);
			this.Name = "FormProfilesRabot";
			this.Text = "Профили работников";
			this.Load += new System.EventHandler(this.FormProfilesRabot_Load);
			((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adminNovozybkovDataSet)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label lblIdU;
		private System.Windows.Forms.Label lblOtch;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblFIO;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private AdminNovozybkovDataSet adminNovozybkovDataSet;
		private System.Windows.Forms.BindingSource bsUsers;
		private AdminNovozybkovDataSetTableAdapters.ListUsersTableAdapter listUsersTableAdapter;
		private System.Windows.Forms.Button btnUvol;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblFi;
	}
}