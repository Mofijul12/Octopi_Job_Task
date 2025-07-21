using JobTaskByMofijul.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace JobTaskByMofijul.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _context.Users.ToListAsync();
            return View(users); 
        }

        public IActionResult Create()
        {
            return PartialView("Create", new User());
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return PartialView("Create", user);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();
            return PartialView("Edit", user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Update(user);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return PartialView("Edit", user);
        }


        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(); 
        }


        public async Task<IActionResult> Search(string searchName, string searchEmail, string status, string sortOrder)
        {
            var users = _context.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchName))
                users = users.Where(u => u.Name.Contains(searchName));

            if (!string.IsNullOrWhiteSpace(searchEmail))
                users = users.Where(u => u.Email.Contains(searchEmail));

            if (!string.IsNullOrWhiteSpace(status))
                users = users.Where(u => u.Status == status);

            users = sortOrder switch
            {
                "age_asc" => users.OrderBy(u => u.Age),
                "age_desc" => users.OrderByDescending(u => u.Age),
                _ => users
            };

            var result = await users.ToListAsync();
            return PartialView("_UserTable", result);
        }

    }
}
