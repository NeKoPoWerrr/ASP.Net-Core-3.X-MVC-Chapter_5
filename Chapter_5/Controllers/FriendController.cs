using Chapter_5.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter_5.Controllers
{
    public class FriendController : Controller
    {
        private readonly DatabaseContext _context;
        public FriendController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Friends.ToListAsync());
        }
        //GET:Friends/Details/5
        /*public async Task<IActionResult> Details(int? id)
        {
            //return View(friend)
        }
        */
    }
}
