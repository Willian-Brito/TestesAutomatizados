using NHibernate;
using TestesAutomatizados.Domain;
using TestesAutomatizados.Model.DAO;
using Xunit;

namespace TestesAutomatizados.Tests.Integration;

public class ProdutoDAOTest
{
    private ISession Session;
    private ITransaction Transaction;
    
    public void Inicializa()
    {
        // pegando uma conexão com banco de testes
        Session = new CriadorDeSessoes().BancoDeTestes();
        Transaction = Session.BeginTransaction();
    }

    public void LimpaTudo()
    {
        Transaction.Rollback();
        Session.Close();
    }

    // [Fact(DisplayName = "Deve adicionar um produto no banco de dados")]
    public void DeveAdicionarUmProduto()
    {
        var dao = new ProdutoDAO(Session);
        var produto = new Produto("Geladeira", 150.0M);

        dao.Adiciona(produto);

        // buscando no banco pelo id
        // para ver se está igual ao produto do cenário
        var salvo = dao.PorId(produto.IdProduto);
        Assert.Equal(salvo, produto);
    }

    // [Fact(DisplayName = "Deve filtrar produtos ativos do banco de dados")]
    public void DeveFiltrarAtivos()
    {
        var dao = new ProdutoDAO(Session);
        var ativo = new Produto("Geladeira", 150.0M);
        var inativo = new Produto("Geladeira", 150.0M);

        inativo.Inativa();

        // salvando ambos os produtos no banco
        Session.Save(ativo);
        Session.Save(inativo);

        var produtos = dao.Ativos();

        Assert.Equal(1, produtos.Count);
        Assert.Equal(inativo, produtos[0]);
    }
}



