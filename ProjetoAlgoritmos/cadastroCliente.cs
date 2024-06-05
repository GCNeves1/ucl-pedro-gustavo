class cadastroCliente
{
    private string nome { get; set; }
    private string telefone { get; set; }
    private string email { get; set; }

    // Nome
    public string GetNome()
    {
        return this.nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    // Telefone
    public string GetTelefone()
    {
        return this.telefone;

    }

    public void SetTelefone(string telefone)
    {
        this.telefone = telefone;
    }

    // Email
    public string GetEmail()
    {
        return this.email;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

}