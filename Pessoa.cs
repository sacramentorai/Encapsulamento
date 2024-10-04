namespace Encapsulamento
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string telefone;
        private string email;
        private string endereco;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { Console.WriteLine("Por favor digite o seu nome."); }
                else { nome = value; }
            }
        }
        public int Idade
        {
            get { return idade; }
            set
            {
                if (value < 0) { Console.WriteLine("Digite sua idade correta."); }
                else { idade = value; }
            }
        }
        public string Endereco
        {
            get { return endereco; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { Console.WriteLine("Por favor digite o seu endereço."); }
                else { endereco = value; }
            }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { Console.WriteLine("Por favor digite o seu telefone."); }
                else { telefone = value; }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { Console.WriteLine("Por favor digite o seu email.\n"); }
                else { email = value; }
            }
        }

    }
}



  
        
        
