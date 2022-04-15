using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneErroriPersonalizzata
{
    internal class Utente
    {       

        public int IdUtente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
              

        public Utente()
        {

        }
        public Utente(int idUtente, string nome, string cognome)
        {
            IdUtente = idUtente;
            Nome = nome;
            Cognome = cognome;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} - Cognome: {Cognome}";
        }
    }
}
