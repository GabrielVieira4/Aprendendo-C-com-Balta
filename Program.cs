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

            Product camisaDoVasco = new Product(1, "Camisa Vasco Oficial II 2023 Kappa", 299.99);
            Console.WriteLine(camisaDoVasco.Id);
            Console.WriteLine(camisaDoVasco.Name);
            Console.WriteLine(camisaDoVasco.Price);
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

    struct Product
    {
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id;
        public string Name;
        public double Price;
        public double PriceInDollar(double dolar)
        {
            return Price * dolar;
        }
    }
}
