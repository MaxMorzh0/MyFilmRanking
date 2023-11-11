using Microsoft.AspNetCore.Identity;

namespace MyFilmRanking.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public User(string email, string password, Role role)
        {
            this.Email = email;
            this.Password = password;
            this.Role = role;
        }
    }
}
