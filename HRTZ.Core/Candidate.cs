using System;
using System.Collections.Generic;

namespace HRTZ.Core
{
    public class Candidate
    {
        public int Id { get; set; }
        
        public Candidate()
        {
            
        }
        
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public virtual List<User> LikedBy { get; set; }

        public Candidate(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        
    }
}
