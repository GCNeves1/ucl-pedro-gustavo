namespace Padaria
{
    public class estoque
    {
        private string produto { get; set; }
        private float valor { get; set; }

        public string GetProduto() => this.produto;
        public void SetProduto(string produto) => this.produto = produto;
        public float GetValor() => this.valor;
        public void SetValor(float valor) => this.valor = valor;

        public override string ToString()
        {
            return $"{produto},{valor}";
        }

        public static estoque FromString(string data)
        {
            var parts = data.Split(',');
            return new estoque
            {
                produto = parts[0],
                valor = float.Parse(parts[1])
            };
        }
    }
}