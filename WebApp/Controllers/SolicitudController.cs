using Microsoft.AspNetCore.Mvc;
using Clases;
using ModeloDb;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Operaciones;
using System.Linq;

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
            return View();
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
        [HttpGet]
        public IActionResult Validar()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Validar(int id)
        {
            var soli = db.Solicitudes
                 .Include(u => u.Usuario)
                 .Include(t => t.Tarjeta)
                 .Include(d => d.Deuda)
                 .Include(det => det.SolicitudDets)
                 .ThenInclude(p => p.PorcentajeEndeudamiento)
                 .Include(c => c.Registro)
                 .Single(m => m.id == id);
            //preparo clase clacular 
            var confif = db.Configuracions.Single();
            PorPor porcetaje = new PorPor(confif);
            ViewBag.Vali = porcetaje;

            return View(soli);

        }
    }
}

