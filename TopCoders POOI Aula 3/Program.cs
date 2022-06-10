using LetsCodePOOIAula3.Classes;
using LetsCodePOOIAula3.Enums;

namespace LetsCodePOOIAula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animaldoSergio = new Animal();
            animaldoSergio.nome = "Chica";
            animaldoSergio.especie = Especie.Cachorro;
            animaldoSergio.raca = "SRD";
            animaldoSergio.cor = "Preta";
            animaldoSergio.porte = Porte.Pequeno;
            animaldoSergio.peso = 8;
            animaldoSergio.nascimento = new DateTime(2015, 12, 1);
            animaldoSergio.agressivo = false;
            animaldoSergio.sexo = 'F';
            animaldoSergio.castrado = true;

            animaldoSergio.ImprimirAnimal();

            Animal animaldaThayssa = new Animal();

            animaldaThayssa.nome = "Lajotinha";
            animaldaThayssa.especie = Especie.Cachorro;
            animaldaThayssa.raca = "SRD";
            animaldaThayssa.cor = "Marrom";
            animaldaThayssa.porte = Porte.Grande;
            animaldaThayssa.peso = 23;
            animaldaThayssa.RegistrarNascimento(2013, 10);

            //List<string> doencasAnimaldaThayssa = new List<string>();
            //doencasAnimaldaThayssa.Add("Cegueira Total");

            //animaldaThayssa.doencasAlergias = new List<string>() { "Cegueira Total" } ;

            animaldaThayssa.AdicionarDoencasAlergias("Cegueira Total");

            animaldaThayssa.agressivo = false;
            animaldaThayssa.sexo = 'M';
            animaldaThayssa.castrado = true;

            animaldaThayssa.ImprimirAnimal();

        }
    }
}