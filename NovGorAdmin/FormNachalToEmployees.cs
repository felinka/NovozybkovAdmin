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
	public partial class FormNachalToEmployees : Form
	{
		public FormNachalToEmployees()
		{
			InitializeComponent();
			GetDateDB();
			FillPanel();

			if(Form1.Dolz == "1")
			{
				tbxID.Visible = true;
				tbxTextMess.Visible = true;
				lblF.Visible = true;
				lblS.Visible = true;
				btnSend.Visible = true;
			}
		}

		struct Messs
		{
			public string IdRep, TextMess, IdUserFIO, DateMess;
		}

		List<Messs> LstMess = new List<Messs>();

		class Items : Panel
		{
			public System.Windows.Forms.Label lblDate;
			public System.Windows.Forms.Label lblText;
			public System.Windows.Forms.Label lblFIPoluch;

			public string IDMess;

			public Items()
			{
				this.lblText = new System.Windows.Forms.Label();
				this.lblFIPoluch = new System.Windows.Forms.Label();
				this.lblDate = new System.Windows.Forms.Label();
				//this.panel1.SuspendLayout();
				//this.SuspendLayout();
				// 
				// panel1
				// 
				this.Controls.Add(this.lblDate);
				this.Controls.Add(this.lblText);
				this.Controls.Add(this.lblFIPoluch);
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
				this.lblFIPoluch.AutoSize = true;
				this.lblFIPoluch.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
				this.lblFIPoluch.ForeColor = System.Drawing.Color.Green;
				this.lblFIPoluch.Location = new System.Drawing.Point(35, 3);
				this.lblFIPoluch.Name = "lblFIO";
				this.lblFIPoluch.Size = new System.Drawing.Size(57, 24);
				this.lblFIPoluch.TabIndex = 0;
				this.lblFIPoluch.Text = "label1";
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


			string StrQuarte = $@"SELECT    MessNachal.IdMess as 'IdMess', MessNachal.IdPoluch as 'IdP',  ListUsers.FamU + ' ' + ListUsers.NameU as 'FI', MessNachal.TextMess as 'TextM', MessNachal.DateMess as 'DateM' FROM         ListUsers INNER JOIN MessNachal ON ListUsers.IdUser = MessNachal.IdPoluch order by IdUser" + Usl;
			SqlCommand Quarte1 = new SqlCommand(StrQuarte, Con);
			SqlDataReader Res = Quarte1.ExecuteReader();
			LstMess.Clear();
			while (Res.Read())
			{
				if (Res["IdP"].ToString() == Form1.IDU || Form1.Dolz == "1")
				{
					Messs Mess = new Messs();
					Mess.TextMess = Res["TextM"].ToString();

					Mess.IdUserFIO ="Кому:"+" ID"+ Res["IdP"].ToString() + " " + Res["FI"].ToString();
					Mess.DateMess = Res["DateM"].ToString().Substring(0,10);
					Mess.IdRep = Res["IdMess"].ToString();
					LstMess.Add(Mess);
				}
			}
			Con.Close();

			
		}


		void FillPanel()
		{
			MainPanel.Controls.Clear();
			MainPanel.AutoScrollPosition = new Point(
	Math.Abs(MainPanel.AutoScrollPosition.X),
	MainPanel.VerticalScroll.Maximum);
			for (int i = LstMess.Count-1; i >= 0; i--)
			{
				Items Item = new Items();
				Item.IDMess = LstMess[i].IdRep;

				//----------------------------------------------------------------

				string DateN = DateTime.Now.ToString().Substring(0, 10);
				if (LstMess[i].DateMess == DateN)
				{
					Item.lblText.BackColor = Color.LemonChiffon;
				}
				else 
				{
					Item.lblText.BackColor = Color.Gainsboro;
				}


				//----------------------------------------------------------------

				//if(Form1.Dolz == "начальник")
				//Item.lblFIO.Text = "!! "+LstMess[i].IdUserFIO;
				//else
				Item.lblFIPoluch.Text = LstMess[i].IdUserFIO;
				Item.lblDate.Text = LstMess[i].DateMess;
				Item.lblText.Text = LstMess[i].TextMess;
				
				MainPanel.Controls.Add(Item);

				
			}


		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			string FIW = "";

			Con.Open();
			int count = 0;
			string StrQuarte1 = $@"SELECT     FamU + ' '+NameU+ ' '+ OtchU as 'FIO'   FROM         ListUsers WHERE     (IdUser = {tbxID.Text})";
			SqlCommand Quarte11 = new SqlCommand(StrQuarte1, Con);
			SqlDataReader Res1 = Quarte11.ExecuteReader();
			while (Res1.Read())
			{
				//if (Res1["cnt"].ToString() != "0")
				//	count++;

				if (Res1.HasRows)
				{
					count++;
					FIW = Res1["FIO"].ToString();
				}
					

			}
			Con.Close();



			if (count <= 0)
			{
				MessageBox.Show("Пользователя с таким номером нет. Поверьте правильность номера и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				DialogResult res = MessageBox.Show($"Вы хотите призвать к себе {FIW.ToUpper()} ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (res == DialogResult.Yes)
				{


					Con.Open();

					string FIO = "";

					string StrQuarte = $@"SELECT    FamU + ' '+NameU+ ' '+ OtchU as 'FIO' FROM         ListUsers WHERE     (IdUser = {Form1.IDU})";
					SqlCommand Quarte1 = new SqlCommand(StrQuarte, Con);
					SqlDataReader Res = Quarte1.ExecuteReader();
					while (Res.Read())
					{
						FIO = "ОТ: " + Res["FIO"].ToString() + "    ТЕКСТ: ";
					}
					Con.Close();

					Con.Open();
					StrQuarte = $@"Insert into MessNachal (IdNach, IdPoluch, TextMess, DateMess) Values ({Form1.IDU}, {tbxID.Text}, '{tbxTextMess.Text}', GETDATE())";
					SqlCommand Quarte12 = new SqlCommand(StrQuarte, Con);
					Quarte12.ExecuteNonQuery();
					Con.Close();

					MessageBox.Show("Успешно отправлено!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetDateDB();
					FillPanel();
				}
			}


			

			
			

		}
	}
}
