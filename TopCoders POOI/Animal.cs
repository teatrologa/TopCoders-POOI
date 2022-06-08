using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoders_POOI_Aula1
{
    public class Animal
    {
        //get e eventuais sets foram colocados por mim na intuição
        //private Guid codigo = Guid.NewGuide();
        public Guid codigo { get; } = Guid.NewGuid();
        public string nome = "";
        public string raca = "";
        public string cor = "";
        public decimal peso;
        public DateTime nascimento;
        public bool agressividade;
        public char sexo;
        public bool castracao;
        public DateTime dataCadastro { get; } = DateTime.Now;
        public List<string> alergias { get; } = new List<string>();

        public Especie especie;
        public Porte porte;

        public Guid ObterCodigo()
        {
            return codigo;
        }

        public DateTime ObterDataCadastro()
        {
            return dataCadastro;
        }
    }
}
