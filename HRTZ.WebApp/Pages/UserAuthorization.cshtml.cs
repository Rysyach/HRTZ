#nullable enable
using System.Linq;
using HRTZ.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRTZ.WebApp.Pages;

public class UserAuthorization : PageModel
{
    private readonly HRTZDbContext _dbContext;
    

    public UserAuthorization(HRTZDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [BindProperty]
    public User? User { get; set; }
    
    public void OnGet()
    {
        
    }

    public IActionResult OnPost(string? login)
    {
        User = _dbContext.Users.FirstOrDefault(u => u.Login.Equals(login));
        return RedirectToPage("/User", User.Id);
    }
}

