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

        private  List<Notas> notas=new List<Notas>();


        public NotaController()
        {
           // notas = new List<Notas>();
        }
        //public IActionResult Index() {

        //    return View("Index");
        //}
        [HttpGet]
        public IActionResult Index()
        {
          
            var not = new Notas();
            not.id = 1;
            not.Titulo = "Nota1 Test";
            not.Contenido = "esta nota es la primera";
            notas.Add(not);
            ViewBag.Notas = notas;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Notas = new Notas();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Notas nota)
        {
            addNotas(nota);
            return View();
             
        }


        public List<Notas> addNotas(Notas nota) {
             
            notas.Add(nota);

            return notas;
            
        }
    }
}
