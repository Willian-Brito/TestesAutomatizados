Feature: Maior e Menor Produto por Preço no Carrinho de Compras

  Como um cliente interessado em tomar decisões com base no preço dos produtos
  Eu quero ser capaz de identificar o maior e o menor produto no meu carrinho de compras
  Para tomar decisões informadas de compra

  Scenario: Identificar o maior e o menor produto por preço no carrinho de compras
    Given Eu adicionei alguns produtos ao meu carrinho de compras
    When Eu seleciono a opção para identificar o maior e o menor produto por preço no carrinho de compras
    Then Devo ver as informações do produto mais caro e mais barato no meu carrinho de compras

    And Eu devo ver o maior produto exibido primeiro
    And Eu devo ver o menor produto exibido depois do maior produto


