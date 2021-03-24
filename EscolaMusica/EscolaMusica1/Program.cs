using System;
using System.Linq;
using System.Collections.Generic;

namespace EscolaMusica
{
    class Program
    {
        static List<Aluno> listAlunos = new List<Aluno>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarAlunosMatriculados();
                        
                        break;
                    case "2":
                        InserirAluno();
                        break;
                    case "3":
                        RemoverAluno();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
           
            Console.WriteLine("Obrigado por querer aprender música!");
            Console.ReadLine();
        }

        private static void RemoverAluno()
        {
            Console.WriteLine("Informe o nome do aluno que não continuará na escola: ");
            string saidaNome = Console.ReadLine();
           
            Aluno pessoaDeletar = listAlunos.Where(a => a.Nome == saidaNome).FirstOrDefault();
            listAlunos.Remove(pessoaDeletar);
                                
        }

        private static void ListarAlunosMatriculados()
        {
            Console.WriteLine("Listar Alunos Matriculados");

            if (listAlunos.Count == 0)
            {
                Console.WriteLine("Que pena! Nossa escola não tem nenhum Aluno cadastrado!");
                return;
            }

            foreach(var a in listAlunos)
            {
                if (!string.IsNullOrEmpty(a.Nome))
                {
                    Console.WriteLine($"ALUNO: {a.Nome} - INSTRUMENTO: {a.Instrumentos} - NIVEL: {a.conhecimento}");
                }

            }
        }

        private static void InserirAluno()
        {
            Console.WriteLine();
            
            Console.Write("Digite o nome do Aluno: ");
            string entradaNome = Console.ReadLine();
            
            Console.WriteLine("Qual instrumento ele irá aprender");
            Console.WriteLine();
            Console.WriteLine("1 - Violao");
            Console.WriteLine("2 - Guitarra");
            Console.WriteLine("3 - Teclado");
            Console.WriteLine("4 - Acordeon");
            Console.WriteLine("5 - Flauta");
            Console.WriteLine("6 - Bateria");
            Console.WriteLine("7 - Baixo");
            Console.WriteLine("8 - Canto");
            Console.WriteLine("9 - Oboe");
            Console.WriteLine("10 - Cavaquinho");
            int entradaInstrumentos = int.Parse(Console.ReadLine());

            Console.Write("Informe o nível de conhecimento do Aluno: ");
            Console.WriteLine();
            Console.WriteLine("A - Avançado");
            Console.WriteLine("B - Intermediário");
            Console.WriteLine("C - Básico");
            Console.WriteLine("D - Não sabe nada");
            string entradaConhecimento = Console.ReadLine();

            Aluno novoAluno = new Aluno(instrumento: (Instrumentos)entradaInstrumentos,
                                        nome: entradaNome,
                                        conhecimento: entradaConhecimento);
            
            listAlunos.Add(novoAluno);

        }  
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Escola de Música SemI-Tom!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar alunos matriculados");
            Console.WriteLine("2 - Inserir novo aluno");
            Console.WriteLine("3 - Remover aluno");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}