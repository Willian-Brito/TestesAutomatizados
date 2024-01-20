using TechTalk.SpecFlow;
using TestesAutomatizados.Domain;
using Xunit;

namespace TestesAutomatizados.Tests.Features;

[Binding]
public class MaiorMenorSteps
{
    private CarrinhoDeCompras carrinho;
    private MaiorEMenor algoritmo;

    [Given(@"Eu adicionei alguns produtos ao meu carrinho de compras")]
    public void GivenEuAdicioneiAlgunsProdutosAoMeuCarrinhoDeCompras()
    {
        carrinho = new CarrinhoDeCompras();
        carrinho.Adiciona(new Produto("Jogo de pratos", 70.0M));
        carrinho.Adiciona(new Produto("Geladeira", 450.0M));
        carrinho.Adiciona(new Produto("Liquidificador", 250.0M));
    }

    [When(@"Eu seleciono a opção para identificar o maior e o menor produto por preço no carrinho de compras")]
    public void WhenEuSelecionoAOpcaoParaIdentificarOMaiorEOmenorProdutoPorPrecoNoCarrinhoDeCompras()
    {
        algoritmo = new MaiorEMenor();
        algoritmo.Encontra(carrinho);
    }

    [Then(@"Devo ver as informações do produto mais caro e mais barato no meu carrinho de compras")]
    public void ThenDevoVerAsInformacoesDoProdutoMaisCaroEMaisBaratoNoMeuCarrinhoDeCompras()
    {
        var produtoMaisCaro = algoritmo.Maior;
        var produtoMaisBarato = algoritmo.Menor;

        Assert.NotNull(produtoMaisCaro);
        Assert.NotNull(produtoMaisBarato);

        Assert.True(produtoMaisCaro.Valor > produtoMaisBarato.Valor);
    }

    [Then(@"Eu devo ver o maior produto exibido primeiro")]
    public void ThenEuDevoVerOMaiorProdutoExibidoPrimeiro()
    {
        var produtosNoCarrinho = carrinho.OrdenarPorMaisCaro();
        var indiceMaiorProduto = produtosNoCarrinho.IndexOf(carrinho.ObterProdutoMaisCaro());

        Assert.True(indiceMaiorProduto == 0);
    }

    [Then(@"Eu devo ver o menor produto exibido depois do maior produto")]
    public void ThenEuDevoVerOMenorProdutoExibidoDepoisDoMaiorProduto()
    {
        var produtosNoCarrinho = carrinho.OrdenarPorMaisCaro();
        var indiceMenorProduto = produtosNoCarrinho.IndexOf(carrinho.ObterProdutoMaisBarato());
        var indiceMaiorProduto = produtosNoCarrinho.IndexOf(carrinho.ObterProdutoMaisCaro());

        Assert.True(indiceMenorProduto > indiceMaiorProduto);
    }
}

