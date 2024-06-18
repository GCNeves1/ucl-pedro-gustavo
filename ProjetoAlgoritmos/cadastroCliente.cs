namespace Padaria
{
    public class cadastroCliente
    {
        private string nome { get; set; }
        private string telefone { get; set; }
        private string email { get; set; }

        public string GetNome() => this.nome;
        public void SetNome(string nome) => this.nome = nome;
        public string GetTelefone() => this.telefone;
        public void SetTelefone(string telefone) => this.telefone = telefone;
        public string GetEmail() => this.email;
        public void SetEmail(string email) => this.email = email;

        public override string ToString()
        {
            return $"{nome},{telefone},{email}";
        }

        public static cadastroCliente FromString(string data)
        {
            var parts = data.Split(',');
            return new cadastroCliente
            {
                nome = parts[0],
                telefone = parts[1],
                email = parts[2]
            };
        }
    }
}