using System;
using System.Windows.Forms;
using ToyFactory.Dal;
using ToyFactory.Dal.Repositories.Implementation;
using ToyFactory.Forms;
using ToyFactory.Forms.UsersForms;

namespace ToyFactory
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var fastRun = true;
            var userrepository = new UserRepository(new ToyFactoryContext());

            var users = userrepository.GetUsers();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (fastRun)
            {
                Application.Run(new Form1());
            }
            else
            {
                if (users.Count > 0)
                {
                    // run login
                    Application.Run(new LoginForm(userrepository));
                }
                else
                {
                    //run registration form
                    Application.Run(new СreateUserForm(userrepository));
                }
            }
           
        }
    }
}
