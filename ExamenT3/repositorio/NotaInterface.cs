using ExamenT3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT3.repositorio
{
    public interface NotaInterface
    {
        List<Notas> getListaDeNotas();

        void guardarNota(string a, string b);

        Notas editar(int id);
        void editarN(string a, string b ,int id);
         
        void eliminar(int id);
    }
}
