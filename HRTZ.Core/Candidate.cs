using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HRTZ.Core
{
    public class Candidate
    {
        public string Password { get; set; }
        public string Login { get; set; }
        public int Id { get; set; }
        
        public Candidate()
        {
            
        }
        
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public virtual List<User> LikedBy { get; set; }
        public int WorkExperience { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public bool OnTest { get; set; } = false;

        public Candidate(string name, int age, Gender gender, string password, string login)
        {
            Password = password;
            Login = login;
            Name = name;
            Age = age;
            Gender = gender;
        }
        
    }
}
