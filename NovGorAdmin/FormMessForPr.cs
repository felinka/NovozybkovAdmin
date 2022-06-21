using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovGorAdmin
{
	public partial class FormMessForPr : Form
	{
		public FormMessForPr()
		{
			InitializeComponent();
			GetDateDB();
			FillPanel();
		}

		struct Messs
		{
			public string IdRep, TextMess, IdUserFIO, DateMess, BoolComp;
		}

		List<Messs> LstMess = new List<Messs>();
		int NBegin = 0;

		class Items : Panel
		{
			public System.Windows.Forms.Label lblDate;
			public System.Windows.Forms.CheckBox cbxBool;
			public System.Windows.Forms.Label lblText;
			public System.Windows.Forms.Label lblFIO;
			
			public string IDMess;

			public Items()
			{
				this.lblText = new System.Windows.Forms.Label();
				this.lblFIO = new System.Windows.Forms.Label();
				this.lblDate = new System.Windows.Forms.Label();
				this.cbxBool = new System.Windows.Forms.CheckBox();
				//this.panel1.SuspendLayout();
				//this.SuspendLayout();
				// 
				// panel1
				// 
				this.Controls.Add(this.lblDate);
				this.Controls.Add(this.lblText);
				this.Controls.Add(this.lblFIO);
				this.Location = new System.Drawing.Point(12, 12);
				this.Name = "panel1";
				this.Size = new System.Drawing.Size(805, 174);
				this.TabIndex = 0;
				// 
				// lblText
				// 
				this.lblText.BackColor = System.Drawing.Color.LemonChiffon;
				this.lblText.Cursor = System.Windows.Forms.Cursors.IBeam;
				this.lblText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.lblText.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
				this.lblText.Location = new System.Drawing.Point(35, 32);
				this.lblText.Name = "lblText";
				this.lblText.Size = new System.Drawing.Size(590, 87);
				this.lblText.TabIndex = 1;
				this.lblText.Text = "label2";
				// 
				// lblFIO
				// 
				this.lblFIO.AutoSize = true;
				this.lblFIO.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
				this.lblFIO.ForeColor = System.Drawing.Color.Green;
				this.lblFIO.Location = new System.Drawing.Point(35, 3);
				this.lblFIO.Name = "lblFIO";
				this.lblFIO.Size = new System.Drawing.Size(57, 24);
				this.lblFIO.TabIndex = 0;
				this.lblFIO.Text = "label1";
				// 
				// lblDate
				// 
				this.lblDate.AutoSize = true;
				this.lblDate.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
				this.lblDate.ForeColor = System.Drawing.Color.Green;
				this.lblDate.Location = new System.Drawing.Point(426, 3);
				this.lblDate.Name = "lblDate";
				this.lblDate.Size = new System.Drawing.Size(59, 24);
				this.lblDate.TabIndex = 2;
				this.lblDate.Text = "label3";
				// 
				// cbxBool
				// 
				this.cbxBool.AutoSize = true;
				this.cbxBool.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.cbxBool.ForeColor = System.Drawing.Color.Green;
				this.cbxBool.Location = new System.Drawing.Point(516, 122);
				this.cbxBool.Name = "cbxBool";
				this.cbxBool.Size = new System.Drawing.Size(109, 23);
				this.cbxBool.TabIndex = 3;
				this.cbxBool.Text = "Выполнено";
				this.cbxBool.UseVisualStyleBackColor = true;

			}
		}


		void GetDateDB()
		{
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();
			string Usl = "";
			//if (flag == true && tbxFind.Text != "")
			//{
			//	Usl = $@" and TextMess like '%{Find}%'";
			//}


			string StrQuarte = $@"Select  IdRep, FamU + ' ' + NameU + ' ' as FI, LogUsers.IdUser, TextRep, DateRep,  BoolCompl From LogUsers, ListUsers, RepLog Where LogUsers.IdUser = ListUsers.IdUser and RepLog.IdUser = LogUsers.IdUser and BoolCompl = 0 order by IdUser" + Usl;
			SqlCommand Quarte1 = new SqlCommand(StrQuarte, Con);
			SqlDataReader Res = Quarte1.ExecuteReader();
			LstMess.Clear();
			while (Res.Read())
			{
				Messs Mess = new Messs();
				Mess.TextMess = Res["TextRep"].ToString();
				Mess.IdUserFIO = "ID:"+Res["IdUser"].ToString()+ " " + Res["FI"].ToString();
				Mess.DateMess = Res["DateRep"].ToString();
				Mess.BoolComp = Res["BoolCompl"].ToString();
				Mess.IdRep = Res["IdRep"].ToString();
				LstMess.Add(Mess);
			}
			Con.Close();

			Con.Open();
			//if (flag == true && tbxFind.Text != "")
			//{
			//	Usl = $@" and TextMess like '%{Find}%'";
			//}


			 StrQuarte = $@"Select  IdRep, FamU + ' ' + NameU + ' ' as FI, LogUsers.IdUser, TextRep, DateRep,  BoolCompl From LogUsers, ListUsers, RepLog Where LogUsers.IdUser = ListUsers.IdUser and RepLog.IdUser = LogUsers.IdUser and BoolCompl = 1 order by IdUser" + Usl;
			SqlCommand Quarte12 = new SqlCommand(StrQuarte, Con);
			SqlDataReader Res2 = Quarte12.ExecuteReader();

			while (Res2.Read())
			{
				Messs Mess = new Messs();
				Mess.TextMess = Res2["TextRep"].ToString();
				Mess.IdUserFIO = "ID:" + Res2["IdUser"].ToString() + " " + Res2["FI"].ToString();
				Mess.DateMess = Res2["DateRep"].ToString();
				Mess.BoolComp = Res2["BoolCompl"].ToString();
				Mess.IdRep = Res2["IdRep"].ToString();
				LstMess.Add(Mess);
			}
			Con.Close();
		}


		void FillPanel()
		{
			MainPanel.Controls.Clear();
			MainPanel.AutoScrollPosition = new Point(
	Math.Abs(MainPanel.AutoScrollPosition.X),
	MainPanel.VerticalScroll.Maximum);
				for (int i = NBegin; i < LstMess.Count; i++)
				{
					Items Item = new Items();
					Item.IDMess = LstMess[i].IdRep;

					//----------------------------------------------------------------

					if (int.Parse(LstMess[i].BoolComp) == 0)
					{
						Item.lblText.BackColor = Color.LemonChiffon;
					}
					else if (int.Parse(LstMess[i].BoolComp) == 1)
					{
						Item.lblText.BackColor = Color.Gainsboro;
					}
					

					//----------------------------------------------------------------

					if(Form1.Dolz == "начальник")
					Item.lblFIO.Text = "!! "+LstMess[i].IdUserFIO;
					else
						Item.lblFIO.Text = LstMess[i].IdUserFIO;
					Item.lblDate.Text = LstMess[i].DateMess;
				Item.lblText.Text = LstMess[i].TextMess;
				if (LstMess[i].BoolComp == "1")
				{
					Item.cbxBool.Checked = true;
				}
				else
				{
					Item.cbxBool.Checked = true;
				}
				MainPanel.Controls.Add(Item);
				}
			

		}
	}
}
