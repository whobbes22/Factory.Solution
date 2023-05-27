using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    
    public ActionResult Index()
    {
      return View(_db.Machines.ToList());
      //return View();
    }
    
    public ActionResult Details(int id)
    {
      Machine thisMachine = _db.Machines
                .Include(machine => machine.JoinEntities)
                .ThenInclude(join => join.Engineer)
                .FirstOrDefault(machines => machines.MachineId == id);
      // ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
      return View(thisMachine);
    }


    public ActionResult Create()
    {
     
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      if(!ModelState.IsValid)
      {
        return View(machine);
      } 
      else
      {
        _db.Machines.Add(machine);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    public ActionResult AddEngineer(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
      return View(thisMachine);
      
    }

    [HttpPost]
    public ActionResult AddEngineer(Machine machine, int engineerId)
    {
      #nullable enable
      MachineEngineer? joinEntity = _db.MachineEngineers.FirstOrDefault(join => (join.EngineerId == engineerId && join.MachineId == machine.MachineId));
      #nullable disable
      if( joinEntity == null && engineerId !=0)
      {
        _db.MachineEngineers.Add(new MachineEngineer() {EngineerId = engineerId, MachineId = machine.MachineId});
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = machine.MachineId});
    }

    public ActionResult Delete(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(ma => ma.MachineId == id);
      _db.Machines.Remove(thisMachine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteJoin(int joinId)
    {
      MachineEngineer joinEntry = _db.MachineEngineers.FirstOrDefault(entry => entry.MachineEngineerId == joinId);
      _db.MachineEngineers.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);
    }

    [HttpPost]
    public ActionResult Edit(Machine machine)
    {
      if(!ModelState.IsValid)
      {
        return View(machine);
      }
      else 
      {
        _db.Machines.Update(machine);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }

    }
    
  }
}