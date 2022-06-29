#nullable enable
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HRTZ.Core;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;


namespace HRTZ.WebApp.Pages
{
    public class CandidateModel : PageModel
    {
        private readonly HRTZDbContext _dbContext;

        public CandidateModel(HRTZDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        

        [BindProperty]
        public Candidate? Candidate { get; set; }
        
        public void OnGet(int id)
        {
            Candidate = _dbContext.Candidates
                .First(c => c.Id == id);
        }
        
        public void OnPost()
        {
            Candidate!.OnTest = true;
            foreach (var admin in _dbContext.Admins)
            {
                admin.CandidatesOnTest.Add(Candidate);
            }
            _dbContext.Candidates.Add(Candidate);
            _dbContext.SaveChanges();
        }
    }
}
