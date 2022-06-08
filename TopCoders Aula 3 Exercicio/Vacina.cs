using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopCoders_POOI_Aula3_Exercicio.Enums;

namespace TopCoders_Aula_3_Exercicio.Classes
{
    public class TipoVacina
    {
        public Guid IDuniVacina { get; } = Guid.NewGuid();
        public string nome = "";
        public string lote = "";
        public DateTime dataAplicacao;
        public int duracaoVacina;
        public TipoVacina tipoVacina;
        
        
        public List<Especie> especie;

        public Guid ObterIdUnicoVacina()
        {
            return IDuniVacina;
        }
        
            
        

    }
}

/*
Pet - ID
Cart.Vac - ID

tipo de vacina: covid
nome de vacina: coronavac, astrazenica, etc. - ID unico 


*/
