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

            state = IsFieldNotNullAndNotEmpty(txtLogin);
            state = IsFieldNotNullAndNotEmpty(txtPassword);
            state = IsFieldNotNullAndNotEmpty(txtPasswordRepeat);
            state = IsFieldNotNullAndNotEmpty(txtAnswer);

            state = IsPasswordsEqual(txtPassword, txtPasswordRepeat);

            return state;
        }

        private bool IsFieldNotNullAndNotEmpty(TextBox element)
        {
            var state = true;

            if (string.IsNullOrEmpty(element.Text))
            {
                errorProvider1.SetError(element, "Поле не может быть пустым");
                state = false;
            }

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

                    ShowDialog(new Form1());

                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(txtLogin,"Введите другое имя пользователя, и повторите попытку");
                }
            }
        }
    }
}
