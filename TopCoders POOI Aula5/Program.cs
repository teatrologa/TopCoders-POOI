namespace TopCoders_POOI_Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa caixaDoDia = new Caixa();
            caixaDoDia.AbrirCaixa();

            Console.WriteLine($"Caixa Aberto em { caixaDoDia.DataCaixa }");

            Console.WriteLine(caixaDoDia.Saldo);

            caixaDoDia.Deposita(10);

            Console.WriteLine(caixaDoDia.Saldo);

            caixaDoDia.Deposita(50);

            Console.WriteLine(caixaDoDia.Saldo);

            caixaDoDia.Saca(20);

            Console.WriteLine(caixaDoDia.Saldo);
        }
    }
}