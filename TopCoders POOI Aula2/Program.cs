using TopCoders_POOI_Aula2.Enums;
using TopCoders_POOI_Aula2.Classes;

namespace TopCoders_POOI_Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.nome = "Ratita";
            animal.raca = "Yorkshire";
            animal.cor = "Padrão da raça";
            animal.peso = 2.5m;
            animal.nascimento = new DateTime(2016, 08, 23);
            animal.agressividade = false;
            animal.sexo = 'F';
            animal.castracao = true;
            Guid codigoAnimal = animal.ObterCodigo();
            animal.especie = Especie.Cachorro;
            animal.porte = Porte.Pequeno;

            animal.ImprimirAnimal();
        }
    }

}