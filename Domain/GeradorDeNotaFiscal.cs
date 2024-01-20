using TestesAutomatizados.Model;

namespace TestesAutomatizados.Domain;

public class GeradorDeNotaFiscal
{
    private NFDao dao;
    private SAP sap;

    public GeradorDeNotaFiscal(NFDao dao, SAP sap)
    {
        this.dao = dao;
        this.sap = sap;
    }

    public virtual NotaFiscal Gera(Pedido pedido)
    {
        var nf = new NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94M, DateTime.Now);
        
        dao.Persiste(nf);
        sap.Envia(nf);

        return nf;
    }
}


