using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_de_Classes
{
    public class Endereco   // classe de endereço
    {
        public string logradouro, cidade, estado;   // tem 3 campos
        public Endereco(string logradouro, string cidade, string estado)    // quando instanciar, passar os argumentos para logradouro, cidade e estado
        {
            this.logradouro = logradouro;   // atribui o valor do argumento ao campo
            this.cidade = cidade;           // atribui o valor do argumento ao campo
            this.estado = estado;           // atribui o valor do argumento ao campo
        }
        /*public void ImprimirEndereco()  // metodo que salva os valores numa string depois os mostra formatados
        {
            string mostrador = $"Rua: {logradouro}, Cidade: {cidade}, Estado: {estado}";
            Console.WriteLine(mostrador);  
        }*/
    }
    public class Estudante
    {
        public string nome;
        public int id;
        static readonly int anoMatricula = DateTime.Now.Year;   //atribui o ano atual ao campo "anoMatricula" para todas as instancias
        static string curso = "Análise e Desenvolvimento de Sistemas"; //atribui o curso "Análise e Desenvolvimento de Sistemas" a todas as instancias 
        Endereco endereco; //o estudante vai ter um campo chamado "endereco" que é do tipo Endereço (a classe)
        public Estudante(int id, string nome, Endereco endereco)    //aqui se passa os argumentos, usando o nome do endereco instanciado como o endereco do estudante
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
        }
        public void Display() //função que mostra todas as informações formatadas
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Endereço: {endereco.logradouro}, {endereco.cidade}, {endereco.estado}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Ano de Matrícula: {anoMatricula}");

        }
    }
}
