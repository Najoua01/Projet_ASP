using BLL_Cinema.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_ASP.Handlers;
using Projet_ASP.Models.CinemaRoom;
using Shared.Repositories;

namespace Projet_ASP.Controllers
{
    public class CinemaRoomController : Controller
    {
        private readonly ICinemaRoomRepository<CinemaRoom> _cinemaRoomRepository;
        public CinemaRoomController(ICinemaRoomRepository<CinemaRoom> cinemaRoomRepository)
        {
            _cinemaRoomRepository = cinemaRoomRepository;
        }

        // GET: CinemaRoomController
        public ActionResult Index()
        {
            IEnumerable<CinemaRoomListItemViewModel> model = _cinemaRoomRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: CinemaRoomController/Details/5
        public ActionResult Details(int id)
        {
            CinemaRoomDetailsViewModel model = _cinemaRoomRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: CinemaRoomController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CinemaRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaRoomController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CinemaRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaRoomController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CinemaRoomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
