using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HRTZ.Core;
using HRTZ.WebApp;

namespace HRTZ.WebApp.Pages
{
    public class UserModel : PageModel
    {
        private readonly HRTZDbContext _dbContext;


        public UserModel(HRTZDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User User { get; set; }
        public Candidate Candidate { get; set; } 

        public void OnGet(int id)
        {
            User = _dbContext.Users.First(u => u.Id == id);
        }
        
        public void OnPostDecline(int id)
        {
            Candidate = _dbContext.Candidates.FirstOrDefault(c => c.Id == id);
            Candidate.IsDeclined = true;
            _dbContext.SaveChanges();
            foreach (var user in _dbContext.Users)
            {
                user.CandidatesOnTest.Remove(Candidate);
            }

            foreach (var admin in _dbContext.Admins)
            {
                admin.CandidatesOnTest.Remove(Candidate);
            }
        }
        
        public void OnPostAccept(int id)
        {
            Candidate = _dbContext.Candidates.FirstOrDefault(c => c.Id == id);
            Candidate.IsApproved = true;
            _dbContext.SaveChanges();
            foreach (var user in _dbContext.Users)
            {
                user.CandidatesOnTest.Remove(Candidate);
            }

            foreach (var admin in _dbContext.Admins)
            {
                admin.CandidatesOnTest.Remove(Candidate);
            }
        }
    }
}
