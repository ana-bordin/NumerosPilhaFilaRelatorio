namespace NumerosPilhaFilaRelatorio
{
    internal class PilhaNumero
    {
        Numero Head;
        public PilhaNumero()
        {
            Head = null;
        }
        bool IsEmpty()
        {
            return Head == null;
        }
        string MessageEmpty()
        {
            return "Pilha Vazia!";
        }
        public void Push(Numero aux)
        {
            if (IsEmpty())
                Head = aux;
            else
            {
                aux.SetPrevious(Head);
                Head = aux;
            }
        }
        public void Print()
        {
            Numero aux = Head;
            if (IsEmpty())
                MessageEmpty();
            else
            {
                do
                {
                    Console.Write($"{aux.ToString()}, ");
                    aux = aux.GetPrevious();
                } while (aux != null);
            }
        }
        public void RunOver()
        {
            Numero aux = Head;
            if (IsEmpty())
                MessageEmpty();
            else
            {
                do
                {

                    aux = aux.GetPrevious();
                } while (aux != null);
            }
        }
        public Numero GetHead()
        {
            return Head;
        }

    }
}
