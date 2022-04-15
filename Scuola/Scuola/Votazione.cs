using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    internal class Votazione
    {
        public int IdStudente { get; set; }
        public int IdMateria { get; set; }
        public double Voto { get; set; }
        public DateTime GiornoDellaProva { get; set; }
        public Votazione()
        {

        }
        public Votazione(int idStudente, int idMateria, double voto, DateTime giornoDellaProva)
        {
            IdStudente = idStudente;
            IdMateria = idMateria;
            Voto = voto;
            GiornoDellaProva = giornoDellaProva;
        }

        public override string ToString()
        {
            return $"Id Studente: {IdStudente} - Id Materia: {IdMateria} - Voto: {Voto}";
        }
    }
}
