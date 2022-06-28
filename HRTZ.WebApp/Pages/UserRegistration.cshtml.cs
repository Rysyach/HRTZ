#nullable enable
using System.Linq;
using System.Threading.Tasks;
using HRTZ.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRTZ.WebApp.Pages;

public class UserRegistration : PageModel
{
    private readonly HRTZDbContext _dbContext;
    

    public UserRegistration(HRTZDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [BindProperty]
    public User? User { get; set; }
    [BindProperty]
    public string login { get; set; }
    [BindProperty]
    public string password { get; set; }
    
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        User = new User() { Login = login, Password = password };
        _dbContext.Users.Add(User);
        _dbContext.SaveChanges();
        return RedirectToPage("./UserAuthorization");
    }
}