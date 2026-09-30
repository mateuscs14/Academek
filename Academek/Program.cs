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

        ListaDeAlunos.Add(novoAluno);
    }

    static void ListaAlunos()
    {
        Console.Clear();

        Console.WriteLine(@"========== 𝐿𝑖𝑠𝑡𝑎 𝑑𝑒 𝐴𝑙𝑢𝑛𝑜𝑠 ==========");

        if (ListaDeAlunos.Count == 0)
        {
            Console.WriteLine("Nenhum Aluno Cadastrado");
        }else
        {
            foreach (var Aluno in ListaDeAlunos)
            {
                Console.WriteLine($"Nome: {Aluno.Nome}, CPF: {Aluno.CPF}, Data De Nascimento: {Aluno.DataDeNascimento}, Notas: {Aluno.Medias}, Matricula: {Aluno.Matricula}");
                
            }
        }
    }

    static void ListaDeProfessor()
    {
        Console.Clear();

        if (ListaProfessor.Count == 0)
        {
            Console.WriteLine("Nenhum Professor Cadastrado");
        }
        else
        {
            foreach (var Professor in ListaProfessor)
            {
                Console.WriteLine($"Nome: {Professor.Nome}, CPF: {Professor.CPF}, Data de Nascimento: {Professor.DataDeNascimento}, Salario: {Professor.Salario}, Turmas: {Professor.Turmas} ");
            }
        }
    }

}