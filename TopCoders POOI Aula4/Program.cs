using LetsCodePOOIAula4.Classes;
using LetsCodePOOIAula4.Enums;

namespace LetsCodePOOIAula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal pet = new Animal();
            Console.WriteLine(@"
             __       _______ .___________. __      _______.   .______    _______ .___________.
            |  |     |   ____||           |(_ )    /       |   |   _  \  |   ____||           |
            |  |     |  |__   `---|  |----` |/    |   (----`   |  |_)  | |  |__   `---|  |----`
            |  |     |   __|      |  |             \   \       |   ___/  |   __|      |  |     
            |  `----.|  |____     |  |         .----)   |      |  |      |  |____     |  |     
            |_______||_______|    |__|         |_______/       | _|      |_______|    |__|     
            Cadastre agora mesmo no melhor PET SHOP do bairro!!!
            Clique qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(@"
           ___             _               _               
          / __|  __ _   __| |  __ _   ___ | |_   _ _   ___ 
         | (__  / _` | / _` | / _` | (_-< |  _| | '_| / _ \
          \___| \__,_| \__,_| \__,_| /__/  \__| |_|   \___/");
            Console.WriteLine();
            Console.WriteLine("Qual o nome do seu pet?");
            pet.Nome = Console.ReadLine();

            Console.WriteLine(@"Qual a especie do seu pet? Digite 1 para cachorro ou 2 para gato");
            pet.Especie = Enum.Parse<Especie>(Console.ReadLine());
            var escolhaEspecie = pet.Especie.ToString();
            while (escolhaEspecie != "Cachorro" && escolhaEspecie != "Gato" || string.IsNullOrWhiteSpace(escolhaEspecie))
            {
                Console.WriteLine("Opção inválida, tente novamente: ");
                pet.Especie = (Especie)Convert.ToInt32(Console.ReadLine());
                escolhaEspecie = pet.Especie.ToString();
            }

            Console.WriteLine("Qual a raça do seu pet?");
            pet.Raca = Console.ReadLine();
            Console.WriteLine("Qual a cor do seu pet?");
            pet.Cor = Console.ReadLine();

            Console.WriteLine(@"Qual o porte do seu pet? Digite 1 para pequeno ou 2 para grande");
            pet.Porte = Enum.Parse<Porte>(Console.ReadLine());
            var escolhaPorte = pet.Porte.ToString();
            while (escolhaPorte != "Pequeno" && escolhaPorte != "Grande" || string.IsNullOrWhiteSpace(escolhaPorte))
            {
                Console.WriteLine("Opção inválida, tente novamente: ");
                pet.Porte = (Porte)Convert.ToInt32(Console.ReadLine());
                escolhaPorte = pet.Porte.ToString();
            }

            Console.WriteLine("Qual o peso do seu pet?");
            pet.Peso = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual a data de nascimento do seu pet?");
            pet.Nascimento = DateTime.Parse(Console.ReadLine());

            //pet.AdicionarDoencasAlergias

            Console.WriteLine(@"Seu pet é agressivo? Digite 1 para sim ou 2 para não");

            var agressividade = Console.ReadLine();
            while (agressividade != "1" && agressividade != "2" || string.IsNullOrWhiteSpace(agressividade))
            {
                Console.WriteLine("Opção inválida, tente novamente: ");
                agressividade = Console.ReadLine();
            }
            if (agressividade == "1")
            {
                pet.Agressivo = true;
            }
            else
            {
                pet.Agressivo = false;
            }
            Console.WriteLine(@"Qual o sexo do seu pet? Digite M para macho ou F para femêa");

            pet.Sexo = Convert.ToChar(Console.ReadLine().ToUpper());

            while (pet.Sexo != 'F' && pet.Sexo != 'M' || char.IsWhiteSpace(pet.Sexo))
            {
                Console.WriteLine("Opção inválida, tente novamente: ");
                agressividade = Console.ReadLine();
            }

            pet.Castrado = true;

            pet.ImprimirAnimal();
        }
    }
}