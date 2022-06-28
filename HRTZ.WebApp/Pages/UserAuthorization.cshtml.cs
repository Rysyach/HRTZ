#nullable enable
using System.Linq;
using System.Threading.Tasks;
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
    [BindProperty]
    public string Login { get; set; }
    [BindProperty]
    public string Password { get; set; }
    
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        User = _dbContext.Users.FirstOrDefault(u => u.Login.Equals(Login) && u.Password.Equals(Password));
        return RedirectToPage("./User", null, new {id = User!.Id});
    }
}

