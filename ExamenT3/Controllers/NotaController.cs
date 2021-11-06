using ExamenT3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT3.Controllers
{
    public class NotaController : Controller
    {

        public List<Notas> notas;
        public NotaController( )
        {
   
        }
        public IActionResult Index()
        {
            return View(notas);
        }
        [HttpGet]
        public IActionResult _Index(string search)
        { 

         
            return View( );
        }
        [HttpGet]
        public IActionResult Create()
        {
         
            return View("Create", new Notas());
        }
        [HttpPost]
        public IActionResult Create(Notas nota)
        {
            addNotas(nota);
            return View();
             
        }

        

        public List<Notas> addNotas(Notas nota) {

            
            var notas = new List<Notas> ();

            notas.Add(nota);

            return notas;
            
        }
    }
}
