

using NHibernate;
using TestesAutomatizados.Domain;

namespace TestesAutomatizados.Model.DAO;

public class ProdutoDAO
{
    private ISession Session;

    public ProdutoDAO(ISession session)
    {
        Session = session;
    }

    public void Adiciona(Produto produto)
    {
        Session.Save(produto);
    }

    public Produto PorId(int id)
    {
        return Session.Load<Produto>(id);
    }

    public List<Produto> Ativos()
    {
        var produtosAtivos = (List<Produto>)Session.CreateQuery("from Produto p where p.Ativo = true");
        return produtosAtivos;
    }
}


