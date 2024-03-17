using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppCrud.Data;
using WebAppCrud.Models;

namespace WebAppCrud.Controllers
{
    public class TaskController : Controller
    {

        private readonly DataBase _context;
        public TaskController(DataBase context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var mydata = _context.NumberTable.ToList();
            return View(mydata);
        }
        [HttpPost]
        public IActionResult Index(int n)
        {
            _context.NumberTable.ExecuteDelete();
            _context.SaveChanges();
            for (int i = 0; i < n; i++)
            {
                if (i % 7 == 0)
                {
                    Numbers num = new Numbers();
                    num.Number = i;
                    _context.NumberTable.Add(num);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

    }
}
