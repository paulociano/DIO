using System.Globalization;
using Projeto_Exemplo.Models;


try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo-Leitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (Exception ex) 
{
    Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");

}










/*Pessoa p1 = new Pessoa("Paulo", "Graciano", 32);
Pessoa p2 = new Pessoa("Tulio", "Graciano", 25);

Curso ingles = new Curso();
ingles.Nome = "Inglês";
ingles.Alunos = new List<Pessoa>();

ingles.AdicionarAluno(p1);
ingles.AdicionarAluno(p2);
ingles.ListarAlunos();*/