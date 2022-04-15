using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    internal interface IRepository<T>
    {
        IList<T> GetAll();
        T GetById(int id);
        bool Aggiungi(T item);
        
    }
}
