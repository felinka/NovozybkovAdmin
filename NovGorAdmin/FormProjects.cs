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
	public partial class FormProjects : Form
	{
		string Nachal = "";
		public FormProjects()
		{
			InitializeComponent();
		

			if (Form1.Dolz == "3")
			{
				rbtF.Visible = false;
				rbtT.Visible = false;
				groupBox1.Visible = false;
			}
			else if (Form1.Dolz == "1")
			{
				btn.Text = "Изменить статус";
				lbl.Text = $"Введите № идеи проекта ниже, выберите, отклоняете его или нет, \nи нажмите на \"Изменить статус\"";
				flag = true;
				SqlConnection Con = new SqlConnection(Form1.TxtCon);
				Con.Open();

				string StrQuarte = $@"Select IdI From ProjectsIdeas";
				SqlCommand Quarte1 = new SqlCommand(StrQuarte, Con);
				SqlDataReader Res = Quarte1.ExecuteReader();
				LstId.Clear();
				while (Res.Read())
				{

					LstId.Add(Res["IdI"].ToString());
				}
				Con.Close();
				Con.Open();
				string StrQuarte1 = $@"Select FamU as f, NameU as n, OtchU as o from ListUsers Where IdUser = {Form1.IDU}";
				SqlCommand Quarte11 = new SqlCommand(StrQuarte1, Con);
				SqlDataReader Res1 = Quarte11.ExecuteReader();
				while (Res1.Read())
				{
					Nachal = Res1["f"].ToString() + " "+ Res1["n"].ToString().Substring(0,1)+"."+Res1["o"].ToString().Substring(0, 1)+". ";
				}
				Con.Close();
			}
			GetDateDB();
			FillPanel();
		}
		
		List<string> LstId = new List<string>();
		bool flag = false;
		struct Messs
		{
			public string IdI, TextMess, StatusId, DateMess;
		}

		List<Messs> LstMess = new List<Messs>();

		class Items : Panel
		{
			public System.Windows.Forms.Label lblDate;
			public System.Windows.Forms.Label lblText;
			public System.Windows.Forms.Label lblIdAndStatus;

			public string IDMess;

			public Items()
			{
				this.lblText = new System.Windows.Forms.Label();
				this.lblIdAndStatus = new System.Windows.Forms.Label();
				this.lblDate = new System.Windows.Forms.Label();
				//this.panel1.SuspendLayout();
				//this.SuspendLayout();
				// 
				// panel1
				// 
				this.Controls.Add(this.lblDate);
				this.Controls.Add(this.lblText);
				this.Controls.Add(this.lblIdAndStatus);
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
				this.lblIdAndStatus.AutoSize = true;
				this.lblIdAndStatus.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
				this.lblIdAndStatus.ForeColor = System.Drawing.Color.Green;
				this.lblIdAndStatus.Location = new System.Drawing.Point(35, 3);
				this.lblIdAndStatus.Name = "lblIdAndStatus";
				this.lblIdAndStatus.Size = new System.Drawing.Size(57, 24);
				this.lblIdAndStatus.TabIndex = 0;
				this.lblIdAndStatus.Text = "label1";
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
			string Usl1 = "", Usl2 = "";
			if (flag == false)
			{
				Usl1 = $"Where [IdGlPr] = {Form1.IDU} and StatusId = 0";
				Usl2 = $"Where [IdGlPr] = {Form1.IDU}";
			}
			else if(flag == true)
			{
				Usl1 = $"Where StatusId = 0";
				Usl2 = "";
			}
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();

			string StrQuarte = $@"Select [IdI],[TextId] , [StatusId] , [IdNachRassmotr] ,[DateId]  From [dbo].[ProjectsIdeas]  {Usl1}";
			SqlCommand Quarte1 = new SqlCommand(StrQuarte, Con);
			SqlDataReader Res = Quarte1.ExecuteReader();
			LstMess.Clear();
			while (Res.Read())
			{
				Messs Mess = new Messs();
				Mess.TextMess = Res["TextId"].ToString();
				Mess.IdI = "№:" + Res["IdI"].ToString() + " - ждёт рассмотрения";
				Mess.DateMess = Res["DateId"].ToString();
				Mess.StatusId = Res["StatusId"].ToString();
				LstMess.Add(Mess);
			}
			Res.Close();
			Con.Close();
			Con.Open();

			StrQuarte = $@"Select [IdI],[TextId] , [StatusId] , [IdNachRassmotr] ,[DateId]  From [dbo].[ProjectsIdeas] {Usl2}";
			Quarte1 = new SqlCommand(StrQuarte, Con);
			 Res = Quarte1.ExecuteReader();
			while (Res.Read())
			{
				if(Res["StatusId"].ToString() == "1" || Res["StatusId"].ToString() == "2")
				{
					Messs Mess = new Messs();
					Mess.TextMess = Res["TextId"].ToString();
					if (Res["StatusId"].ToString() == "1")
					{
						Mess.IdI = "№:" + Res["IdI"].ToString() + " - одобрено";
					}
					else if (Res["StatusId"].ToString() == "2")
					{
						Mess.IdI = "№:" + Res["IdI"].ToString() + " - отклонено";
					}

					Mess.DateMess = Res["DateId"].ToString();
					Mess.StatusId = Res["StatusId"].ToString();
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
			for (int i = LstMess.Count - 1; i >= 0; i--)
			{
				Items Item = new Items();
				Item.IDMess = LstMess[i].IdI;

				//----------------------------------------------------------------

				if (LstMess[i].StatusId == "1")
				{
					Item.lblText.BackColor = Color.LemonChiffon;
				}
				else if (LstMess[i].StatusId == "0")
				{
					Item.lblText.BackColor = Color.Gainsboro;
				}
				else if (LstMess[i].StatusId == "2")
				{
					Item.lblText.BackColor = Color.LightCoral;
				}

				Item.lblIdAndStatus.Text = LstMess[i].IdI;
				Item.lblDate.Text = LstMess[i].DateMess;
				Item.lblText.Text = LstMess[i].TextMess;

				MainPanel.Controls.Add(Item);


			}


		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (tbxText.Text != "")
			{

				if (flag == false)
				{
					DialogResult res = MessageBox.Show("Вы уверены, что хотите отправить эту идею проекта на рассмотрение?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(res == DialogResult.No)
					{
						return;
					}
					SqlConnection Con = new SqlConnection(Form1.TxtCon);

					Con.Open();
					string StrQuarte1 = $@"Insert into ProjectsIdeas (IdGlPr, TextId, StatusId, DateId, FIOPr) Values ({Form1.IDU},'{tbxText.Text}', 0, GETDATE(), '{FormGlProekt.FIOPr}')";
					SqlCommand Quarte11 = new SqlCommand(StrQuarte1, Con);
					Quarte11.ExecuteNonQuery();
					Con.Close();
					tbxText.Text = "";
				}
				else
				{
					if(!LstId.Contains(tbxText.Text))
					{
						MessageBox.Show($"Идеи проекта с таким номером нет. \nПожалуйста, проверьте и введите номер снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					string T = "";
					if(rbtF.Checked)
					{
						T = "отклонить";

					}
					else
						if(rbtT.Checked)
					{
						T = "одобрить";
					}

					DialogResult res = MessageBox.Show($"Вы уверены, что хотите {T} идею под номером {tbxText.Text}", "Внимание?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (res == DialogResult.No)
					{
						return;
					}
					SqlConnection Con = new SqlConnection(Form1.TxtCon);
					string StrQuarte1 = "";
					Con.Open();
					if (rbtF.Checked)
					{

						StrQuarte1 = $@"Update ProjectsIdeas Set  IdNachRassmotr = {Form1.IDU} , StatusId = 2, FIONach = '{Nachal}' Where [IdI] = {tbxText.Text}";

					}
					else
						if (rbtT.Checked)
					{
						StrQuarte1 = $@"Update ProjectsIdeas Set  IdNachRassmotr = {Form1.IDU} , StatusId = 1, FIONach = '{Nachal}' Where [IdI] = {tbxText.Text}";
					}

				
					SqlCommand Quarte11 = new SqlCommand(StrQuarte1, Con);
					Quarte11.ExecuteNonQuery();
					Con.Close();
					tbxText.Text = "";

				}	
				GetDateDB();
				FillPanel();
			}
		}
	}
}
