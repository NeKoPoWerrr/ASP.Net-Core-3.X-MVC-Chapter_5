﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Chapter_5.Models;

namespace Chapter_5.Controllers
{
    public class FriendsController : Controller
    {
        private readonly FriendsContext _context;

        public FriendsController(FriendsContext context)
        {
            _context = context;
        }

        // GET: Friends
        public async Task<IActionResult> Index()
        {
            return View(await _context.Friends.ToListAsync());
        }

        // GET: Friends/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var friends = await _context.Friends
                .FirstOrDefaultAsync(m => m.Id == id);
            if (friends == null)
            {
                return NotFound();
            }

            return View(friends);
        }

        // GET: Friends/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Friends/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Phone,City")] Friends friends)
        {
            if (ModelState.IsValid)
            {
                _context.Add(friends);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(friends);
        }

        // GET: Friends/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var friends = await _context.Friends.FindAsync(id);
            if (friends == null)
            {
                return NotFound();
            }
            return View(friends);
        }

        // POST: Friends/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Phone,City")] Friends friends)
        {
            if (id != friends.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(friends);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FriendsExists(friends.Id))
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
            return View(friends);
        }

        // GET: Friends/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var friends = await _context.Friends
                .FirstOrDefaultAsync(m => m.Id == id);
            if (friends == null)
            {
                return NotFound();
            }

            return View(friends);
        }

        // POST: Friends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var friends = await _context.Friends.FindAsync(id);
            _context.Friends.Remove(friends);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FriendsExists(int id)
        {
            return _context.Friends.Any(e => e.Id == id);
        }
    }
}
