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
    
    public class AddrController : Controller
    {
        private readonly MvcWebAppDbContex _db;
        public AddrController(MvcWebAppDbContex db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.Addresses.ToList();
            return View(displaydata);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewAddrClass nac)
        {
            if (ModelState.IsValid)
            {
                _db.Add(nac);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nac);
        }
        [Authorize(Roles = "Editor")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getAddrDetails = await _db.Addresses.FindAsync(id);
            return View(getAddrDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(NewAddrClass na)
        {
            if (ModelState.IsValid)
            {
                _db.Update(na);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(na);
        }
        [Authorize(Roles = "Editor")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getAddrDetails = await _db.Addresses.FindAsync(id);
            return View(getAddrDetails);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getAddrDetails = await _db.Addresses.FindAsync(id);
            return View(getAddrDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {

            var getAddrDetails = await _db.Addresses.FindAsync(id);
            _db.Addresses.Remove(getAddrDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}


