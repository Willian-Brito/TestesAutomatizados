namespace TestesAutomatizados.Domain;

public class CarrinhoDeCompras
{
    public List<Produto> Produtos {get; set;}

    public CarrinhoDeCompras() 
    {
        Produtos  = new List<Produto>();    
    }

    public void Adiciona(Produto produto)
    {
        Produtos.Add(produto);
    }

    public Produto ObterProdutoMaisCaro()
    {
        var algoritmo = new MaiorEMenor();
        algoritmo.Encontra(this);

        return algoritmo.Maior;
    }

    public Produto ObterProdutoMaisBarato()
    {
        var algoritmo = new MaiorEMenor();
        algoritmo.Encontra(this);

        return algoritmo.Menor;
    }

    public List<Produto> OrdenarPorMaisCaro()
    {
        var produtosOrdenados = Produtos.OrderByDescending(item => item.Valor).ToList();
        return produtosOrdenados;
    }
}
