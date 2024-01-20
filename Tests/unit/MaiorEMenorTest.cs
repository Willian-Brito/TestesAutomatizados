using TestesAutomatizados.Domain;
using Xunit;

namespace TestesAutomatizados.Tests.Unit;

public class MaiorEMenorTest
{
    
    [Fact(DisplayName = "Deve testar o algoritmo MaiorEMenor na ordem decrescente")]
    public void OrdemDecrescente()
    {
        var carrinho = new CarrinhoDeCompras();

        carrinho.Adiciona(new Produto("Geladeira", 450.0M));
        carrinho.Adiciona(new Produto("Liquidificador", 250.0M));
        carrinho.Adiciona(new Produto("Jogo de pratos", 70.0M));
        
        var algoritmo = new MaiorEMenor();
        algoritmo.Encontra(carrinho);

        Assert.Equal("Jogo de pratos", algoritmo.Menor.Nome);
        Assert.Equal("Geladeira", algoritmo.Maior.Nome);
    }

    [Fact(DisplayName = "Deve testar o algoritmo MaiorEMenor na ordem crescente")]
    public void OrdemCrescente()
    {
        var carrinho = new CarrinhoDeCompras();

        carrinho.Adiciona(new Produto("Jogo de pratos", 70.0M));
        carrinho.Adiciona(new Produto("Liquidificador", 250.0M));
        carrinho.Adiciona(new Produto("Geladeira", 450.0M));
        
        var algoritmo = new MaiorEMenor();
        algoritmo.Encontra(carrinho);

        Assert.Equal("Jogo de pratos", algoritmo.Menor.Nome);
        Assert.Equal("Geladeira", algoritmo.Maior.Nome);
    }

    [Fact(DisplayName = "Deve testar o algoritmo MaiorEMenor na ordem variada")]
    public void OrdemVariada()
    {
        var carrinho = new CarrinhoDeCompras();

        carrinho.Adiciona(new Produto("Jogo de pratos", 70.0M));
        carrinho.Adiciona(new Produto("Geladeira", 450.0M));
        carrinho.Adiciona(new Produto("Liquidificador", 250.0M));
        
        var algoritmo = new MaiorEMenor();
        algoritmo.Encontra(carrinho);

        Assert.Equal("Jogo de pratos", algoritmo.Menor.Nome);
        Assert.Equal("Geladeira", algoritmo.Maior.Nome);
    }

    [Fact(DisplayName = "Deve testar o algoritmo com apenas um produto")]
    public void ApenasUmProduto()
    {
        var carrinho = new CarrinhoDeCompras();

        carrinho.Adiciona(new Produto("Geladeira", 450.0M));
        
        var algoritmo = new MaiorEMenor();
        algoritmo.Encontra(carrinho);

        Assert.Equal("Geladeira", algoritmo.Menor.Nome);
        Assert.Equal("Geladeira", algoritmo.Maior.Nome);
    }
}



