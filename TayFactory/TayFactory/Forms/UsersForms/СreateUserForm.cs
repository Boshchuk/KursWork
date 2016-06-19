using System;
using System.Windows.Forms;
using ToyFactory.Dal.Repositories.Implementation;

namespace ToyFactory.Forms.UsersForms
{
    public partial class СreateUserForm : Form
    {
        private readonly UserRepository _userRepository;

        public СreateUserForm(UserRepository userRepository)
        {
            _userRepository = userRepository;
            InitializeComponent();
        }

        private void btnСreate_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        private bool IsValid()
        {
            var state = true;

            state = FormsHelper.IsFieldNotNullAndNotEmpty(txtLogin, errorProvider1);
            state = FormsHelper.IsFieldNotNullAndNotEmpty(txtPassword, errorProvider1);
            state = FormsHelper.IsFieldNotNullAndNotEmpty(txtPasswordRepeat, errorProvider1);
            state = FormsHelper.IsFieldNotNullAndNotEmpty(txtAnswer, errorProvider1);

            state = IsPasswordsEqual(txtPassword, txtPasswordRepeat);

            return state;
        }

      

        private bool IsPasswordsEqual(TextBox passTextBox, TextBox secondPassTextBox)
        {
            var res = passTextBox.Text.Equals(secondPassTextBox.Text);

            if (!res)
            {
                errorProvider1.SetError(secondPassTextBox, "Пароль не совпадает");
            }

            return res;
        }

        private void CreateUser()
        {
            if (IsValid())
            {
                if (_userRepository.IsLoginFree(txtLogin.Text))
                {
                    _userRepository.CreateUser(txtLogin.Text, txtPassword.Text, txtAnswer.Text);
                    MessageBox.Show("Пользователь создан. Переход к приложению.");

                    this.Hide();

                    var f = new Form1();
                    f.ShowDialog();

                    this.Dispose();
                }
                else
                {
                    errorProvider1.SetError(txtLogin,"Введите другое имя пользователя, и повторите попытку");
                }
            }
        }
    }
}
