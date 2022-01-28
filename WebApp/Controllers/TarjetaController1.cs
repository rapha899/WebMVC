using Microsoft.AspNetCore.Mvc;
using Clases;
using Microsoft.AspNetCore.Mvc;
using ModeloDb;
using System.Collections;
using System.Collections.Generic;
namespace WebApp.Controllers
{
    public class TarjetaController1 : Controller
    {
        private readonly TarjetaContex db;
        public TarjetaController1(TarjetaContex db)
        {
            this.db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Tarjeta> listaTarjetas = db.Tarjetas;
            return View(listaTarjetas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tarjeta tarjeta)
        {
            db.Tarjetas.Add(tarjeta);
            db.SaveChanges();
            TempData["mensaje"] = $"La Tarjeta {tarjeta.NombreTarjeta} a sido creado creado exitosamente";


            return RedirectToAction("Index");
        }

        //edition usuario
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            //consultar usuario por medio id
            Tarjeta tajeta = db.Tarjetas.Find(Id);
            return View(tajeta);
        }
        [HttpPost]
        public IActionResult Edit(Tarjeta tarjeta)
        {
            //consultar usuario por medio id
            db.Tarjetas.Update(tarjeta);
            db.SaveChanges();
            TempData["mensaje"] = $"La Tarjeta {tarjeta.NombreTarjeta} a sido editado exitosamente";
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            //consultar usuario por medio id
            Tarjeta tarjeta = db.Tarjetas.Find(Id);
            return View(tarjeta);
        }
        [HttpPost]
        public IActionResult Delete(Tarjeta tarjeta)
        {
            //consultar usuario por medio id
            db.Tarjetas.Remove(tarjeta);
            db.SaveChanges();
            TempData["mensaje"] = $"La tarjeta {tarjeta.NombreTarjeta} a sido creado borrado exitosamente";
            return RedirectToAction("Index");

        }
    }
}
