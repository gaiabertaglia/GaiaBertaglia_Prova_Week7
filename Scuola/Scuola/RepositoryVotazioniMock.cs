using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    internal class RepositoryVotazioniMock : IRepositoryVotazioni
    {
        static private List<Votazione> Votazioni = new List<Votazione>()
        {
            new Votazione(1, 3, 7, new DateTime(2022-04-15)),
            new Votazione(2, 6, 6, new DateTime(2022-02-20))
        };
        public bool Aggiungi(Votazione item)
        {
            if (item == null)
            {
                return false;
            }
            else
            {
                Votazioni.Add(item);
                return true;
            }
        }

        public IList<Votazione> GetAll()
        {
            return Votazioni;
        }

        public Votazione GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
