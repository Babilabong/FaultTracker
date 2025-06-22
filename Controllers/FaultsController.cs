using Microsoft.AspNetCore.Mvc;
using FaultTracker.DataAccess;
using FaultTracker.Models;
using System.Collections.Generic;
using System;

namespace FaultTracker.Controllers
{
    public class FaultsController : Controller
    {

        private readonly FaultService _service;

        public FaultsController(FaultService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var faults = await _service.GetAllAsync();
            return View(faults);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Fault fault)
        {
            fault.ReportedAt = DateTime.Now;
            fault.Status = "open";
            await _service.AddAsync(fault);
            return RedirectToAction("Index");
        }
    }
}