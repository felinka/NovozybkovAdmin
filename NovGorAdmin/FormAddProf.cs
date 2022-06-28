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
	public partial class FormAddProf : Form
	{
		public string NewID = "";
		List<string> LstINN = new List<string>();
		List<string> LstP = new List<string>();
		public FormAddProf()
		{
			InitializeComponent();

			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();


			string StrQuarte = $@"Select IdUser as 'IDNew',   IdUser From ListUsers";
			SqlCommand Quarte1 = new SqlCommand(StrQuarte, Con);
			SqlDataReader Res = Quarte1.ExecuteReader();
			while (Res.Read())
			{
				NewID = (int.Parse(Res["IDNew"].ToString()) +1).ToString();
			}
			Con.Close();
			Con.Open();
			StrQuarte = $@"Select  INNU , PasspotU From ListUsers";
			SqlCommand Quarte12 = new SqlCommand(StrQuarte, Con);
			SqlDataReader Res2 = Quarte12.ExecuteReader();
			while (Res2.Read())
			{
				LstINN.Add(Res2["INNU"].ToString());
				LstP.Add(Res2["PasspotU"].ToString());
			}

			Con.Close();
			cbxDolzh.SelectedIndex = 0;
			cbxG.SelectedIndex = 0;
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			tbxOklad.Text = tbxOklad.Text.Replace('.', ',');
			if(tbxFam.Text == "" || tbxName.Text == ""  || (cbxDolzh.SelectedIndex == 4 && tbxDolzh.Text=="") ||  dateTimePicker1.Value.ToString().Substring(0, 10) == DateTime.Today.ToString().Substring(0, 10) || tbxINN.Text.Length <12 || tbxP.Text.Length <10  )
			{
				MessageBox.Show($"Введены не все понял. \nПожалуйста, дозаполните и повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if(LstINN.Contains(tbxINN.Text))
			{
				MessageBox.Show($"Такой ИНН уже используется у другого работника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (LstP.Contains(tbxP.Text))
			{
				MessageBox.Show($"Такой ИНН уже используется у другого работника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DialogResult res = MessageBox.Show($"Вы действительно хотите создать профиль с данными: \n - ФИО: {tbxFam.Text} {tbxName.Text} {tbxOtch.Text} \n - Пол: {cbxG.SelectedItem.ToString()} \n - Должность: {cbxDolzh.SelectedItem.ToString()} {tbxDolzh.Text} \n - Дата рождения: {dateTimePicker1.Value.ToString().Substring(0, 10)} \n - Серия и номер паспорта: {tbxP.Text} \n - ИНН: {tbxINN.Text} \n - Оклад: {tbxOklad.Text}", "Внимание!" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(res == DialogResult.No)
			{
				return;
			}
			string TxtQ = "";
			string D = "";
			if (cbxDolzh.SelectedIndex == 4)
			{
				TxtQ = $"Insert into ListUsers (IdUser, FamU, NameU, OtchU, GenderU, Dolzhn, City, BirthdayU, DateOfStartWork, BoolWork, PasspotU, INNU, Oklad) Values({NewID} , '{tbxFam.Text}', '{tbxName.Text}', '{tbxFam.Text}', '{cbxG.SelectedItem.ToString()}', '{tbxDolzh.Text}', 'Новозыбков', '{dateTimePicker1.Text}' , GETDATE(), 1, {tbxP.Text}, {tbxINN.Text} , {tbxOklad.Text})";
				D = "другое (4) = " + tbxDolzh.Text;
			}
			else
			{

				TxtQ = $"Insert into ListUsers (IdUser, FamU, NameU, OtchU, GenderU, Dolzhn, City, BirthdayU, DateOfStartWork, BoolWork, PasspotU, INNU, Oklad) Values({NewID} , '{tbxFam.Text}', '{tbxName.Text}', '{tbxOtch.Text}', '{cbxG.SelectedItem.ToString()}', '{cbxDolzh.SelectedItem.ToString()}', 'Новозыбков', '{dateTimePicker1.Text}' , GETDATE(), 1, {tbxP.Text}, {tbxINN.Text}, {tbxOklad.Text})";
				D = cbxDolzh.SelectedItem.ToString();
			}
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			SqlCommand Q = new SqlCommand(TxtQ, Con);
			Con.Open();
			Q.ExecuteNonQuery();
			Con.Close();

			string StrQuarte = $@"Insert into RepLog (TextRep, DateRep, BoolCompl, IdUser) Values ('- ТРЕБУЕТСЯ СОЗДАНИЕ АККАУНТА - Для работника {tbxFam.Text} {tbxName.Text} {tbxOtch.Text}, должность : {D} , уникальный номер: {NewID}', GETDATE(), 0, {Form1.IDU})";
			Con.Open();
			SqlCommand Quarte1 = new SqlCommand(StrQuarte, Con);
			Quarte1.ExecuteNonQuery();

			MessageBox.Show($"Профиль работника успешно добавлен! \nПрограммисту автоматически отправлено обращение для создания аккаунта.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

			tbxFam.Text = "";
			tbxName.Text = "";
			tbxDolzh.Text = "";
			tbxINN.Text = "";
			tbxOklad.Text = "";
			tbxOtch.Text = "";
			tbxP.Text = "";
			dateTimePicker1.Value = DateTime.Today;
		}

		private void cbxDolzh_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxDolzh.SelectedIndex == 4)
			{
				lblDolzh.Visible = true;
				tbxDolzh.Visible = true;
			}
			else
			{
				lblDolzh.Visible = false;
				tbxDolzh.Visible = false;
			}

		}
	}
}
