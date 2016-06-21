using System.Windows.Forms;
using ToyFactory.Dal;
using ToyFactory.Dal.Repositories.Implementation;

namespace ToyFactory.Forms.UsersForms
{
    public partial class UsersList : Form
    {
        public UsersList(ToyFactoryContext context)
        {
            InitializeComponent();

            var userRepository = new UserRepository(context);

            dataGridView1.DataSource = userRepository.GetUsers();
            dataGridView1.Columns["PasswordHash"].Visible = false;
            dataGridView1.Columns["AnswerToSecretQuestion"].Visible = false;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}
