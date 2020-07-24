using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Project.Controllers
{
    public class CustController : Controller
    {
        private readonly MvcWebAppDbContex _db;
        public CustController(MvcWebAppDbContex db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.Customers.ToList();
            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewCustClass ncc)
        {
            if (ModelState.IsValid)
            {
                _db.Add(ncc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ncc);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getCustDetails = await _db.Customers.FindAsync(id);
            return View(getCustDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(NewCustClass nc)
        {
            if (ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nc);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getCustDetails = await _db.Customers.FindAsync(id);
            return View(getCustDetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getCustDetails = await _db.Customers.FindAsync(id);
            return View(getCustDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {

            var getCustDetails = await _db.Customers.FindAsync(id);
            _db.Customers.Remove(getCustDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
