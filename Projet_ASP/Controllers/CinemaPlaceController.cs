using BLL_Cinema.Entities;
using BLL_Cinema.Services;
using DAL_Cinema.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_ASP.Handlers;
using Projet_ASP.Models.CinemePlace;
using Shared.Repositories;
using static System.Collections.Specialized.BitVector32;

namespace Projet_ASP.Controllers
{
    public class CinemaPlaceController : Controller
    {
        private readonly ICinemaPlaceRepository<CinemaPlace> _cinemaPlaceRepository;

        public CinemaPlaceController(ICinemaPlaceRepository<CinemaPlace> cinemaPlaceRepository)
        {
            _cinemaPlaceRepository = cinemaPlaceRepository;
        }

        //GET: CinemaPlaceController
        public ActionResult Index()
        {
            IEnumerable<CinemaPlaceListItemViewModel> model = _cinemaPlaceRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: CinemaPlaceController/Details/5
        public ActionResult Details(int id)
        {
            CinemaPlaceDetailsViewModel model = _cinemaPlaceRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: CinemaPlaceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CinemaPlaceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CinemaPlaceCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues.");
                if (!ModelState.IsValid) throw new Exception();
                int id = _cinemaPlaceRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new {id});
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaPlaceController/Edit/5
        public ActionResult Edit(int id)
        {
            CinemaPlaceEditForm model = _cinemaPlaceRepository.Get(id).Edit();
            if(model is null) throw new ArgumentOutOfRangeException(nameof(id));
            return View(model);
        }

        public ICinemaPlaceRepository<CinemaPlace> Get_cinemaPlaceRepository()
        {
            return _cinemaPlaceRepository;
        }

        // POST: CinemaPlaceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CinemaPlaceEditForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de donées reçues");
                if (!ModelState.IsValid) throw new Exception();
                _cinemaPlaceRepository.Update(form.EditToBLL());
                return RedirectToAction(nameof(Details), new {id});
            }
            catch
            {
                return View(form);
            }
        }

        // GET: CinemaPlaceController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                CinemaPlaceDeleteViewModel model = _cinemaPlaceRepository.Get(id).Delete();
                if (model is null) throw new InvalidCastException();
                return View(model);
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = $"L'identifiant {id} est invalide";
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: CinemaPlaceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CinemaPlaceDeleteViewModel model)
        {
            try
            {
                _cinemaPlaceRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
