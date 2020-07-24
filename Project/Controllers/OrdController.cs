using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Project.Controllers
{
    public class OrdController : Controller
    {
        private readonly MvcWebAppDbContex _db;
        public OrdController(MvcWebAppDbContex db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.Orders.ToList();
            return View(displaydata);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewOrdClass noc)
        {
            if (ModelState.IsValid)
            {
                _db.Add(noc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(noc);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getOrdDetails = await _db.Orders.FindAsync(id);
            return View(getOrdDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(NewOrdClass no)
        {
            if (ModelState.IsValid)
            {
                _db.Update(no);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(no);
        }
       
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getOrdDetails = await _db.Orders.FindAsync(id);
            return View(getOrdDetails);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getOrdDetails = await _db.Orders.FindAsync(id);
            return View(getOrdDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {

            var getOrdDetails = await _db.Orders.FindAsync(id);
            _db.Orders.Remove(getOrdDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}



