using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Interfaces;

namespace ToyFactory.Dal.Repositories.Implementation
{
    public class UserRepository : IUserRepository
    {
        private ToyFactoryContext _context;

        public UserRepository(ToyFactoryContext context)
        {
            _context = context;
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.ToArray();
        }

        public User GetUser(string login, string password)
        {
            User user = null;

            var hash = CreateHash(password);

            var allUsers = GetUsers();

            user = allUsers.FirstOrDefault(u => u.Login == login && u.PasswordHash == hash);

            return user;
        }

        public User GetUserForRecover(string login, string secretQuestionAnswer)
        {
            throw new System.NotImplementedException();
        }

        public User ResetPassword(User user, string newPassword)
        {
            throw new System.NotImplementedException();
        }

        public User CreateUser(string login, string password, string answer)
        {
            var hash = CreateHash(password);
            var user = new User()
            {
                Login = login,
                AnswerToSecretQuestion = answer,
                PasswordHash = hash
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return GetUser(login, password);
        }

        private string CreateHash(string password)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, password);

                return hash;
            }
            
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            var comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}