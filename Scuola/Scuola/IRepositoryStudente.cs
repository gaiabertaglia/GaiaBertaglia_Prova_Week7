using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    internal interface IRepositoryStudente : IRepository<Studente>
    {
        Studente GetByNomeCognome(string nome, string cognome);
    }
}
