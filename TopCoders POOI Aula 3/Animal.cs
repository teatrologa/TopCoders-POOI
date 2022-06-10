using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LetsCodePOOIAula3.Enums;

namespace LetsCodePOOIAula3.Classes
{
    public class Animal
    {
        private Guid codigo = Guid.NewGuid();
        public string nome;
        public Especie especie;
        public string raca;
        public string cor;
        public Porte porte;
        public decimal peso;
        public DateTime nascimento;
        private List<string> doencasAlergias = new List<string>();
        public bool agressivo;
        public char sexo;
        public bool castrado;
        private DateTime dataCadastrado = DateTime.Now;

        public Guid ObterCodigo()
        {
            return codigo;
        }

        public void SetarCodigo(Guid codigo)
        {
            this.codigo = codigo;
        }

        public DateTime ObterDataCadastro()
        {
            return dataCadastrado;
        }

        public List<string> ObterNecessidadesEespeciais()
        {
            return doencasAlergias;
        }

        public bool NecessidadesEspeciais()
        {
            return doencasAlergias.Any();
        }

        public int Idade()
        {
            return DateTime.Now.Year - nascimento.Year;
        }

        public void RegistrarNascimento(int ano, int mes, int dia = 1)
        {
            nascimento = new DateTime(ano, mes, dia);
        }
        public void AdicionarDoencasAlergias(string doencaAlergia)
        {
            doencasAlergias.Add(doencaAlergia);
        }

        public void ImprimirAnimal()
        {
            Console.WriteLine("Imprimindo Pet");
            Console.WriteLine(codigo);
            Console.WriteLine(nome);
            Console.WriteLine(especie);
            Console.WriteLine(raca);
            Console.WriteLine(cor);
            Console.WriteLine(porte);
            Console.WriteLine(peso);
            Console.WriteLine(nascimento);
            Console.WriteLine(NecessidadesEspeciais());

            if (NecessidadesEspeciais())
            {
                Console.WriteLine("Doenças e Alergias:");
                foreach (string doencaalergia in doencasAlergias)
                {
                    Console.WriteLine(doencaalergia);
                }
            }
            Console.WriteLine(agressivo);
            Console.WriteLine(sexo);
            Console.WriteLine(castrado);
            Console.WriteLine(dataCadastrado);
            Console.WriteLine("");
        }

    }
}
