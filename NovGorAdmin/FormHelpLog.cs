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
	public partial class FormHelpLog : Form
	{
		public FormHelpLog()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(tbxFam.Text == "" || tbxName.Text == "" || tbxN.Text == "" || tbxKabinet.Text == "")
			{
				MessageBox.Show($"Не все поля заполнены. \r\nПожалуйста, проверьте правильность полей и повторите попытку еще раз.", "Обращение НЕ отправлено.", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
				
			}
			string TextMes = $@"Возникла проблема с входом: - ФИО: {tbxFam.Text} {tbxName.Text} {tbxOtch.Text} ";
			if(rbtFL.Checked)
			{
				TextMes += "- Забыл(а) логин";
			}
			else if (rbtFP.Checked)
			{
				TextMes += "- Забыл(а) пароль";
			}
			else if(rbtDr.Checked)
			{
				TextMes += "- Проблема с чем-то другим";
			}

			if(rbtNPr.Checked)
			{
				TextMes += $@" - IdUser: {tbxN.Text}";
			}
			else if (rbtSNP.Checked)
			{
				TextMes += $@" - Серия и номер паспорта: {tbxN.Text}";
			}

			TextMes += $@" - Номер кабинета: {tbxKabinet.Text}";

			SqlConnection con = new SqlConnection(Form1.TxtCon);
			con.Open();
			SqlCommand Q = new SqlCommand($@"Insert into [RepLog] (TextRep, DateRep) Values ('{TextMes}', GETDATE())", con);
			Q.ExecuteNonQuery();
			con.Close();

			MessageBox.Show($"Ожидайте. \r\nСкоро к вам подойдёт системный программист.", "Обращение отправлено.", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
