using HumanResourceManagementSystem.Models.Data;
using HumanResourceManagementSystem.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourceManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private HRMSystemDbContext db = new HRMSystemDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee data)
        {
            if (!ModelState.IsValid)
                return View("Create");
            db.Add(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
