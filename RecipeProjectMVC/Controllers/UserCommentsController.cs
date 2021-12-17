using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipeProjectMVC.Data;
using RecipeProjectMVC.Models;

namespace RecipeProjectMVC.Controllers
{
    public class UserCommentsController : Controller
    {
        private readonly RecipeContext _context;

        public UserCommentsController(RecipeContext context)
        {
            _context = context;
        }

        // GET: UserComments
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserComments.ToListAsync());
        }

        // GET: UserComments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userComments = await _context.UserComments
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (userComments == null)
            {
                return NotFound();
            }

            return View(userComments);
        }

        // GET: UserComments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommentId,commentTitle,CommentDetail")] UserComments userComments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userComments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userComments);
        }

        // GET: UserComments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userComments = await _context.UserComments.FindAsync(id);
            if (userComments == null)
            {
                return NotFound();
            }
            return View(userComments);
        }

        // POST: UserComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CommentId,commentTitle,CommentDetail")] UserComments userComments)
        {
            if (id != userComments.CommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userComments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserCommentsExists(userComments.CommentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userComments);
        }

        // GET: UserComments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userComments = await _context.UserComments
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (userComments == null)
            {
                return NotFound();
            }

            return View(userComments);
        }

        // POST: UserComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userComments = await _context.UserComments.FindAsync(id);
            _context.UserComments.Remove(userComments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserCommentsExists(int id)
        {
            return _context.UserComments.Any(e => e.CommentId == id);
        }
    }
}
