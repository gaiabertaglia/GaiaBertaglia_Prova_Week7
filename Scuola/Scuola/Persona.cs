using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    internal abstract class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public Persona()
        {

        }
        public Persona(string nome, string cognome, DateTime dataNascita)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} - Cognome: {Cognome}";
        }
    }
}
