using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneErroriPersonalizzata
{
    internal class RepositoryUtenteMock
    {
        internal static List<Utente> Utenti = new List<Utente>()
        {
            new Utente(1, "Gaia", "Bertaglia"),
            new Utente(2, "Mario", "Rossi"),
        };
        public Utente GetById(int idUtente)
        {
            Utente trovato = new Utente();
            try
            {
                foreach (var item in Utenti)
                {
                    if (item.IdUtente == idUtente)
                    {
                        trovato = item;
                        return item;
                    }
                }
                throw new UtenteException("Non esiste un utente che corrisponda all'Id inserito");
            }
            catch (UtenteException exc)
            {
                Console.WriteLine(exc.Message);

            }
            return null;

        }
    }
}
