

using TestesAutomatizados.Domain;

var carrinho = new CarrinhoDeCompras();

carrinho.Adiciona(new Produto("Geladeira", 450.0M));
carrinho.Adiciona(new Produto("Liquidificador", 250.0M));
carrinho.Adiciona(new Produto("Jogo de pratos", 70.0M));

var algoritmo = new MaiorEMenor();

algoritmo.Encontra(carrinho);

Console.WriteLine($"\nO menor produto: {algoritmo.Menor.Nome}");
Console.WriteLine($"O maior produto: {algoritmo.Maior.Nome}\n");

