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
	public partial class FormProfilesRabot : Form
	{
		public FormProfilesRabot()
		{
			InitializeComponent();
		}

		List<string> LstIdUsers = new List<string>();
		int currentProf = 0;
		void GetDateDB()
		{
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();


			string StrQuarte = $@"Select  IdUser From ListUsers";
			SqlCommand Quarte1 = new SqlCommand(StrQuarte, Con);
			SqlDataReader Res = Quarte1.ExecuteReader();
			LstIdUsers.Clear();
			while (Res.Read())
			{
				string IDU = Res["IdUser"].ToString();
				LstIdUsers.Add(IDU);
			}
			Con.Close();
		}

		private void FormProfilesRabot_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "adminNovozybkovDataSet.ListUsers". При необходимости она может быть перемещена или удалена.
			this.listUsersTableAdapter.Fill(this.adminNovozybkovDataSet.ListUsers);
			GetDateDB();
			if(Form1.Dolz == "1")
			{
				btnUvol.Visible = true;
			}
			lblFi.Text = lblFIO.Text + " " + lblName.Text + " " + lblOtch.Text;
		}
		void Upd()
		{
			bsUsers.Filter = "IdUser = " + LstIdUsers[currentProf];
			lblFi.Text = lblFIO.Text + " " + lblName.Text + " " + lblOtch.Text;
		}
		private void btnNext_Click(object sender, EventArgs e)
		{
			
			currentProf++;
			Upd();
			if (currentProf >= LstIdUsers.Count - 1)
			{
				btnNext.Enabled = false;
			}
			else
				btnNext.Enabled = true;

			if(currentProf > 0)
			{
				btnLast.Enabled = true;
			}
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			currentProf--;
			Upd();
			if (currentProf == 0)
				btnLast.Enabled = false;
			else
				btnLast.Enabled = true;

			if (currentProf < LstIdUsers.Count - 1)
				btnNext.Enabled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(LstIdUsers.Contains(textBox1.Text))
			{
				currentProf = LstIdUsers.IndexOf(textBox1.Text);
				if (currentProf == 0)
					btnLast.Enabled = false;
				else
					btnLast.Enabled = true;

				if (currentProf < LstIdUsers.Count - 1)
					btnNext.Enabled = true;

				if (currentProf >= LstIdUsers.Count - 1)
				{
					btnNext.Enabled = false;
				}
				else
					btnNext.Enabled = true;

				if (currentProf > 0)
				{
					btnLast.Enabled = true;
				}
				Upd();
			}	
			else
			{
				MessageBox.Show("Пользователя с таким номером нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show($"Вы уверены, что хотите уволить работника - {lblFIO.Text} {lblName.Text} {lblOtch.Text} ?", "Вннимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(res == DialogResult.Yes)
			{

				SqlConnection Con = new SqlConnection(Form1.TxtCon);
				Con.Open();
				string StrQuarte = $@"Update ListUsers set DateOfEndWork = GETDATE() Where IdUser = {lblIdU.Text}";
				SqlCommand Quarte1 = new SqlCommand(StrQuarte, Con);
				Quarte1.ExecuteNonQuery();

				MessageBox.Show($"{lblFIO.Text} {lblName.Text} {lblOtch.Text} был уволен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
				GetDateDB();
				Upd();
			}
		}
	}
}
