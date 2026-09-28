using System;

class Program
{
    static void Main(string[] args)
    {
        bool rodando = true;

        while (rodando)
        {
            Console.Clear(); // O gary do codigo a cada repetição do while

            Console.WriteLine("=======================================");
            Console.WriteLine("=              Academek               =");
            Console.WriteLine("=======================================");
            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Cadastrar Professor");
            Console.WriteLine("3. Listar Todas as Pessoas");
            Console.WriteLine("4. Exibir Alguma coisa");
            Console.WriteLine("5. Sair");
            Console.WriteLine("=======================================");
            Console.Write("Escolha uma opção (1 a 5): ");

            
            string opcao = Console.ReadLine()!;

            
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\n[Opção selecionada: Cadastrar Aluno]");
                    Pausar();
                    break;

                case "2":
                    Console.WriteLine("\n[Opção selecionada: Cadastrar Professor]");
                    Pausar();
                    break;

                case "3":
                    Console.WriteLine("\n[Opção selecionada: Listar Todas as Pessoas]");
                    Pausar();
                    break;

                case "4":
                    Console.WriteLine("\n[Opção selecionada: Exibir Estatísticas]");
                    Pausar();
                    break;

                case "5":
                    Console.WriteLine("\nSaindo do sistema... Até logo!...");
                    rodando = false; // Muda para false para parar de rodar o codigo
                    break;

                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    Pausar();
                    break;
            }
        }
    }

    // vai PAUSAR  a tela para o usuario escrever e aperta enter
    static void Pausar()
    {
        Console.WriteLine("\nAperte ENTER para voltar ao menu, meu nobre.");
        Console.ReadLine();
    }
}