using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    internal class Studente : Persona
    {
        public int IdStudente { get; set; }

        public Studente()
        {

        }
        public Studente(string nome, string cognome, DateTime dataNascita, int idStudente):base(nome, cognome, dataNascita)
        {
            IdStudente = idStudente;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Id Studente: {IdStudente}";
        }
    }
}
