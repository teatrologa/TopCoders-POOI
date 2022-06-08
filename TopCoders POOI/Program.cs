namespace TopCoders_POOI_Aula1
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


            //Escrevendo animal
            Console.WriteLine(animal.nome);
            Console.WriteLine(animal.especie);
            Console.WriteLine(animal.raca);
            Console.WriteLine(animal.cor);
            Console.WriteLine(animal.porte);
            Console.WriteLine(animal.peso);
            Console.WriteLine(animal.nascimento);
            Console.WriteLine(animal.agressividade);
            Console.WriteLine(animal.castracao);
            Console.WriteLine(animal.ObterCodigo());
            // Console.WriteLine(animal.codigo); //ACHO QUE ESTÁ ASSIM PQ ESTÁ COM O GET
            Console.WriteLine(animal.dataCadastro);
            Console.WriteLine(animal.ObterDataCadastro());

            //Console.WriteLine(" ");
            //Console.Write("Nome:");
            //Console.WriteLine(animal.nome);
            
            


        }


    }
}