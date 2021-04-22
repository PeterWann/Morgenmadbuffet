using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Morgenmadsbuffeten.Data;
using Morgenmadsbuffeten.Models;

namespace Morgenmadsbuffeten.Controllers
{
    public class ReceptionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReceptionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Receptions

        [Authorize("IsReception")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [Authorize("IsReception")]
        public async Task<IActionResult> Info()
        {
            return View(await _context.Restaurants.ToListAsync());
        }

        [Authorize("IsReception")]

        // GET: Receptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Receptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize("IsReception")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReceptionId,AdultAmounts,ChildrenAmount,CheckInDate")] Reception reception)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reception);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reception);
        }

    }
}
