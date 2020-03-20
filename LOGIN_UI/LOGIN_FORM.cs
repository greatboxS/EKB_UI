using EKANBAN_SYS_LIB;
using SYS_MODELS;
using System;
using System.Windows.Forms;

namespace LOGIN_UI
{
    public partial class LOGIN_FORM : Form
    {
        EmployeeQuery EmpployeeQuery;
        public LOGIN_FORM()
        {
            InitializeComponent();
            User = new AppUser();
            ds_User.DataSource = User;
            RequiedUser = 3;
            EmpployeeQuery = new EmployeeQuery(_SERVER.ServerName.Database);
        }

        public AppUser User { get; set; }
        public int UserClass { get; set; }
        private int RequiedUser;
        private bool _status;
        public bool LoginStatus { get { return _status; } }

        public LOGIN_FORM(int UserClass)
        {
            InitializeComponent();
            User = new AppUser();
            ds_User.DataSource = User;
            RequiedUser = UserClass;
            EmpployeeQuery = new EmployeeQuery(_SERVER.ServerName.Database);
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Login();
            }
            catch { }
        }

        private void Login()
        {
            UserClass = 0;
            _status = false;
            lb_loginEXP.Text = "";

            User = EmpployeeQuery.GetAppUser(User.user, User.password);

            if (User == null)
            {
                lb_loginEXP.Text = "User name or password is invalid!";
                return;
            }
            else
            {
                UserClass = ShareFuncs.GetInt(User.userClass);
                if (UserClass == 0 || UserClass == 1)
                    lb_loginEXP.Text = $"Login as Worker, change account to continous! ";

                if (UserClass == 2)
                    lb_loginEXP.Text = $"Login as Officer account successfully! ";

                if (UserClass == 3)
                    lb_loginEXP.Text = "Login as Admin account successfully! ";

                if (UserClass >= RequiedUser)
                {
                    _status = true;
                    this.Close();
                }

            }
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = false;
                User.password = textBox2.Text;
                Login();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
