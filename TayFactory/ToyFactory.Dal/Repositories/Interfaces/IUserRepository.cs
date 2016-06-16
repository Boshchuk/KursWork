using System.Collections.Generic;
using ToyFactory.Dal.Models;

namespace ToyFactory.Dal.Repositories.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();

        User GetUser(string login, string password);

        User GetUserForRecover(string login, string secretQuestionAnswer);

        User ResetPassword(User user, string newPassword);

        User CreateUser(string login, string password, string answer);
    }
}