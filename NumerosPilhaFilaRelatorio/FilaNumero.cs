using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPilhaFilaRelatorio
{
    internal class FilaNumero
    {
        Numero Head;
        Numero Tail;
        public FilaNumero()
        {
            Head = null;
            Tail = null;
        }
        bool IsEmpty()
        {
            return Head == null && Tail == null;
        }
        string MessageEmpty()
        {
            return "Fila Vazia!";
        }
        public void Push(Numero aux)
        {
            if (IsEmpty())
                Head = Tail = aux;
            else
            {
                Tail.SetNext(aux);
                Tail = aux;
            }
        }
        public void Print()
        {
            if (IsEmpty())
                MessageEmpty();
            else
            {
                Numero aux = Head;
                do
                {
                    Console.Write($"{aux.ToString()}, ");
                    aux = aux.GetNext();
                } while (aux != Tail.GetNext());
            }
        }
        public void RunOver()
        {
            if (IsEmpty())
                MessageEmpty();
            else
            {
                Numero aux = Head;
                do
                {
                    aux = aux.GetNext();
                } while (aux != Tail.GetNext());
            }
        }
        public Numero GetHead()
        {
            return Head;
        }
    }
}
