using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        /// <summary>
        /// Логин используется для входа пользователя в систему
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароли не должны хранится в котрытом виде, по этому хранится их хеш
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Ответ на секретный вопрос
        /// </summary>
        public string AnswerToSecretQuestion { get; set; }
    }
}