# Lista de Exercícios de C# — Variáveis, Operadores, Entrada/Saída, Bitwise e Enums

**Instruções:**

- Resolva os exercícios usando apenas **C# puro** (sem bibliotecas externas).
- Use **entrada via teclado** (`Console.ReadLine()`) sempre que indicado.
- Use **formatação de saída** (`Console.WriteLine()` com interpolação ou `ToString()` formatado).
- Respeite o **escopo** de variáveis e boas práticas.

---

## 1. Declarando e exibindo variáveis

Crie um programa que declare uma variável `int` chamada `idade` e exiba seu valor.

---

## 2. Usando `var`

Declare uma variável usando `var` para armazenar seu nome (tipo `string`) e mostre no console.

---

## 3. Trabalhando com diferentes tipos

Declare variáveis dos tipos `int`, `float`, `char` e `bool` e imprima seus valores.

---

## 4. Escopo de variáveis

Crie uma variável `int` dentro de um bloco `if` e tente acessá-la fora dele. O que acontece?  
**(Comente no código a explicação.)**

---

## 5. Operações matemáticas básicas

Leia dois números inteiros e exiba a soma, subtração, multiplicação e divisão deles.

---

## 6. Prioridade de operadores

Sem usar parênteses, avalie a expressão:

```csharp
int resultado = 5 + 2 * 3;
```

Depois adicione parênteses para alterar o resultado para 21.

---

## 7. Constantes

Declare uma constante `PI` com o valor `3.14159` e calcule a área de um círculo lendo o raio do teclado.

---

## 8. Operadores relacionais

Leia dois valores inteiros e imprima se eles são iguais ou diferentes.

---

## 9. Operadores lógicos

Leia dois números e exiba `true` se ambos forem positivos.

---

## 10. Bitwise AND simples

Leia dois números inteiros e mostre o resultado da operação bitwise AND (`&`) entre eles.

---

## 11. Bitwise OR simples

Leia dois números inteiros e mostre o resultado da operação bitwise OR (`|`) entre eles.

---

## 12. Bitwise XOR simples

Leia dois números inteiros e mostre o resultado da operação bitwise XOR (`^`) entre eles.

---

## 13. Operações de deslocamento de bits

Leia um número inteiro e exiba:

- O número deslocado 1 bit para a esquerda (`<<`)
- O número deslocado 1 bit para a direita (`>>`)

---

## 14. Entrada e conversão de tipos

Leia uma entrada do teclado e converta para `double`. Exiba o valor formatado com 2 casas decimais.

---

## 15. Formatação de saída

Leia um valor `decimal` e mostre como valor monetário (`C2`), percentual (`P`), e número com 2 casas (`N2`).

---

## 16. Criando um `enum`

Crie um `enum` chamado `DiasDaSemana` com os dias de domingo a sábado.

---

## 17. Usando `enum` e entrada de dados

Peça ao usuário para digitar um número (0 a 6) e imprima o dia da semana correspondente usando o `enum` `DiasDaSemana`.

---

## 18. Comparando `enum`

Crie dois valores do tipo `DiasDaSemana` e compare se são iguais, imprimindo uma mensagem.

---

## 19. Constantes compostas

Crie um `enum` de tipos de usuário (`Admin`, `Usuario`, `Convidado`) e use constantes para definir os níveis de permissão (por exemplo: 0, 1, 2).

---

## 20. Projeto Final: Mini cadastro

Crie um programa que:

- Peça nome (string), idade (int) e tipo de usuário (enum) via teclado;
- Exiba todas as informações formatadas com interpolação de string.

Exemplo de saída:

```
Nome: João - Idade: 30 - Tipo: Admin
```

---
