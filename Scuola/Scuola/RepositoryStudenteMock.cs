using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    internal class RepositoryStudenteMock : IRepositoryStudente
    {
        static private List<Studente> Studenti = new List<Studente>()
        {
            new Studente("Gaia", "Bertaglia", new DateTime(1997, 02,17),1),
            new Studente("Sandro", "Vecchi", new DateTime(2001, 05,5),2)
        };

        public bool Aggiungi(Studente item)
        {
            if (item == null)
            {
                return false;
            }
            else
            {
                Studenti.Add(item);
                return true;
            }
        }       

        public IList<Studente> GetAll()
        {
            return Studenti;
        }

        public Studente GetById(int id)
        {
            foreach (var item in Studenti)
            {
                if (item.IdStudente == id)
                {
                    return item;
                }
            }
            return null;
        }

        public Studente GetByNomeCognome(string nome, string cognome)
        {
            throw new NotImplementedException();
        }
    }
}
