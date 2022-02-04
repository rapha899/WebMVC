using Microsoft.AspNetCore.Mvc;
using Clases;
using Microsoft.AspNetCore.Mvc;
using ModeloDb;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Controllers
{
    public class SolicitudController : Controller
    {
      
        private readonly TarjetaContex db;
        public SolicitudController(TarjetaContex db)
        {
            this.db = db;

        }
        public IActionResult Index()
        {
            var listaSolicitudes = db.Solicitudes
                .Include(solicitudes => solicitudes.Usuario)
                .Include(solicitudes => solicitudes.Deuda)
                .Include(solicitudes => solicitudes.Tarjeta)
                ;
            return View(listaSolicitudes);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Solicitud solicitud)
        {
            db.Solicitudes.Add(solicitud);
            db.SaveChanges();
            TempData["mensaje"] = $"La Solicitud del usuario {solicitud.Usuario} a sido creado creado exitosamente";


            return RedirectToAction("Index");
        }

        //edition solicitud
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            //consultar solicitud por medio del id
            Solicitud solicitud = db.Solicitudes.Find(Id);
            return View(solicitud);
        }
        [HttpPost]
        public IActionResult Edit(Solicitud solicitud)
        {
            //consultar usuario por medio id
            db.Solicitudes.Update(solicitud);
            db.SaveChanges();
            TempData["mensaje"] = $"La Solicitud {solicitud.id} a sido editada exitosamente";
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            //consultar usuario por medio id
            Solicitud solicitud = db.Solicitudes.Find(Id);
            return View(solicitud);
        }
        [HttpPost]
        public IActionResult Delete(Solicitud solicitud)
        {
            //consultar usuario por medio id
            db.Solicitudes.Remove(solicitud);
            db.SaveChanges();
            TempData["mensaje"] = $"La solicitud {solicitud.id} a sido creado borrado exitosamente";
            return RedirectToAction("Index");

        }
    }
}

