using CoreTask2_Moon.DAL;
using CoreTask2_Moon.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreTask2_Moon.Controllers
{
    public class HomeController : Controller
    {

        public readonly AppDbContext db;

        public HomeController(AppDbContext database)
        {
            this.db = database;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                banner= db.Banners.FirstOrDefault(),
                appDetails = db.AppDetails.ToList(),
                categories = db.Categories.ToList(),
                audiences = db.Audiences.ToList(),
                projects = db.Projects.ToList(),
                news = db.News.ToList(),
                services = db.Services.ToList(),
                socialMedias = db.SocialMedias.ToList(),
                pricings= db.Pricings.ToList(),
                clients= db.Clients.ToList()
            };
               return View(vm);
        }
    }
}
