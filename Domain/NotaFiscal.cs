namespace TestesAutomatizados.Domain;

public class NotaFiscal
{
    public string Cliente { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }

    public NotaFiscal(string cliente, decimal valor, DateTime data)
    {
        Cliente = cliente;
        Valor = valor;
        Data = data;
    }
}

