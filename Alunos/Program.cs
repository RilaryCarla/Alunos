using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int contA = 0;
            int contD = 0;
            int contE = 0;
            int contM = 0;

            Console.WriteLine("Deseja começar o programa[S-Sim, N-Não]");
            string resp = Console.ReadLine();

            while (resp == "S")
            {
                Console.WriteLine("Deseja cadastrar qual curso[A-Administraação, M-Mecatronica, D-Desenvolvimento, E-Edificações]");
                string curso = Console.ReadLine();

                switch (curso)
                {
                    case "A":
                        Console.WriteLine("Deseja cadastrar o aluno em Adiminstração[S-Sim, N-Não]?");
                        string Rcurso = Console.ReadLine();
                        if (Rcurso == "S" && contA <= 5)
                        {
                            Console.WriteLine("O aluno foi cadastrado.");
                            contA++;
                            cont++;
                        }
                        else
                        {
                            Console.Write("Não há mais vagas disponiveis para Administração.");
                        }

                        break;

                    case "M":
                        Console.WriteLine("Deseja cadastrar um aluno em Mecatrônica[S-Sim, N-Não]?");
                        Rcurso = Console.ReadLine();
                        if (Rcurso == "S" && contM <= 5)
                        {
                            Console.WriteLine("Aluno cadastrado.");
                            contM++;
                            cont++;
                        }
                        else
                        {
                            Console.Write("Não há mais vagas disponiveis para Mecatrônica.");
                        }

                        break;

                    case "E":
                        Console.WriteLine("Deseja cadastrar um aluno em Edificações[S-Sim, N-Não]?");
                        Rcurso = Console.ReadLine();
                        if (Rcurso == "S" && contE <= 5)
                        {
                            Console.WriteLine("Aluno cadastrado.");
                            cont++;
                            contE++;
                        }
                        else
                        {
                            Console.Write("Não há mais vagas disponiveis para Edificações.");
                        }

                        break;

                    case "D":
                        Console.WriteLine("Deseja cadastrar um aluno em Desenvolvimento[S-Sim, N-Não]");
                        Rcurso = Console.ReadLine();
                        if (Rcurso == "s" && contD <= 5)
                        {
                            Console.WriteLine("Aluno cadastrado.");
                            cont++;
                            contD++;
                        }
                        else
                        {
                            Console.Write("Não há mais vagas disponiveis para Desenvolvimento.");
                        }

                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
                Console.Write("Deseja continuar[S-Sim, N-Não]");
                resp = Console.ReadLine();
            }
            Console.WriteLine("Foram cadastrados" + cont + "alunos");
            Console.ReadKey();
            Console.WriteLine("Foram cadastrados" + contD + "Em Desenvolvimento");
            Console.ReadKey();
            Console.WriteLine("Foram cadastrados" + contA + "Em Administração");
            Console.ReadKey();
            Console.WriteLine("Foram cadastrados" + contM + "Em Mecatrônica");
            Console.ReadKey();
            Console.WriteLine("Foram cadastrados" + contE + "Em Edificações");
            Console.ReadKey();
        }
    }
}   
