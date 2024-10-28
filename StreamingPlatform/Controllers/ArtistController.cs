using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StreamingPlatform.Models;


public class ArtistController : Controller
{
    private readonly ApplicationDbContext _context;

    public ArtistController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var artists = _context.Artists.ToList();
        return View(artists);
    }

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Artist artist)
    {
        if (ModelState.IsValid)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(artist);
    }

    public IActionResult Edit(int id) => View(_context.Artists.Find(id));

    [HttpPost]
    public IActionResult Edit(Artist artist)
    {
        if (ModelState.IsValid)
        {
            _context.Artists.Update(artist);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(artist);
    }

    public IActionResult Delete(int id)
    {
        var artist = _context.Artists.Find(id);
        _context.Artists.Remove(artist);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
