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

        public void OnGet(int id)
        {
            Admin = _dbContext.Admins.First(u => u.Id == id);
        }
    }
}