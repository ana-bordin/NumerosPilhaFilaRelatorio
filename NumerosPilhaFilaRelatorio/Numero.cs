using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPilhaFilaRelatorio
{
    internal class Numero
    {
        int Number;
        Numero Next;
        Numero Previous;

        public Numero(int numero)
        {
            Number = numero;
            Next = null;
            Previous = null;
        }
        public void SetNext(Numero numeroProximo)
        {
            this.Next = numeroProximo;
        }
        public Numero GetNext()
        {
            return Next;
        }
        public void SetPrevious(Numero numeroAnterior)
        {
            this.Previous = numeroAnterior;
        }
        public Numero GetPrevious()
        {
            return Previous;
        }
        public override string ToString()
        {
            return $"{Number}";
        }
        public int GetNumber()
        {
            return Number;
        }
    }
}
