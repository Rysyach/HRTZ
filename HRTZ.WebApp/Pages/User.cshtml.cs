using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HRTZ.Core;
using HRTZ.WebApp;

namespace HRTZ.WebApp.Pages
{
    public class UserModel : PageModel
    {
        private readonly HRTZDbContext _dbContext;


        public UserModel(HRTZDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User User { get; private set; }

        public void OnGet(int id)
        {
            User = _dbContext.Users.First(u => u.Id == id);
        }
    }
}
