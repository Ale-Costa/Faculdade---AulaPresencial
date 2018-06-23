using Controllers;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {

            //-------- Cadastrar Aluno ----------


            AlunosController alunosController = new AlunosController();


            Aluno a = CadastrarAluno();
            alunosController.Inserir(a);

            Aluno b = CadastrarAluno();
            alunosController.Inserir(b);

            Aluno c = CadastrarAluno();
            alunosController.Inserir(c);


          

            //---------- Cadastrar Prof --------------


            ProfessoresController profController = new ProfessoresController();


            Professor p = CadastrarProf();
            profController.Inserir(p);

            Professor m = CadastrarProf();
            profController.Inserir(m);

            Professor n = CadastrarProf();
            profController.Inserir(n);


         



            //------------ Cadastrar Disciplina ---------------

            DisciplinasController disciplinaController = new DisciplinasController();

            Disciplina d = CadastrarDisciplina();
            disciplinaController.Inserir(d);

            Disciplina e = CadastrarDisciplina();
            disciplinaController.Inserir(e);

            Disciplina f = CadastrarDisciplina();
            disciplinaController.Inserir(f);


            Console.WriteLine("------------- DADOS ALUNO --------------");
            foreach (Aluno aluno in alunosController.ListarTodos())
            {
                ImprimirDadosAluno(aluno);

            }


            Console.WriteLine("------------- DADOS PROFESSOR --------------");
            foreach (Professor professor in profController.ListarTodos())
            {
                ImprimirDadosProf(professor);

            }



            Console.WriteLine("------------- DADOS DISCIPLINA --------------");
            foreach (Disciplina disciplina in disciplinaController.ListarTodos())
            {
                ImprimirDadosDisciplina(disciplina);
            }



            Console.ReadKey();

        }

        //------------------------------------------------------ CADASTRO ALUNO -------------------------------------

        private static void ImprimirDadosAluno(Aluno a)
        {
            
            Console.WriteLine("");
            Console.WriteLine("Aluno: " + a.Nome);
            Console.WriteLine("Matricula: " + a.Matricula);
        }

        private static Aluno CadastrarAluno()
        {
            Aluno a = new Aluno();

            Console.WriteLine("------------- CADASTRO ALUNO --------------");
            Console.WriteLine("");
            Console.Write("Digite o nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.Write("Digite o numero da matricula: ");
            a.Matricula = int.Parse(Console.ReadLine());
            return a;
        }


        //---------------------------------------------------- CADASTRO PROF ---------------------------------------

        private static void ImprimirDadosProf(Professor p)
        {
            
            Console.WriteLine("");
            Console.WriteLine("Professor: " + p.Nome);
            Console.WriteLine("Matricula: " + p.Matricula);
        }

        private static Professor CadastrarProf()
        {
            Professor p = new Professor();

            Console.WriteLine("------------- CADASTRO PROFESSOR --------------");
            Console.WriteLine("");
            Console.Write("Digite o nome do Professor: ");
            p.Nome = Console.ReadLine();

            Console.Write("Digite o numero da matricula do professor: ");
            p.Matricula = int.Parse(Console.ReadLine());
            return p;
        }



        //------------------------------------------------------ CADASTRO DISCIPLINA -------------------------------------

        private static void ImprimirDadosDisciplina(Disciplina d)
        {
            
            Console.WriteLine("");
            Console.WriteLine("Disciplina: " + d.Nome);
            Console.WriteLine("ID Disciplina: " + d.Id);
        }

        private static Disciplina CadastrarDisciplina()
        {
            Disciplina d = new Disciplina();

            Console.WriteLine("------------- CADASTRO DISCIPLINA --------------");
            Console.WriteLine("");
            Console.Write("Digite a disciplina: ");
            d.Nome = Console.ReadLine();

            Console.Write("Digite o ID da disciplina: ");
            d.Id = int.Parse(Console.ReadLine());
            return d;
        }




    }

}
