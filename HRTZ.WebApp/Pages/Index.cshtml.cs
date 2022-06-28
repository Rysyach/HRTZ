using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HRTZ.Core;


namespace HRTZ.WebApp.Pages
{
    public class Index : PageModel
    {
        private readonly HRTZDbContext _dbContext;


        public Index(HRTZDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User User { get; set; }

        public void OnGet()
        {
            User = _dbContext.Users.First(u => u.Id == 1);

            //var user2 = _dbContext.Users.Include(u => u.Likes).First(u => u.Id == 1);


            //User = _dbContext
            //    .Users
            //    .Include(u => u.Likes)
            //    .ThenInclude(c => c.LikedBy)
            //    .First(u => u.Id == 1);

            //var user = _dbContext.Users.First(u => u.Id == 1);
            //_dbContext.Entry(user).Collection(u => u.Likes).Load();


        }
    }
}