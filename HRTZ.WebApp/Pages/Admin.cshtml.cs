using System.Collections.Generic;
using System.Linq;
using HRTZ.Core;
using HRTZ.WebApp;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRTZ.WebApp.Pages
{
    public class AdminModel : PageModel
    {
        private readonly HRTZDbContext _dbContext;


        public AdminModel(HRTZDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Admin Admin { get;  set; }
        public Candidate Candidate { get; set; }
        

        public void OnGet(int id)
        {
            Admin = _dbContext.Admins.First(u => u.Id == id);
        }
        
        public void OnPostDecline(int id)
        {
            Candidate = _dbContext.Candidates.FirstOrDefault(c => c.Id == id);
            Candidate.IsDeclined = true;
            foreach (var admin in _dbContext.Admins)
            {
                admin.CandidatesOnTest.Remove(Candidate);
            }
            _dbContext.SaveChanges();
        }
        
        public void OnPostAccept(int id)
        {
            Candidate = _dbContext.Candidates.FirstOrDefault(c => c.Id == id);
            foreach (var user in _dbContext.Users)
            {
                user.CandidatesOnTest.Add(Candidate);
                _dbContext.SaveChanges();
            }
        }
        
    }
}