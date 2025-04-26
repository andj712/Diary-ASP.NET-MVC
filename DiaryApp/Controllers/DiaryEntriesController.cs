using DiaryApp.Controllers.Data;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }

            if (ModelState.IsValid)
            {

                _db.DiaryEntries.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        [HttpGet] //ovo je po defaultu httpget nije moralo da se napise
        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }
            
            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }

            if (ModelState.IsValid)
            {

                _db.DiaryEntries.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        [HttpGet] //ovo je po defaultu httpget nije moralo da se napise
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {
            

           

            _db.DiaryEntries.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            

        }
    }
}
