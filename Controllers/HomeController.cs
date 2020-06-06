using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaMatters.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediaMatters.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository br;
        private readonly IAlbumRepository ar;
        private readonly IGameRepository gr;
        public HomeController(IBookRepository BookRepo, IAlbumRepository AlbumRepo, IGameRepository GameRepo)
        {
            br = BookRepo;
            ar = AlbumRepo;
            gr = GameRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Albums()
        {
            return View(ar.getAlbums());
        }
        public IActionResult Books()
        {
            return View(br.getBooks());
        }
        public IActionResult Games()
        {
            return View(gr.getGames());
        }
    }
}
