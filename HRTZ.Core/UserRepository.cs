using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace HRTZ.Core
{
    public class UserRepository
    {
        private readonly List<User> _users;

        public UserRepository()
        {
            var file = File.ReadAllText("users.json");
            _users = JsonSerializer.Deserialize<List<User>>(file)!;
        }
        
        public List<User> GetAll() => _users;

        public User ByLoginAndPassword(string login, string password)
        {
            return _users.FirstOrDefault(u => u.Password.Equals(password) && u.Login.Equals(login));
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void SaveChanges()
        {
            var serialized = JsonSerializer.Serialize(_users);
            File.WriteAllText("users.json", serialized);
        }
    }
}