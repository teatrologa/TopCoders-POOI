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
            animal.RegistrarNascimento(2016, 08);
            animal.agressividade = false;
            animal.sexo = 'F';
            animal.castracao = true;
            Guid codigoAnimal = animal.codigo;
            animal.especie = Especie.Cachorro;
            animal.porte = Porte.Pequeno;
            animal.AdicionarDoencasAlergias("Alergia: Nozes");
            animal.AdicionarDoencasAlergias("Alergia: Cheiro forte");

            animal.ImprimirAnimal();
        }
    }

}