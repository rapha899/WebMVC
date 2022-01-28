using Clases;
using Microsoft.AspNetCore.Mvc;
using ModeloDb;
using System.Collections;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly TarjetaContex db;
        public UsuarioController(TarjetaContex db) {
          this.db = db;
        
        }
        public IActionResult Index()
        {
            IEnumerable <Usuario> listaUsuarios = db.Usuarios;
            return View(listaUsuarios);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create( Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();
            TempData["mensaje"] = $"El usuario {usuario.Nombre} a sido creado creado exitosamente";


            return RedirectToAction("Index");
        }
       
        //edition usuario
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            //consultar usuario por medio id
            Usuario usuario = db.Usuarios.Find(Id);
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {
            //consultar usuario por medio id
            db.Usuarios.Update(usuario);
            db.SaveChanges();
            TempData["mensaje"] = $"El usuario {usuario.Nombre} a sido editado exitosamente";
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            //consultar usuario por medio id
            Usuario usuario = db.Usuarios.Find(Id);
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Delete(Usuario usuario)
        {
            //consultar usuario por medio id
            db.Usuarios.Remove(usuario);
            db.SaveChanges();
            TempData["mensaje"] = $"El usuario {usuario.Nombre} a sido creado borrado exitosamente";
            return RedirectToAction("Index");

        }
    }
}
