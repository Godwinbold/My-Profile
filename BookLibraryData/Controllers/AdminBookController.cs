using BookLibraryData.Data;
using BookLibraryData.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace BookLibraryData.Controllers
{
    public class AdminBookController : Controller
    {
        private BookDbContext _bookDbContext;
        public AdminBookController(BookDbContext bookDbContext)
        {
            
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Submit(AddBookRequest addBookRequest)
        {
            

            return View("Add");
        }
    }
}
