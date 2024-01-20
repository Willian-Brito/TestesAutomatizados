namespace TestesAutomatizados;

public class ConversorDeNumeroRomano
{
    private static Dictionary<char, int> tabela =
        new Dictionary<char, int>() {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int Converte(string numeroEmRomano)
    {
        var acumulador = 0;
        var ultimoVizinhoDaDireita = 0;

        for(int i = numeroEmRomano.Length - 1; i >= 0; i--)
        {
            // pega o inteiro referente ao simbolo atual
            var atual = tabela[numeroEmRomano[i]];

            // se o da direita for menor, o multiplicaremos
            // por -1 para torná-lo negativo
            var multiplicador = 1;

            if(atual < ultimoVizinhoDaDireita) 
                multiplicador = -1;

            acumulador += atual * multiplicador;

            // atualiza o vizinho da direita
            ultimoVizinhoDaDireita = atual;
        }
        return acumulador;
    }
}



