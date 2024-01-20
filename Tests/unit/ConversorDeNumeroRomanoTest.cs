using Xunit;

namespace TestesAutomatizados.Tests.Unit;

public class ConversorDeNumeroRomanoTest
{
    [Fact(DisplayName = "Deve entender o simbolo I")]
    public void DeveEntenderOSimboloI()
    {
        var romano = new ConversorDeNumeroRomano();
        var numero = romano.Converte("I");

        Assert.Equal(1, numero);
    }

    [Fact(DisplayName = "Deve entender o simbolo II")]
    public void DeveEntenderDoisSimbolosComoII()
    {
        var romano = new ConversorDeNumeroRomano();
        var numero = romano.Converte("II");

        Assert.Equal(2, numero);
    }

    [Fact(DisplayName = "Deve entender o simbolo XXII")]
    public void DeveEntenderQuatroSimbolosDoisADoisComoXXII()
    {
        var romano = new ConversorDeNumeroRomano();
        var numero = romano.Converte("XXII");

        Assert.Equal(22, numero);
    }

    [Fact(DisplayName = "Deve entender o simbolo IX")]
    public void DeveEntenderQuatroSimbolosDoisADoisComoIX()
    {
        var romano = new ConversorDeNumeroRomano();
        var numero = romano.Converte("IX");

        Assert.Equal(9, numero);
    }

    [Fact(DisplayName = "Deve entender o simbolo XXIV")]
    public void DeveEntenderQuatroSimbolosDoisADoisComoXXIV()
    {
        var romano = new ConversorDeNumeroRomano();
        var numero = romano.Converte("XXIV");

        Assert.Equal(24, numero);
    }

    [Fact(DisplayName = "Deve entender o simbolo V")]
    public void DeveEntenderOSimboloV()
    {
        var romano = new ConversorDeNumeroRomano();
        var numero = romano.Converte("V");

        Assert.Equal(5, numero);
    }
}




