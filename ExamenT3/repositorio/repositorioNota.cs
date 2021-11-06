using ExamenT3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT3.repositorio
{
    public class repositorioNota : NotaInterface
    {
        readonly appContext context;
        List<Notas> list = new List<Notas>();

        public repositorioNota(appContext context)
        {
            this.context = context;
        }

        public Notas editar(int id)
        {
            var nota = context.Notas.FirstOrDefault(a => a.ID == id);

            return nota;
        }

        public void editarN(string a, string b, int id)
        {
            var nota = context.Notas.FirstOrDefault(a => a.ID == id);

            nota.Titulo = a;
            nota.Contenido = b;
            context.SaveChanges();

        }

        public void eliminar(int id)
        {
            var nota = context.Notas.FirstOrDefault(a => a.ID == id);
            context.Notas.Remove(nota);
            context.SaveChanges();
        }

        public List<Notas> getListaDeNotas()
        {
            // var lista = context.Notas.ToList();

            var nota1 = new Notas()
            {
                ID = 1,
                Contenido = "Contenido de Prueba 1",
                Titulo = "Prueba 1"
            };

            var nota2 = new Notas()
            {

                ID = 1,
                Contenido = "Contenido de Prueba 2",
                Titulo = "Prueba 2"
            };

            list.Add(nota1);
            list.Add(nota2);
            return list;
        }

        public void guardarNota(string a, string b)
        {
            var nota = new Notas();
            nota.Titulo = a;
            nota.Contenido = b;

            list.Add(nota);
          //  context.Notas.Add(nota);
           // context.SaveChanges();
        }

        public List<Notas> dbSta()
        {
            

            var nota1 = new Notas()
            {
                ID = 1,
                Contenido = "Contenido de Prueba 1",
                Titulo = "Prueba 1"
            };

            var nota2 = new Notas()
            {
              
                ID = 1,
                Contenido = "Contenido de Prueba 2",
                Titulo = "Prueba 2"
            };

            list.Add(nota1);
            list.Add(nota2);

            return list;

        }
    }
}
