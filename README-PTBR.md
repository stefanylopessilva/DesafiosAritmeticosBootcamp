# Desafios Aritméticos Intermediários em C# Bootcamp GFT 📝

Desafios realizados no processo seletivo do programa START UNI da GFT em C#

## 💵 Exercício Notas e Moedas

Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

✔️ Entrada
O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

✔️ Saída
Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

| Exemplo de Entrada    | Exemplo de Saída      | 
|-----------------------|-----------------------|
|576.73                 | NOTAS:                |
|                       |5 nota(s) de R$ 100.00 |
|                       |1 nota(s) de R$ 50.00  |
|                       |1 nota(s) de R$ 20.00  |
|                       |0 nota(s) de R$ 10.00  |
|                       |1 nota(s) de R$ 5.00   |
|                       |0 nota(s) de R$ 2.00   |
|                       |MOEDAS:                |
|                       |1 moeda(s) de R$ 1.00  |
|                       |1 moeda(s) de R$ 0.50  |
|                       |0 moeda(s) de R$ 0.25  |
|                       |2 moeda(s) de R$ 0.10  |
|                       |0 moeda(s) de R$ 0.05  |
|                       |3 moeda(s) de R$ 0.01  |
|-----------------------|-----------------------|
|4.00                   | NOTAS:                |
|                       |0 nota(s) de R$ 100.00 |
|                       |0 nota(s) de R$ 50.00  |
|                       |0 nota(s) de R$ 20.00  |
|                       |0 nota(s) de R$ 10.00  |
|                       |0 nota(s) de R$ 5.00   |
|                       |2 nota(s) de R$ 2.00   |
|                       |MOEDAS:                |
|                       |0 moeda(s) de R$ 1.00  |
|                       |0 moeda(s) de R$ 0.50  |
|                       |0 moeda(s) de R$ 0.25  |
|                       |0 moeda(s) de R$ 0.10  |
|                       |0 moeda(s) de R$ 0.05  |
|                       |0 moeda(s) de R$ 0.01  |
|-----------------------|-----------------------|
|91.01                  | NOTAS:                |
|                       |0 nota(s) de R$ 100.00 |
|                       |1 nota(s) de R$ 50.00  |
|                       |2 nota(s) de R$ 20.00  |
|                       |0 nota(s) de R$ 10.00  |
|                       |0 nota(s) de R$ 5.00   |
|                       |0 nota(s) de R$ 2.00   |
|                       |MOEDAS:                |
|                       |1 moeda(s) de R$ 1.00  |
|                       |0 moeda(s) de R$ 0.50  |
|                       |0 moeda(s) de R$ 0.25  |
|                       |0 moeda(s) de R$ 0.10  |
|                       |0 moeda(s) de R$ 0.05  |
|                       |1 moeda(s) de R$ 0.01  |
|-----------------------|-----------------------|

## 🔺 Exercício Tipos de Triângulos

Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

✔️ Entrada
A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

✔️ Saída
Imprima todas as classificações do triângulo especificado na entrada.

| Exemplo de Entrada    | Exemplo de Saída      | 
|-----------------------|-----------------------|
|7.0 5.0 7.0            | TRIANGULO ACUTANGULO  |
|                       | TRIANGULO ISOSCELES   |
|-----------------------|-----------------------|
|6.0 6.0 10.0           | TRIANGULO OBTUSANGULO |
|                       | TRIANGULO ISOSCELES   |
|-----------------------|-----------------------|
|6.0 6.0 6.0            | TRIANGULO ACUTANGULO  |
|                       | TRIANGULO EQUILATERO  |
|-----------------------|-----------------------|
|5.0 7.0 2.0            | NAO FORMA TRIANGULO   |
|-----------------------|-----------------------|
|6.0 8.0 10.0           | TRIANGULO RETANGULO   |
|-----------------------|-----------------------|

## 🖩 Exercício Fórmula de Bhaskara

Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

✔️ Entrada
Leia três valores de ponto flutuante (double) A, B e C.

✔️ Saída
Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.

| Exemplo de Entrada    | Exemplo de Saída      | 
|-----------------------|-----------------------|
|10.0 20.1 5.1          | R1 = -0.29788         |
|                       | R2 = -1.71212         |
|-----------------------|-----------------------|
|0.0 20.0 5.0           | Impossivel calcular   |
|-----------------------|-----------------------|
|10.3 203.0 5.0         | R1 = -0.02466         |
|                       | R2 = -19.68408        |
|-----------------------|-----------------------|
|10.0 3.0 5.0           | Impossivel calcular   |
|-----------------------|-----------------------|