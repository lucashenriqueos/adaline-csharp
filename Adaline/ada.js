var fontes = [
			[ //fonte 1
				[], [], [], [], [], [], []  //Letras, cada array 1 letra com 64 posições
			],
			[ //fonte 2
				[], [], [], [], [], [], []  //Letras
			],
			[ //fonte 3
				[], [], [], [], [], [], []  //letras
			]
		],

		//A saida esperada para cada letra é um vetor de 7 posições descrevendo a letra que deve identificar;
		// Ex: Letra A = [-1, 1, 1, 1, 1, 1, 1]
	saidas = [ // Saida esperada de cada letra
		[ //Letra
			[-1], [1], [1], [1], [1], [1], [1] // Saida esperada para letra
		],
		[ //Letra
			[], [], [], [], [], [], [] // Saida esperada para letra
		],
		[ //Letra
			[], [], [], [], [], [], []  // Saida esperada para letra
		],
		[ //Letra
			[], [], [], [], [], [], [] // Saida esperada para letra
		],
		[ //Letra
			[], [], [], [], [], [], []  // Saida esperada para letra
		],
		[ //Letra
			[], [], [], [], [], [], [] // Saida esperada para letra
		],
		[ //Letra
			[], [], [], [], [], [], [] // Saida esperada para letra
		],
	],
	pesos = [
			[], //Pesos esperados para cada letra, cada letra tem 64 pesos, devido aos neuronios
			[],
			[],
			[],
			[],
			[],
			[]
		],
	txAp = 1, // Taxa de Aprendizado
	erro = 0; // Erro da rede

function preparaPesos () {
	for(var i = 0; i < 7; i++){
	    for(var j = 0; j < 64; j++){
	        pesos[i][j] = 0;
	    }
	}
}

function peso(peso, entrada) {
	delta = erro * entrada * txAp
	return peso + delta;
}

function calcErro (entrada, peso, saidaEsperada) {
	somatorio = entrada * peso;
	return saidaEsperada - somatorio;
}

function go () {
	preparaPesos(); //Rever a ordem de treinamento, primeiro verificar as saidas;
	fontes.forEach(function(letrinhas, index){ // Para cada fonte, 7 letrinhas
		letrinhas.forEach(function(neuronio, i){ // Para cada letra, 64 neuronios
			erro = calcErro(item, pesos[index][i], saidas[index][i]);
			pesos[index] = peso(pesos[index], item);
		})
	})
}

function teste (fonteTeste) {
	fonteTeste.forEach(function(letra, index)){
		letra.forEach(function(neuronio, i){

		})
	})
}