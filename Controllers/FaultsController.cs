using Microsoft.AspNetCore.Mvc;
using FaultTracker.Models;
using System.Collections.Generic;
using System;

namespace FaultTracker.Controllers
{
    public class FaultsController : Controller
    {
        private static List<Fault> faults = new List<Fault>();
        public IActionResult Index()
        {
            return View(faults);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Fault fault)
        {
            fault.Id = faults.Count + 1;
            fault.ReportedAt = DateTime.Now;
            fault.Status = "open";
            faults.Add(fault);
            return RedirectToAction("Index");
        }
    }
}