# filter-numbers
### Desafio Técnico

**Título: Contagem Personalizada e Filtragem de Números**

**Contexto:**
Você foi contratado para desenvolver uma funcionalidade em um sistema que precisa gerar uma lista de números baseada em uma série de regras específicas. O sistema deve permitir que o usuário defina um intervalo de números e então filtre essa lista de acordo com critérios predefinidos.

**Requisitos:**
1. O usuário deve informar dois números inteiros, `inicio` e `fim`, que representam o intervalo inclusivo da contagem.
2. O sistema deve gerar uma lista de números que vão de `inicio` até `fim`.
3. Em seguida, o sistema deve permitir que o usuário escolha um dos seguintes filtros:
   - Mostrar apenas os números pares.
   - Mostrar apenas os números ímpares.
   - Mostrar apenas os números múltiplos de um número específico, que também será informado pelo usuário.
4. Finalmente, o programa deve exibir a lista resultante após a aplicação do filtro escolhido.

**Exemplo:**
Se o usuário informar:
- `inicio = 1`
- `fim = 10`
- Filtro escolhido: números pares

O programa deve exibir: `2, 4, 6, 8, 10`.

**Regras adicionais:**
- Caso o valor de `inicio` seja maior que `fim`, o programa deve informar um erro e solicitar novos valores.
- Se o intervalo for válido, mas o filtro aplicado não resultar em nenhum número (por exemplo, filtro de múltiplos de 11 no intervalo de 1 a 10), o programa deve exibir uma mensagem informando que "Nenhum número foi encontrado com esse critério".

### Dicas

- Lembre-se de usar `for`, `while`, ou `do-while` para iterar sobre o intervalo de números.
- Para verificar se um número é par ou ímpar, você pode usar o operador de módulo `%`.
- Para o filtro de múltiplos, certifique-se de que o número é divisível sem resto pelo valor informado pelo usuário.

### Teste Seu Código

Para garantir que seu código funcione corretamente, teste com diferentes intervalos e filtros. Aqui estão alguns casos de teste sugeridos:

1. `inicio = 1`, `fim = 10`, filtro: ímpares.
2. `inicio = 5`, `fim = 15`, filtro: múltiplos de 3.
3. `inicio = 20`, `fim = 10` (teste o comportamento quando `inicio` é maior que `fim`).
4. `inicio = 0`, `fim = 0`, filtro: pares.

### Reflexão

Após resolver o desafio, reflita sobre como o uso de laços de repetição facilitou a iteração sobre o intervalo de números. Como você lidou com os diferentes critérios de filtragem? Em quais situações reais de desenvolvimento você poderia aplicar esse tipo de lógica?

Boa sorte com o desafio! 🚀 Se precisar de mais alguma coisa, estou aqui para ajudar.
