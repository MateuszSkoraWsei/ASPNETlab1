using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;
        private static readonly List<BlogViewModel> _articles = new()
        {
            new BlogViewModel
            {
                Title = "My First Blog Post",
                Description = "This is the content of my first blog post.",
                
            },
            new BlogViewModel
            {
                Title = "My Second Blog Post",
                Description = "This is the content of my second blog post.",
            },
            new BlogViewModel
            {
                Title = "My Third Blog Post",
                Description = "This is the content of my third blog post.",
            }

        };
        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View(new BlogViewModel()
            {
                Title = "My First Blog Post",
                Description = "This is the content of my first blog post.",
                

            });
        }
    }
}
