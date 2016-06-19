using System;
using System.Windows.Forms;
using ToyFactory.Dal.Repositories.Implementation;

namespace ToyFactory.Forms.UsersForms
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepository;

        public LoginForm(UserRepository userRepository)
        {
            _userRepository = userRepository;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var user = _userRepository.GetUser(txtLogin.Text, txtPassword.Text);

            if (user.UserId != 0)
            {
                this. Hide();
                
                var form1 = new Form1();
                form1.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Введенные логи и пароль не совпадают с данными в системе, попробуйте еще раз.");
            }

        }

        private void btnCanclel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
