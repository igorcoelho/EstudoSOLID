using ProjetoAula06.Entities;
using ProjetoAula06.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06.Controllers
{
    public class AlunoController
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public void CadastrarAluno()
        {
            try
            {
                Console.WriteLine("\nCadastro de Aluno: ");
                var aluno = new Aluno();
                aluno.Id = Guid.NewGuid();

                Console.WriteLine("Nome do Aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Matricula do Aluno: ");
                aluno.Matricula = Console.ReadLine();

                Console.WriteLine("Data de Nascimento do Aluno: ");
                aluno.DataNascimento = DateTime.Parse(Console.ReadLine());

                //gravando os dados do aluno
                _alunoRepository.Exportar(aluno);
                Console.WriteLine("\n Aluno Cadastrado com Sucesso!");

            }
            catch(ArgumentException e)
            {
                Console.WriteLine("\n Erro de Validação: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
