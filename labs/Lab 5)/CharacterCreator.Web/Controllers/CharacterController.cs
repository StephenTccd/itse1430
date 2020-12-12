/*
 * Stephen Nuguid
 * ITSE 1430
 * Lab 5
 */
using System;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;

using CharacterCreator.Web.Models;

namespace CharacterCreator.Web.Controllers
{
    public class CharacterController : Controller
    {
        public CharacterController ()
        {
            var connString = ConfigurationManager.ConnectionStrings["CharacterDatabase"].ConnectionString;

            _database = new CharacterCreator.Sql.SqlCharacterDatabase(connString);
        }
        public ActionResult Index ()
        {
            var character = _database.GetAll();
            var model = character.Select(XmlSiteMapProvider => new CharacterModel())
                                 .OrderBy(x => x.Name);
            return View();
        }
        public ActionResult Details ( int id )
        {
            var character = _database.Get(id);
            if (character == null)
                return HttpNotFound();

            return View(new CharacterModel(character));
        }

        public ActionResult Edit ( int id )
        {
            var character = _database.Get(id);
            if (character == null)
                return HttpNotFound(); 

            return View(new CharacterModel(character));
        }
        public ActionResult Delete ( int id )
        {
            var character = _database.Get(id);
            if (character == null)
                return HttpNotFound(); 

            return View(new CharacterModel(character));
        }
        [HttpPost]
        public ActionResult Delete ( CharacterModel model )
        {
            try
            {
                _database.Delete(model);
                return RedirectToAction(nameof(Index));
            } catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            };

            return View(model);
        }

        public ActionResult Create () => View(new CharacterModel());

        [HttpPost]
        public ActionResult Create ( CharacterModel model )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var character = _database.Add(model.ToCharacter());
                    return RedirectToAction(nameof(Details), new { id = character.Id });
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(model);
        }
        private readonly ICharacterDatabase _database;

       
    }
}
