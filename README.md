# daCalculator8051 - no SawTooth
Programa para auxiliar no cálculo dos valores que serão carregados na memória do 8051 para serem passados para o DAC, para o mesmo
criar a onda desejada.

Como utilizar:
  Digite os valores desejados de Vmin, Vmáx,resolução da onda gerada e selecione o tipo de onda desejada.
  
Ondas implementadas na build atual:
  - Quadrada
  - Triangular
  - Senoidal
  
Ondas a serem implementadas:
  
  
  - Sawtooth
  
Como utilizar os valores retornados pelo programa:

No programa em assembly, utilize a instrução DB (Define Byte), da seguinte maneira: 
  DB valores da memória
  
  Ex: DB 0FFH, 000H
  
  Essa instrução deve ser localizada em uma posição com até 256B livres no endereçamento pois a instrução DB carrega os
  valores de byte em byte incrementando a posição na memória.
  
  Ex: 
  
      ORG 5100H        
        DB 0FFH, 000H       
      END
  
  Ponto de vista da memória:
  
    5100H -> 0FFH    
    5101H -> 00H
  
  Assim para utilizar basta apenas copiar a instrução DB gerada pelo programa e utilizar um apontador para aquela posição de memória.
  
  Links para download são encontradas na aba Releases ou aqui:
    
   https://github.com/BrandyLover/daCalculator8051/releases
      
