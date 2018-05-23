# yurigama_reguladortensao

Conceito: Engenharia Eletrônica: regulador de tensão com diodo Zener.

Finalidade: Obter os parâmetros de um regulador de tensão com diodo Zener, tais como potencia mínima do Zener, potência mínima do resistor e valor do resistor, a partir das características do sinal de entrada, tais como tensão de entrada, dentre outras.

Motivação: A maior aplicação do diodo Zener reside na regulação de tensão de saída de fontes de alimentação. Através da utilização do diodo Zener, em conjunto com um resistor, pode-se conseguir que uma fonte de alimentação forneça tensão praticamente constante à carga. 

Interface gráfica: utilizando WindowsForms.

Tutorial utilizado: https://www.youtube.com/watch?v=sfzhB4eSNNM&list=PLS1QulWo1RIZz6uDid--I09EOImRmPHS0&index=7

Descrição do funcionamento da interface gráfica do usuário (GUI): o usuário, ao iniciar o programa pelo seu executável, terá acesso a uma GUI que exibirá 3 campos editáveis - Tensão de entrada (Vi), Corrente Total (I) e Tensão Zener (Vz) - para que sejam inseridos os valores de entrada para calcúlo dos parâmtros do regulador Zener. A GUI também exibirá um esquemático do circuito regulador Zener, com a indicação do nome da entrada/saída ao lado de cada componente, para facilitar a identificação pelo usuário. Ao clicar no botão "Calcular" existente, a GUI exibirá os valores de parâmetro para o regulador: Valor da Resistencia (Rs), Potência dissipada pela resistência Rs e valor máximo da corrente no diodo Zener (Iz).
