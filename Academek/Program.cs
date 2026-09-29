using Academek;
using System;

class Program
{
    static List<Professor> ListaProfessor = new List<Professor>();
    static List<Aluno> ListaDeAlunos = new List<Aluno>();

    static void Main(string[] args)
    {

        bool rodando = true;

        while (rodando)
        {
            Console.Clear(); // O gary do codigo a cada repetição do while

            Console.WriteLine("Bem vindo!"); // pensar em uma mensagem melhor
            Console.WriteLine(@"
            ░█████╗░░█████╗░░█████╗░██████╗░███████╗███╗░░░███╗███████╗██╗░░██╗
            ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝████╗░████║██╔════╝██║░██╔╝
            ███████║██║░░╚═╝███████║██║░░██║█████╗░░██╔████╔██║█████╗░░█████═╝░
            ██╔══██║██║░░██╗██╔══██║██║░░██║██╔══╝░░██║╚██╔╝██║██╔══╝░░██╔═██╗░
            ██║░░██║╚█████╔╝██║░░██║██████╔╝███████╗██║░╚═╝░██║███████╗██║░╚██╗
            ╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");

            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Cadastrar Professor");
            Console.WriteLine("3. Listar dos Professores"); //talvez colocar duas listas, uma para aluno com disciplinas e medias e outra para o professor com as turmas e disciplinas
            Console.WriteLine("4. Exibir Alguma coisa");
            Console.WriteLine("5. Sair");
            Console.WriteLine("=======================================");
            Console.Write("Escolha uma opção (1 a 5): ");


            string opcao = Console.ReadLine()!;


            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\n[Opção selecionada: Cadastrar Aluno]");
                    CadastroAluno();
                    break;

                case "2":
                    Console.WriteLine("\n[Opção selecionada: Cadastrar Professor]");
                    CadastroProfessor();
                    break;

                case "3":
                    Console.WriteLine("\n[Opção selecionada: Listar Todos os Professores]");
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

    static void CadastroProfessor()
    {
        Professor novoProfessor = new Professor();

        Console.Write("Digite seu nome completo: ");
        novoProfessor.Nome = Console.ReadLine()!;

        Console.Write("Digite seu CPF: ");
        novoProfessor.CPF = Console.ReadLine()!;

        Console.Write("Digite sua data de nascimento: ");
        novoProfessor.DataDeNascimento = Console.ReadLine()!;

        //novoProfessor.Turmas.Add("Matematica 1A",);

        ListaProfessor.Add(novoProfessor);

        Console.Write("/nProfessor cadastrado com sucesso!");
    }

    static void CadastroAluno()
    {
        Aluno novoAluno = new Aluno();

        Console.Write("Digite seu nome completo: ");
        novoAluno.Nome = Console.ReadLine()!;

        Console.Write("Digite seu CPF: ");
        novoAluno.CPF = Console.ReadLine()!;

        Console.Write("Digite sua data de nascimento: ");
        novoAluno.DataDeNascimento = Console.ReadLine()!;

        Console.WriteLine("Digite o numero para sua matricula");
        novoAluno.Matricula = Double.Parse(Console.ReadLine()!);


    }
}