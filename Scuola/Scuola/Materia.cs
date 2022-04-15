using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    internal class Materia
    {
        public int IdMateria { get; set; }
        public string NomeMateria { get; set; }
        public Materia()
        {

        }
        public Materia(int idMateria, string nomeMateria)
        {
            IdMateria = idMateria;
            NomeMateria = nomeMateria;
        }
        public override string ToString()
        {
            return $"Id: {IdMateria} - Materia: {NomeMateria}";
        }
    }
}
