using TopCoders_POOI_Aula3_Exercicio.Enums;
using TopCoders_POOI_Aula3_Exercicio.Classes;

namespace TopCoders_POOI_Aula3_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine("Qual o nome do seu Pet?");
            animal.nome = Console.ReadLine();
            Console.WriteLine($"Qual a raça dx {animal.nome}?");
            animal.raca = Console.ReadLine();
            Console.WriteLine($"Qual a cor dx {animal.nome}?");
            animal.cor = Console.ReadLine();
            Console.WriteLine($"Qual o peso dx {animal.nome}? (KG | Ex: 2.5)");
            animal.peso = Convert.ToDecimal(Console.ReadLine());
            //animal.RegistrarNascimento(2016, 8, 25);


            Console.WriteLine("Seu animal é agressivo? [S/N]");
            var comportamento = Console.ReadLine();
            bool agressividade(string comportamento)
        {
                comportamento = comportamento.ToUpper();
                if (comportamento == "S" || comportamento == "s")
                {
                    return true;
                }
                
                else if (comportamento == "N" || comportamento == "n")
                {
                    return false;
                }

                else
                {
                    return false;
                }

            }
            animal.agressividade = agressividade(comportamento);


            Console.WriteLine("Qual o sexo do seu animal? [F/M]");
            var sexo = Console.ReadLine();
            sexo = sexo.ToUpper();
            animal.sexo = Convert.ToChar(sexo);


            Console.WriteLine("Seu animal é castrado? [S/N]");
            var reproducao = Console.ReadLine();
            bool castrado(string reproducao)
            {
                comportamento = reproducao.ToUpper();
                if (reproducao == "S")
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            animal.castracao = castrado(reproducao);




            animal.especie = Especie.Cachorro;
            animal.porte = Porte.Pequeno;
            animal.AdicionarDoencasAlergias("Alergia: Nozes");
            animal.AdicionarDoencasAlergias("Alergia: Cheiro forte");




            //Imprimindo animal
            Console.Clear();
            Console.WriteLine(" ");
            animal.ImprimirAnimal();



            
        }
    }

}