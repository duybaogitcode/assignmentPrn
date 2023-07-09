using AutoMapper;
using DTO;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private readonly IMapper _mapper;
        private AccountDTO AccountDTO;
        LoginForm login;
        public Form1(IMapper mapper)
        {

            InitializeComponent();
            picLogo.ImageLocation = "https://firebasestorage.googleapis.com/v0/b/fxchangesapmle.appspot.com/o/c%23%2Fpng-transparent-brown-coffee-logo-brown-coffee-logo.png?alt=media&token=2b45343b-3e1f-4010-8dcf-3ad56328adb0";
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.None;
            _mapper = mapper;
            ibtnLogout.Visible = false;
            login = new LoginForm(_mapper);
            openChildForm(login);
            loginPicture.ImageLocation = "C:\\Users\\duyba\\OneDrive\\Desktop\\video\\66bf70495aaf1bd998f73ac92ca931bb4dbe132a6e926435a4bbcf7f72161689.jpg";
            loginPicture.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void openChildForm(Form childForm)
        {

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            else
            {
                currentChildForm = childForm;
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void AcctiveBtn(object sender, Color color)
        {
            if (sender != null)
            {
                DisableBtn();

                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
            ibtnLogout.Visible = true;
            lbHello.Text = "Xin chào " + login.DisplayName;
        }

        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(35, 38, 46);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ibtnHome_Click(object sender, EventArgs e)
        {
            if (!login.isLogin || login.isLogin == false)
            {
                MessageBox.Show("Bạn cần phải đăng nhập trước");
                return;
            }
            this.AcctiveBtn(sender, RGBColors.color);
            this.openChildForm(new shopForm(_mapper));
            lbMenu.Text = ibtnHome.Text;
        }

        private void ibtnEmp_Click(object sender, EventArgs e)
        {
            if (!login.isLogin || login.isLogin == false)
            {
                MessageBox.Show("Bạn cần phải đăng nhập trước");
                return;
            }
            this.AcctiveBtn(sender, RGBColors.color);
            this.openChildForm(new accountForm(_mapper));
            lbMenu.Text = ibtnEmp.Text;

        }

        private void ibtnProducts_Click(object sender, EventArgs e)
        {
            if (!login.isLogin || login.isLogin == false)
            {
                MessageBox.Show("Bạn cần phải đăng nhập trước");
                return;
            }
            this.AcctiveBtn(sender, RGBColors.color);
            this.openChildForm(new productForm(_mapper));
            lbMenu.Text = ibtnProducts.Text;
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Close-Maximize-Minimize
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void ibtnSetting_Click(object sender, EventArgs e)
        {
            this.AcctiveBtn(sender, RGBColors.color);

        }

        private void ibtnDashboard_Click(object sender, EventArgs e)
        {
            if (!login.isLogin || login.isLogin == false)
            {
                MessageBox.Show("Bạn cần phải đăng nhập trước");
                return;
            }
            this.AcctiveBtn(sender, RGBColors.color);
            this.openChildForm(new dashboardForm(_mapper));
            lbMenu.Text = ibtnDashboard.Text;
        }

        private void ibtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private struct RGBColors
        {
            public static Color color = Color.FromArgb(172, 126, 241);
        }


    }
}