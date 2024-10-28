using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var stats = new 
        {
            ArtistsCount = _context.Artists.Count(),
            GenresCount = _context.Genres.Count(),
            SongsCount = _context.MusicVideos.Count()
        };
        return View(stats);
    }
}
