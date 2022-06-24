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
	public partial class FormAddAc : Form
	{
		public FormAddAc()
		{
			InitializeComponent();
		}

		bool Proverka = false;
		private void button2_Click(object sender, EventArgs e)
		{
			//try
			//{



				string TxtQuery = $@"SELECT    ListUsers.IdUser ,ListUsers.FamU + ' '+ListUsers.NameU + ' ' + ListUsers.OtchU as FIO FROM         ListUsers  Where ListUsers.IdUser =   " + tbxIdUs.Text;
				SqlConnection Con = new SqlConnection(Form1.TxtCon);
				Con.Open();
			SqlCommand Quey1 = new SqlCommand(TxtQuery, Con);
			SqlDataReader Res = Quey1.ExecuteReader();
			string FIO = "";
				if (Res.HasRows)
				{
				Res.Read();
					FIO = Res["FIO"].ToString();
				Res.Close();
				TxtQuery = $@"SELECT    ListUsers.IdUser ,ListUsers.FamU + ' '+ListUsers.NameU + ' ' + ListUsers.OtchU as FIO
FROM         ListUsers INNER JOIN
                      LogUsers ON ListUsers.IdUser = LogUsers.IdUser
Where ListUsers.IdUser = " + tbxIdUs.Text;

					SqlConnection Con1 = new SqlConnection(Form1.TxtCon);
					SqlCommand Quey11 = new SqlCommand(TxtQuery, Con);
					Con1.Open();
					Quey1 = new SqlCommand(TxtQuery, Con);
					SqlDataReader Res1 = Quey11.ExecuteReader();
				Res1.Read();
					if (Res1.HasRows)
					{
						MessageBox.Show($"У {FIO} уже есть акккаунт для входа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Proverka = false;
						Con1.Close();
						Con.Close();
					return;
					}
					else
					{
						MessageBox.Show($"У {FIO} нет акккаунта для входа.", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Proverka = true;
					Con1.Close();
					Con.Close();
					return;
					}

				
				}
				else
				{
					MessageBox.Show($"У пользователя с таким ID нет профиля.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
				}	
				
			//}
			//catch
			//{
			//	MessageBox.Show($"Что-то пошло не так... :( \n Проверьте правильность поля с ID и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(Proverka== false)
			{
				MessageBox.Show($"Сначала нужно проверить правильность выбора пользователя!", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if(tbxLoginU.Text == "" || tbxPassU.Text == "")
			{
				MessageBox.Show($"Заполните все поля!", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			string Dolzh = cbxDolzh.SelectedIndex.ToString();
			

				string TxtQuery = $@"Insert into LogUsers (IdUser, LoginU, PassU, BoolWork, Dolzh) Values ({tbxIdUs.Text}, '{tbxLoginU.Text}', '{tbxPassU.Text}', 1, {Dolzh})" ;
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();
			SqlCommand Quey1 = new SqlCommand(TxtQuery, Con);
			Quey1.ExecuteNonQuery();
			Con.Close();

			MessageBox.Show($"Аккаунт успешно добавлен!", "Успех.", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Proverka = false;
			tbxIdUs.Text = "";
			tbxLoginU.Text = "";
			tbxPassU.Text = "";
		}
	}
}
