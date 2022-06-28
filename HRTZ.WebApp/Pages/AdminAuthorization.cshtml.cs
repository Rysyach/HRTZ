#nullable enable
using System.Linq;
using System.Threading.Tasks;
using HRTZ.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRTZ.WebApp.Pages;

public class AdminAuthorization : PageModel
{
    private readonly HRTZDbContext _dbContext;
    

    public AdminAuthorization(HRTZDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [BindProperty]
    public Admin? Admin { get; set; }
    [BindProperty]
    public string Login { get; set; }
    [BindProperty]
    public string Password { get; set; }
    
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        Admin = _dbContext.Admins.FirstOrDefault(u => u.Login.Equals(Login) && u.Password.Equals(Password));
        return RedirectToPage("./Admin", null, new {id = Admin!.Id});
    }
}