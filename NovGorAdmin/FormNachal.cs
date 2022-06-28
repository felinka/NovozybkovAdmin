using FontAwesome.Sharp;
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
using System.IO;
using System.Data.SqlClient;

namespace NovGorAdmin
{
	public partial class FormNachal : Form
	{
		public FormNachal()
		{
			InitializeComponent();


			lblT.Text = "";
			timer1.Enabled = true;
			timer1.Interval = 1000;

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

		private void iconButton1_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color3);
			OpenChildForm(new FormProf());
		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color3);
			OpenChildForm(new FormForProgrammer());
		}

		private void iconButton3_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color3);
			OpenChildForm(new FormNachalToEmployees());
		}

		private void iconPictureBox2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void iconPictureBox1_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void iconButton4_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color3);
			OpenChildForm(new FormProfilesRabot());
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

		private void iconButton5_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color3);
			OpenChildForm(new FormProjects());
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblT.Text = DateTime.Now.ToLongTimeString();
		}

		private void iconButton6_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string t;
				

				string TxtQ = "Select* from ProjectsIdeas Where StatusId = 1";

				SqlConnection Con = new SqlConnection(Form1.TxtCon);
				Con.Open();
				SqlCommand Q = new SqlCommand(TxtQ, Con);
				
				SqlDataReader res = Q.ExecuteReader();
				int count = 0;
				if (res.HasRows)
				{
					StreamWriter f = new StreamWriter(new FileStream(saveFileDialog1.FileName, FileMode.Create), Encoding.GetEncoding(1251));
					t = "Номер идеи;Главный проектировщик;Суть проекта;Дата разработки проекта;Принявший начальник";
					f.WriteLine(t);
					while (res.Read())
					{
						t = "";
						count++;
						t += count + ";";
						t += res["FIOPr"].ToString() + ";";
						t += res["TextId"].ToString() + ";";
						t += res["DateId"].ToString().Substring(0,10) + ";";
						t += res["FIONach"].ToString() + ";";

						f.WriteLine(t);
					}
					f.Close();
					MessageBox.Show("Файл успешно сохранён!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				else
				{
					MessageBox.Show("Нет принятых проектов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				
				
			}
		}
	}
}
