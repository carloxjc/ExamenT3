using ExamenT3.Models;
using ExamenT3.repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT3.Controllers
{
    public class NotaController : Controller
    {
        readonly NotaInterface notaInterface;
        public NotaController(NotaInterface notaInterface)
        {
            this.notaInterface = notaInterface;

        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = notaInterface.getListaDeNotas();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(string titulo, string descrip)
        {
            notaInterface.guardarNota(titulo, descrip);
         
            return RedirectToAction("Index","Nota");
             
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var nota = notaInterface.editar(id);
            return View(nota);
        }
        [HttpPost]
        public IActionResult Editar(string ti, string cont ,int id)
        {
            notaInterface.editar(id);

            return RedirectToAction("Index", "Nota");
        }

  
        public IActionResult Eliminar(int id)
        {
            notaInterface.eliminar(id);

            return RedirectToAction("Index", "Nota");
        }
     
        
    }
}
