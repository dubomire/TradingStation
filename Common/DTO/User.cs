using System;

namespace DTO
{
    public class User
    {
        public User(string id, string login, string email, string password)
        {
            Id = id;
            Login = login;
            Email = email;
            Password = password;
        }


        public string Id { get; }
        public string Login { get; }
        public string Email { get; set; }
        public string Password { get; }        
    }
}
