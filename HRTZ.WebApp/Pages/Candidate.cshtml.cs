using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HRTZ.Core;


namespace HRTZ.WebApp.Pages
{
    public class CandidateModel : PageModel
    {
        private readonly HRTZDbContext _dbContext;

        public CandidateModel(HRTZDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Candidate Candidate { get; private set; }

        public void OnGet(int id)
        {
            Candidate = _dbContext.Candidates.First(c => c.Id == id);
        }
    }
}
