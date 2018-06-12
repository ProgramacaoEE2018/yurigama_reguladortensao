# yurigama_reguladortensao

Conceito: Engenharia Eletrônica: regulador de tensão com diodo Zener.

Finalidade: Obter os parâmetros de um regulador de tensão com diodo Zener, tais como potencia mínima do Zener, potência mínima do resistor e valor do resistor, a partir das características do sinal de entrada, tais como tensão de entrada, dentre outras.

Motivação: A maior aplicação do diodo Zener reside na regulação de tensão de saída de fontes de alimentação. Através da utilização do diodo Zener, em conjunto com um resistor, pode-se conseguir que uma fonte de alimentação forneça tensão praticamente constante à carga. 

Interface gráfica: utilizando WindowsForms.

Tutorial utilizado: https://www.youtube.com/watch?v=sfzhB4eSNNM&list=PLS1QulWo1RIZz6uDid--I09EOImRmPHS0&index=7

Execução do tutorial para elaboração do esboço: https://user-images.githubusercontent.com/37374766/40452609-ccaf148c-5eb8-11e8-9813-16340de3a5f9.png

Descrição do funcionamento da interface gráfica do usuário (GUI): o usuário, ao iniciar o programa pelo seu executável, terá acesso a uma GUI que exibirá 4 campos editáveis - Tensão de entrada (V in), Corrente Total (I), Tensão Zener (Vz) e Resistência de carga (RL) - para que sejam inseridos os valores de entrada para calcúlo dos parâmtros do circuito regulador de tensão com diodo Zener. A GUI também exibirá um esquemático do circuito, com a indicação do nome da entrada/saída ao lado de cada componente, para facilitar a identificação dos parâmetros pelo usuário. A GUI terá dois botões: "Calcular" e "Limpar". Ao clicar no botão "Calcular", a tela exibirá os valores de parâmetros obtidos para o regulador: valor da resistencia em série (Rs), potência dissipada pela resistência em série (Pot Rs) e valor da corrente no diodo Zener (Iz), potência dissipada pela resistência de carga (Pot RL) e tensão de saída (V out).

Esboco da GUI: https://user-images.githubusercontent.com/37374766/40452603-c98bbb98-5eb8-11e8-9f78-f56a51c19e08.png

Documentação do Projeto (Doxygen): https://github.com/ProgramacaoEE2018/yurigama_reguladortensao/files/2092162/Documentacao_Projeto_Regulador_tensao_zener.pdf

Instruções de Compilação:
