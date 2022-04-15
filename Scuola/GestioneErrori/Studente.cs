using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneErrori
{
    internal class Studente
    {
        public int IdStudente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Studente()
        {

        }
        public Studente(int idStudente, string nome, string cognome)
        {
            IdStudente = idStudente;
            Nome = nome;
            Cognome = cognome;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} - Cognome: {Cognome}";
        }
    }
}
