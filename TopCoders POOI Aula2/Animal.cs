using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopCoders_POOI_Aula2.Enums;

namespace TopCoders_POOI_Aula2.Classes
{
    public class Animal
    {
        public Guid codigo { get; } = Guid.NewGuid();
        public string nome = "";
        public string raca = "";
        public string cor = "";
        public decimal peso;
        public int idade;
        public DateTime nascimento;
        public bool agressividade;
        public char sexo;
        public bool castracao;
        public DateTime dataCadastro { get; } = DateTime.Now;
        public List<string> doencasAlergias { get; set; } = new List<string>();

        public Especie especie;
        public Porte porte;

        // COMENTADO POIS JÁ ESTÁ COM O GET ALI EM CIMA
        //public Guid ObterCodigo()
        //{
        //    return codigo;
        //}

        public DateTime ObterDataCadastro()
        {
            return dataCadastro;
        }

        public void RegistrarNascimento(int ano, int mes, int dia = 1)
        {
            nascimento = new DateTime(ano, mes, dia);
        }

        public int Idade()
        {
            idade = (DateTime.Now.Year - nascimento.Year);
            return idade;
        }

        public bool NecessidadesEspeciais()
        {
            return doencasAlergias.Any();
        }

        public List<string> ObterNecessidadesEspecieais()
        {
            return doencasAlergias;
        }

        public void AdicionarDoencasAlergias(string doencasAlergias)
        {
            this.doencasAlergias.Add(doencasAlergias);
        }
        


        public void ImprimirAnimal()
        {
            Console.WriteLine("\t Ficha do pet.");
            Console.WriteLine("\t _____________");
            Console.WriteLine(" ");
            Console.WriteLine($"Codigo: {codigo}"); // Forma 1 de escrever
            Console.Write("Nome: ");  // Forma 2 de escrever Write + WriteLine
            Console.WriteLine(nome);
            Console.WriteLine($"Idade: {Idade()} anos");
            Console.WriteLine($"Espécie: {especie}");
            Console.WriteLine($"Raça: {raca}");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Porte: { porte}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine($"Nascimento: {nascimento}");
            Console.WriteLine($"É agressivo? {agressividade}");
            Console.WriteLine($"Realizou castração? {castracao}");
            Console.WriteLine(" ");


            if (NecessidadesEspeciais())
            {
                Console.WriteLine("Doenças e Alergias:");
                    foreach (string doencaalergia in doencasAlergias)
                {
                    Console.WriteLine(doencaalergia);
                }
            }

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Pet cadastrado em: {dataCadastro}");
            Console.WriteLine(" ");
   
        }
    }
}
