using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT3.Models
{
    public class _notasrepositorio
    {
        public List<Notas> notas { get; set; }
        public _notasrepositorio() {
            notas = new List<Notas>();
        }
        public void addNotas(Notas dat) {
            notas.Add(dat);
        }
        public List<Notas> returnNotas()
        {
            return notas;
        }
    }

}
