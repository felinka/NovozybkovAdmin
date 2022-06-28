using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovGorAdmin
{
	public partial class FormProf : Form
	{
		public FormProf()
		{
			InitializeComponent();
			
		}

		private void FormProf_Load(object sender, EventArgs e)
		{
			
			// TODO: данная строка кода позволяет загрузить данные в таблицу "adminNovozybkovDataSet.ListUsers". При необходимости она может быть перемещена или удалена.
			this.listUsersTableAdapter.Fill(this.adminNovozybkovDataSet.ListUsers);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dB_ADM_NVZDataSet.Worker". При необходимости она может быть перемещена или удалена.
			bsUser.Filter = $"IdUser = {Form1.IDU}";
			lblFi.Text = lblFIO.Text + " " + label2.Text + " " + label3.Text;
			
		}

	}
}
