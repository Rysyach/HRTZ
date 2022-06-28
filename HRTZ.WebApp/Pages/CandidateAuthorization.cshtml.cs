#nullable enable
using System.Linq;
using System.Threading.Tasks;
using HRTZ.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRTZ.WebApp.Pages;

public class CandidateAuthorization : PageModel
{
    private readonly HRTZDbContext _dbContext;
    

    public CandidateAuthorization(HRTZDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [BindProperty]
    public Candidate? Candidate { get; set; }
    [BindProperty]
    public string Login { get; set; }
    [BindProperty]
    public string Password { get; set; }

    
    
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        
        Candidate = _dbContext.Candidates.FirstOrDefault(candidate => candidate.Login.Equals(Login) && candidate.Password.Equals(Password));
        return RedirectToPage("/Candidate", null, new {id = Candidate!.Id});
        
    }
}