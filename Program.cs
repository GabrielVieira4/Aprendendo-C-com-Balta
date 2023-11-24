using System; // São as importações

namespace MeuApp // Divisões lógicas
{
    class program // É o programa em si,tudo que será executado na aplicação.
    {
        static void Main(string[] args) // Método main, é o principal método da aplicação, é o que será executado primeiro
        {
            string nome = RetornaNome("Gabriel", "Vascaino", 27);
            Console.WriteLine(nome);

            MeuMetodo();
        }

        static void MeuMetodo()
        {
            Console.WriteLine("Calma Largatixo!");
        }

        static string RetornaNome(string nome, string sobrenome, int idade)
        {
            return nome + " " + sobrenome + " tem " + idade.ToString() + " " + "anos";
        }
    }
}
