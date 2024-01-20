namespace TestesAutomatizados.Domain;

public class Pedido
{
    public string Cliente { get; private set; }
    public decimal ValorTotal { get; private set; }
    public int QuantidadeItens { get; private set; }

    public Pedido(string cliente, decimal valorTotal, int quantidadeItens)
    {
        Cliente = cliente;
        ValorTotal = valorTotal;
        QuantidadeItens = quantidadeItens;
    }
}

