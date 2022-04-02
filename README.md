# Ladders and Snakes
---

## Autoria

* Bruno Rodrigues a22103346
* Fábio Ribeiro a22102432
* Marco Santos a22103641

---

## 1. Commits

Bruno Rodrigues - Print do tabuleiro como também a criação do tabuleiro, também ficou fez a função playerRoll, movePlayerByDie e a função Main.

Fábio Ribeiro - Criou a função buildBoard embora tenha sido alterada posteriormente, ajudou em relação à função movePlayerByDie em relação à movimentação do jogador quando excede o número de casas para chegar ao fim, criou a função dice e trabalhou na função Main na parte do ciclo criada pelo Bruno. Também fez a documentação XML e como também trabalhou no fluxograma.

Marco Santos - Ajudou na criação do fluxograma.

## 2. Arquitetura da solução

O código foi dividio em métodos para evitar a repetição de código desnecessária e esses métodos foram: buildBoard serve para contruir um array de 25 números inteiros; printBoard tem como função imprimir o tabuleiro construido pela função buildBoard; movePlayerByDie este método recebe o jogador, o valor obtido pelo dado e o tabuleiro que serve para mover o jogador que está a jogador no lançamento desse dado; o método dice tal como indica serve para obter um número aleatório entre 1-6; playerRoll serve para armazenar o valor obtido pelo método dice() e pedir ao utilizador um input ("r" ou "R"), caso o input esteja errado volta a pedir ao utilizador até ter o input correto e por fim este método também imprime o valor obtipo pelo método dice(); e o Main tem um ciclo que verifica se algum dos jogadores chegou à última posição do tabuleiro.

### Fluxograma

![fluxograma_1.drawio.png](https://www.dropbox.com/s/q361oqbkum7tqz6/fluxograma_1.drawio.png?dl=0&raw=1)



