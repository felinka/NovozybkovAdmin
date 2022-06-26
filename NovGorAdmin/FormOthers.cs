using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovGorAdmin
{
	public partial class FormOthers : Form
	{

		//Поля
		private IconButton currentBtn;
		private Panel leftBorderBtn;
		private Form currentChildForm;
		public FormOthers()
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

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnMin_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblT.Text = DateTime.Now.ToLongTimeString();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			currentChildForm.Close();
			Reset();
		}

		private void Reset()
		{
			DisableButton();
			leftBorderBtn.Visible = false;
			iconCurrentChildForm.IconChar = IconChar.Home;
			iconCurrentChildForm.IconColor = Color.Khaki;
			lblTitleChildForm.Text = "Начало";
		}
	}
}
