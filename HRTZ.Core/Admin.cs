using System.Collections.Generic;

namespace HRTZ.Core;

public class Admin
{
    public Admin()
    {
            
    }
        
    public Admin(int id, string login, string password)
    {
        Id = id;
        Login = login;
        Password = password;
    }
        
    public int Id {get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    
    public virtual List<Candidate> CandidatesOnTest { get; set; } = new List<Candidate>();
    
}