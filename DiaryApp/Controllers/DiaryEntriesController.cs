﻿using DiaryApp.Controllers.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db=db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> objDairyEntryList=_db.DiaryEntries.ToList(); 
            return View(objDairyEntryList);
        }
    }
}
