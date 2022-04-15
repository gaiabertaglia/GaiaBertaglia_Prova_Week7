using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    internal class Insegnante : Persona
    {
        public int AnniServizio { get; set; }
        public Insegnante()
        {

        }
        public Insegnante(string nome, string cognome, DateTime dataNascita, int anniServizio): base(nome, cognome, dataNascita)
        {
            AnniServizio = anniServizio;
        }
        public override string ToString()
        {
            return base.ToString() + $"Anni di servizio: {AnniServizio}";
        }
    }
}
