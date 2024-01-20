namespace TestesAutomatizados.Domain;

public class Produto
{
    public int IdProduto { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public bool EstaAtivo { get; set; }

    public Produto(string nome, decimal valor)
    {
        Nome = nome;
        Valor = valor;
    }

    public void Inativa()
    {
        EstaAtivo = false;
    }
}
