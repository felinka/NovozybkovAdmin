using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Data.SqlClient;

namespace NovGorAdmin
{
	public partial class Form1 : Form
	{
		public static string TxtCon = $@"Data Source=DESKTOP-7TKN3GU\SQLEXPRESS;Initial Catalog=AdminNovozybkov;Integrated Security=True";
		public Form1()
		{
			InitializeComponent();
			leftBorderBtn = new Panel();
			leftBorderBtn.Size = new Size(7, 60);
			panelMenu.Controls.Add(leftBorderBtn);

			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}
		//Поля
		private IconButton currentBtn;
		private Panel leftBorderBtn;
		private Form currentChildForm;


		private struct RGBColors
		{
			public static Color color1 = Color.FromArgb(172, 126, 241);
			//pink
			public static Color color2 = Color.FromArgb(111, 42, 88);
			//persik
			public static Color color3 = Color.FromArgb(212, 183, 149);
			//light green
			public static Color color4 = Color.FromArgb(77, 140, 87);
			//light brown
			public static Color color5 = Color.FromArgb(154, 97, 63);
			//over light green
			public static Color color6 = Color.FromArgb(76, 145, 65);
		}

		//Методы
		private void ActivateButton(object senderBtn, Color color)
		{
			if (senderBtn != null)
			{
				DisableButton();
				currentBtn = (IconButton)senderBtn;
				currentBtn.BackColor = Color.FromArgb(0, 153, 102);
				currentBtn.ForeColor = color;
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = color;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;
				//Left border button
				leftBorderBtn.BackColor = color;
				leftBorderBtn.Location = new Point(0, currentBtn.Location.Y - 6);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();
				////Current Child Form Icon
				iconCurrentChildForm.IconChar = currentBtn.IconChar;
				iconCurrentChildForm.IconColor = color;
			}
		}

		private void DisableButton()
		{
			if (currentBtn != null)
			{
				currentBtn.BackColor = Color.FromArgb(46, 139, 87);
				currentBtn.ForeColor = Color.Gainsboro;
				currentBtn.TextAlign = ContentAlignment.MiddleLeft;
				currentBtn.IconColor = Color.Gainsboro;
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
		}


		private void OpenChildForm(Form childForm)
		{
			//open only form
			if (currentChildForm != null)
			{
				currentChildForm.Close();
			}
			currentChildForm = childForm;
			//End
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelDesktop.Controls.Add(childForm);
			panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			lblTitleChildForm.Text = childForm.Text;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			
		}
		public static string IDU = "", Dolz = "";
		private void button1_Click_1(object sender, EventArgs e)
		{
			string TxtQuery = $"Select* from LogUsers where LoginU = '{tbxLog.Text}' and PassU = '{tbxPass.Text}' ";
			SqlConnection Con = new SqlConnection(TxtCon);
			SqlCommand Quey1 = new SqlCommand(TxtQuery, Con);
			Con.Open();
			Quey1 = new SqlCommand(TxtQuery, Con);
			SqlDataReader Res = null;
			Res = Quey1.ExecuteReader();

			if (Res.HasRows)
			{
				Res.Read();
				IDU = Res["IdUser"].ToString();
				Dolz = Res["Dolzh"].ToString();

				if (Dolz == "0")
				{
					FormFor frm = new FormFor();
					this.Hide();
					frm.ShowDialog();
					frm.lblID.Text = IDU;
				}
			}
			else
			{
				MessageBox.Show($"Пользователя с такими данными нет. \r\nПожалуйста, проверьте правильность полей и повторите попытку еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color3);
			OpenChildForm(new FormHelpLog());
		}

		//Drag Form
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void iconPictureBox1_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void iconPictureBox2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Reset()
		{
			DisableButton();
			leftBorderBtn.Visible = false;
			iconCurrentChildForm.IconChar = IconChar.Home;
			iconCurrentChildForm.IconColor = Color.Khaki;
			lblTitleChildForm.Text = "Авторизация";
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			currentChildForm.Close();
			Reset();
		}
	}
}
