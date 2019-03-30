# daCalculator8051
Programa para auxiliar no cálculo dos valores que serão carregados na memória do 8051 para serem passados para o DAC, para o mesmo
criar a onda desejada.

Como utilizar:
  Digite os valores desejados de Frequência, Vmin, Vmáx,resolução da onda gerada e selecione o tipo de onda desejada.
  
Ondas implementadas na build atual:
  - Quadrada
Ondas a serem implementadas:
  - Triangular
  - Senoidal
  - Sawtooth
Como utilizar os valores retornados pelo programa:
  No programa em assembly, utilize a instrução DB (Define Byte), da seguinte maneira: DB valores da memória
  Ex: DB FF00H
  Essa instrução deve ser localizada em uma posição com pelo menos 256B livres no endereçamento pois a instrução DB carrega os
  valores de byte em byte incrementando a posição na memória.
  Ex:                 Ponto de vista da memória:
      ORG 5100H        5100H -> 0FFH
        DB FF00H       5101H -> 00H
      END
      
  Assim para utilizar pode se usar um apontador para a tabela na memória externa(ou interna) dos valores a serem carregados no DAC
      
