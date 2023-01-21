using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Exemplo.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunos() {
            int quantidade = Alunos.Count();
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno){
            Alunos.Remove(aluno);
        }
        
        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso {Nome}:");

            for(int i = 0; i < Alunos.Count; i++)
            {
                string texto = $"{i+1} - {Alunos[i].NomeCompleto}"; 
                Console.WriteLine(texto);
            }
        }
    }
}