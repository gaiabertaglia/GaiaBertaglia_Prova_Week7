using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GestioneErroriPersonalizzata
{
    internal class UtenteException : Exception
    {
        public UtenteException()
        {

        }
        public UtenteException(string messaggio): base(messaggio)
        {

        }
        protected UtenteException(SerializationInfo info, StreamingContext context): base(info, context)
        {

        }
    }
}
