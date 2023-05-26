using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
      private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {

        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        // Film[] films = _db.Films.ToArray();
        // Actor[] actors = _db.Actors.ToArray();
        // Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        // model.Add("films", films);
        // model.Add("actors", actors);
        // return View(model);
        return View();
      }
    }
}