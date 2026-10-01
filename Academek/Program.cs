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
            Console.WriteLine("3. Listar dos Alunos"); //talvez colocar duas listas, uma para aluno com disciplinas e medias e outra para o professor com as turmas e disciplinas
            Console.WriteLine("4. Lista dos Professores");
            Console.WriteLine("5. Sair");
            Console.WriteLine("=======================================");
            Console.Write("Escolha uma opção (1 a 5): ");


            string opcao = Console.ReadLine()!;


            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\n[Opção selecionada: Cadastrar Aluno]");
                    CadastroAluno();
                    Pausar();
                    break;

                case "2":
                    Console.WriteLine("\n[Opção selecionada: Cadastrar Professor]");
                    CadastroProfessor();
                    break;

                case "3":
                    Console.WriteLine("\n[Opção selecionada: Listar Todos os Alunos]");
                    ListaAlunos();
                    Pausar();
                    break;

                case "4":
                    Console.WriteLine("\n[Opção selecionada: Lista de Todos os Professores]");
                    ListaDeProfessor();
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

    static void CadastroAluno()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("--- CADASTRO DE ALUNO ---");

            Console.Write("Digite o nome completo: ");
            string nome = Console.ReadLine()!;

            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine()!;

            Console.Write("Digite a data de nascimento: ");
            string dataNasc = Console.ReadLine()!;

            Console.Write("Digite o número da matrícula: ");
            if (!double.TryParse(Console.ReadLine(), out double matricula))
            {
                throw new FormatException("A matrícula deve ser um número válido!");
            }

            Aluno novoAluno = new Aluno(nome, cpf, dataNasc, matricula);

            Console.Write("Digite uma nota inicial (0 a 10): ");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                novoAluno.AdicionarNota(nota);
            }

            ListaDeAlunos.Add(novoAluno);
            Console.WriteLine("\nAluno cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n[ERRO NO CADASTRO]: {ex.Message}");
        }
    }

    static void CadastroProfessor()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("--- CADASTRO DE PROFESSOR ---");

            Console.Write("Digite o nome completo: ");
            string nome = Console.ReadLine()!;

            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine()!;

            Console.Write("Digite a data de nascimento: ");
            string dataNasc = Console.ReadLine()!;

            Console.Write("Digite o salário: R$ ");
            if (!double.TryParse(Console.ReadLine(), out double salario))
            {
                throw new FormatException("O salário informado é inválido!");
            }

            Professor novoProf = new Professor(nome, cpf, dataNasc, salario);

            Console.Write("Digite a turma do professor: ");
            string turma = Console.ReadLine()!;
            novoProf.AdicionarTurma(turma);

            ListaProfessor.Add(novoProf);
            Console.WriteLine("\nProfessor cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n[ERRO NO CADASTRO]: {ex.Message}");
        }
    }

    static void ListaAlunos()
    {
        Console.Clear();
        Console.WriteLine("__________ LISTA DE ALUNOS __________\n");

        if (ListaDeAlunos.Count == 0)
        {
            Console.WriteLine("Nenhum Aluno Cadastrado.");
            return;
        }

        foreach (var aluno in ListaDeAlunos)
        {
            aluno.ExibirInformacoes();
        }
    }

    static void ListaDeProfessor()
    {
        Console.Clear();
        Console.WriteLine("__________ LISTA DE PROFESSORES __________\n");

        if (ListaProfessor.Count == 0)
        {
            Console.WriteLine("Nenhum Professor Cadastrado.");
            return;
        }

        foreach (var prof in ListaProfessor)
        {
            prof.ExibirInformacoes();
        }
    }
}