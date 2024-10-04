
namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "";
            pessoa.Idade =  0;
            pessoa.Endereco = "";
            pessoa.Telefone = "";
            pessoa.Email = "";

            pessoa.Nome = "Rai";
            pessoa.Idade = 27;
            pessoa.Endereco = "Rua um";
            pessoa.Telefone = "819123456";
            pessoa.Email = "rai@rai.com";

            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Idade + " anos");
            Console.WriteLine(pessoa.Endereco);
            Console.WriteLine(pessoa.Telefone);
            Console.WriteLine(pessoa.Email);    




        }
    }
}

