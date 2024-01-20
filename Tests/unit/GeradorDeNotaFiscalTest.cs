using Moq;
using TestesAutomatizados.Domain;
using TestesAutomatizados.Model;
using Xunit;

namespace TestesAutomatizados.Tests.Unit;

public class GeradorDeNotaFiscalTest
{
    [Fact(DisplayName = "Deve gerar nota fiscal com valor de imposto descontado")]
    public void DeveGerarNFComValorDeImpostoDescontado()
    {
        var dao = new Mock<NFDao>();
        var sap = new Mock<SAP>();

        var gerador = new GeradorDeNotaFiscal(dao.Object, sap.Object);
        var pedido = new Pedido("Willian", 1000, 1);
        var nf = gerador.Gera(pedido);

        Assert.Equal(1000 * 0.94M, nf.Valor);
    }

    [Fact(DisplayName = "Deve persistir nota fiscal gerada")]
    public void DevePersistirNFGerada()
    {
        // criando o mock
        var dao = new Mock<NFDao>();
        var sap = new Mock<SAP>();

        var gerador = new GeradorDeNotaFiscal(dao.Object, sap.Object);
        var pedido = new Pedido("Willian", 1000, 1);
        var nf = gerador.Gera(pedido);

        /// Configurar o comportamento do método Persiste
        dao.Setup(t => t.Persiste(It.IsAny<NotaFiscal>()));

        // verificando que o método foi invocado
        dao.Verify(t => t.Persiste(nf));
    }

    [Fact(DisplayName = "Deve enviar nota fiscal para o SAP")]
    public void DeveEnviarNFGeradaParaSAP()
    {
        var dao = new Mock<NFDao>();
        var sap = new Mock<SAP>();

        var gerador = new GeradorDeNotaFiscal(dao.Object, sap.Object);
        var pedido = new Pedido("Willian", 1000, 1);
        var nf = gerador.Gera(pedido);
        
        // Configurar o comportamento do método Envia
        sap.Setup(t => t.Envia(It.IsAny<NotaFiscal>()));

        // verificando que o método foi invocado
        sap.Verify(t => t.Envia(nf));
    }
}

