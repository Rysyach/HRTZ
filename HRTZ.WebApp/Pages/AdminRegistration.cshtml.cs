#nullable enable
using System.Linq;
using System.Threading.Tasks;
using HRTZ.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRTZ.WebApp.Pages;

public class AdminRegistration : PageModel
{
    private readonly HRTZDbContext _dbContext;
    

    public AdminRegistration(HRTZDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [BindProperty]
    public Admin? Admin { get; set; }
    [BindProperty]
    public string login { get; set; }
    [BindProperty]
    public string password { get; set; }
    
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        Admin = new Admin() { Login = login, Password = password };
        _dbContext.Admins.Add(Admin);
        _dbContext.SaveChanges();
        return RedirectToPage("./UserAuthorization");
    }
}