using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovGorAdmin
{
	public partial class FormHelpLog : Form
	{
		public FormHelpLog()
		{
			InitializeComponent();
		}
		bool f = false;
		private void button1_Click(object sender, EventArgs e)
		{
			if (f == false)
			{


				if (tbxM.Text == "" || tbxPL.Text == "")
				{
					MessageBox.Show($"Не все поля заполнены. \r\nПожалуйста, проверьте правильность полей и повторите попытку еще раз.", "Обращение НЕ отправлено.", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;

				}
				string TxtQuery = "";
				if (rbtL.Checked)
				{
					TxtQuery = $"Select* from LogUsers where LoginU = '{tbxPL.Text}' and Email = '{tbxM.Text}' ";
				}
				else
					if (rbtP.Checked)
				{
					TxtQuery = $"Select* from LogUsers where PassU = '{tbxPL.Text}' and Email = '{tbxM.Text}' ";
				}

				SqlConnection Con = new SqlConnection(Form1.TxtCon);
				SqlCommand Quey1 = new SqlCommand(TxtQuery, Con);
				Con.Open();
				Quey1 = new SqlCommand(TxtQuery, Con);
				SqlDataReader Res = Quey1.ExecuteReader();

				if (Res.HasRows)
				{

					Res.Read();
					
					string ID = Res["IdUser"].ToString();
					Con.Close();
					try
					{


						MailAddress fromAdress = new MailAddress("novozybkovadm@mail.ru", "Новозыбковская городская администрация");

						MailAddress toAdress = new MailAddress(tbxM.Text);
						Random rnd = new Random();
						string ePass = rnd.Next(1, 10).ToString() + rnd.Next(1, 10).ToString() + rnd.Next(1, 10).ToString() + rnd.Next(1, 10).ToString() + rnd.Next(1, 10).ToString() + rnd.Next(1, 10).ToString() + rnd.Next(1, 10).ToString() + rnd.Next(1, 10).ToString() + rnd.Next(1, 10).ToString();

						TxtQuery = $@"Update LogUsers set ePass ='{ePass}' , DateOfLogin = GETDATE() where IdUser = {ID}";
						Con.Open();
						SqlCommand Quey11 = new SqlCommand(TxtQuery, Con);
						Quey11.ExecuteNonQuery();
						Con.Close();

						MailMessage mess = new MailMessage(fromAdress, toAdress);
						mess.Body = $"Ваш код для восстановления доступа: {ePass}";
						mess.Subject = $"Восстановление доступа в программу";

						SmtpClient client = new SmtpClient();
						client.Host = "smtp.mail.ru";
						client.Port = 587; // Обратите внимание что порт 587
						client.EnableSsl = true;
						client.Credentials = new NetworkCredential("novozybkovadm@mail.ru", "Eq9lC4YbGlJdGM2xdCpT");

						client.Send(mess);

						MessageBox.Show($"Сообщение отправлено. Если не видите его, проверьте папку Спам. \n Введите код в появившееся поле.");

						f = true;
						tbxK.Visible = true;
						lblK.Visible = true;
					}
					catch
					{
						MessageBox.Show($"Произошла неизвестная ошибка. Код: FHL1ErMail. Сообщите об этом программисту.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else 
				{
					MessageBox.Show($"Пользователя с такими данными нет. \r\nПожалуйста, проверьте правильность полей и повторите попытку еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			else if (f == true)
			{
				string TxtQuery = "";
				if (rbtL.Checked)
				{
					TxtQuery = $"Select* from LogUsers where LoginU = '{tbxPL.Text}' and Email = '{tbxM.Text}' and ePass = '{tbxK.Text}'";
				}
				else
					if (rbtP.Checked)
				{
					TxtQuery = $"Select* from LogUsers where PassU = '{tbxPL.Text}' and Email = '{tbxM.Text}' and ePass = '{tbxK.Text}'";
				}
				SqlConnection Con = new SqlConnection(Form1.TxtCon);
				SqlCommand Quey1 = new SqlCommand(TxtQuery, Con);
				Con.Open();
				Quey1 = new SqlCommand(TxtQuery, Con);
				SqlDataReader Res = Quey1.ExecuteReader();
				if (Res.HasRows)
				{
					Res.Read();
					string ID = Res["IdUser"].ToString();
					Con.Close();
					string s = "", symb = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
					Random rnd = new Random();

					for (int i = 0; i < 10; i++)
					{
						s += symb[rnd.Next(0, symb.Length)];
					}

					string b = "";

					if(rbtL.Checked)
					{
						TxtQuery = $@"Update LogUsers set PassU ='{s}', DateOfLogin = GETDATE() where IdUser = {ID}";
						Con.Open();
						SqlCommand Quey11 = new SqlCommand(TxtQuery, Con);
						Quey11.ExecuteNonQuery();
						Con.Close();
						b = $"Ваш новый пароль: {s}";
					}	
					else
						if(rbtP.Checked)
					{
						TxtQuery = $@"Update LogUsers set LoginU ='{s}', DateOfLogin = GETDATE() where IdUser = {ID}";
						Con.Open();
						SqlCommand Quey11 = new SqlCommand(TxtQuery, Con);
						Quey11.ExecuteNonQuery();
						Con.Close();

						b = $"Ваш новый логин: {s}";
					}
					try
					{



						MailAddress fromAdress = new MailAddress("novozybkovadm@mail.ru", "Новозыбковская городская администрация");
						MailAddress toAdress = new MailAddress(tbxM.Text);

						MailMessage mess = new MailMessage(fromAdress, toAdress);
						mess.Body = b;
						mess.Subject = $"Восстановление доступа в программу";

						SmtpClient client = new SmtpClient();
						client.Host = "smtp.mail.ru";
						client.Port = 587; // Обратите внимание что порт 587
						client.EnableSsl = true;
						client.Credentials = new NetworkCredential("novozybkovadm@mail.ru", "Eq9lC4YbGlJdGM2xdCpT");

						client.Send(mess);

						MessageBox.Show($"Ваш новый логин/пароль выслан на e-mail.");
					}
					catch
					{
						MessageBox.Show($"Упс, мы сломались. \r\nКод: FHL2ErMail. Сообщите об этом программисту.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show($"Пользователя с такими данными нет. \r\nПожалуйста, проверьте правильность полей и повторите попытку еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			
		}

		private void rbtL_CheckedChanged(object sender, EventArgs e)
		{
			label1.Text = "Введите ваш логин";

		}

		private void rbtP_CheckedChanged(object sender, EventArgs e)
		{
			label1.Text = "Введите ваш пароль";
		}
	}
}
