#nullable enable
using System.Linq;
using System.Threading.Tasks;
using HRTZ.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRTZ.WebApp.Pages;

public class CandidateRegistration : PageModel
{
    private readonly HRTZDbContext _dbContext;
    

    public CandidateRegistration(HRTZDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [BindProperty]
    public Candidate? Candidate { get; set; }
    [BindProperty]
    public string login { get; set; }
    [BindProperty]
    public string password { get; set; }
    
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        Candidate = new Candidate() { Login = login, Password = password };
        _dbContext.Candidates.Add(Candidate);
        _dbContext.SaveChanges();
        return RedirectToPage("./UserAuthorization");
    }
}