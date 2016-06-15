using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        /// <summary>
        /// ����� ������������ ��� ����� ������������ � �������
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// ������ �� ������ �������� � �������� ����, �� ����� �������� �� ���
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// ����� �� ��������� ������
        /// </summary>
        public string AnswerToSecretQuestion { get; set; }
    }
}