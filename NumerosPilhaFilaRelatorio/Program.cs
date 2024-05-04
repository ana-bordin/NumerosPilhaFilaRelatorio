namespace NumerosPilhaFilaRelatorio
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("Digite a opção desejada:\n" +
                              "1. Povoar as pilhas;\n" +
                              "2. Verificar se há números iguais nas duas pilhas;\n" +
                              "3. Mostrar Pilhas;\n" +
                              "0. Sair\n");
        }
        static void EscolhaMenu(int op, FilaNumero fila, PilhaNumero pilha)
        {
            switch (op)
            {
                case 1:
                    Povoar(fila, pilha);
                    break;
                case 2:
                    CompararPilhas(fila, pilha);
                    break;
                case 3:
                    Console.WriteLine("Fila:");
                    fila.Print();
                    Console.WriteLine("\nPilha:");
                    pilha.Print();
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida!");
                    break;
            }
        }
        static void Povoar(FilaNumero fila, PilhaNumero pilha)
        {
            for (int i = 0; i < 10; i++)
                pilha.Push(new Numero(new Random().Next(1, 100)));
            for (int i = 0; i < 10; i++)
                fila.Push(new Numero(new Random().Next(1, 100)));
        }
        static void CompararPilhas(FilaNumero fila, PilhaNumero pilha)
        {
            
            Numero auxPilhaCabeca = pilha.GetHead();

            while (auxPilhaCabeca != null)
            {
                Numero auxFilaCabeca = fila.GetHead();
                while (auxFilaCabeca != null)
                {
                    if (auxFilaCabeca.GetNumber() == auxPilhaCabeca.GetNumber())
                        Console.WriteLine($"O {auxFilaCabeca.ToString()} aparece na pilha e na fila!");
                    auxFilaCabeca = auxFilaCabeca.GetNext();
                }
                auxPilhaCabeca = auxPilhaCabeca.GetPrevious();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(">>>Comparação de Pilhas<<<");
            PilhaNumero pilha = new PilhaNumero();
            FilaNumero fila = new FilaNumero();
            do
            {

                Menu();
                EscolhaMenu(int.Parse(Console.ReadLine()), fila, pilha);
                Console.WriteLine();
            } while (true);
        }
    }
}