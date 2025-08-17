#include <stdio.h>

//prototipos
float calc_circ(float raio);
int calc_ret(int larg, int alt);

//somar elementos de vetor
int soma_vetor(int vetor[], int tamanho) {
	int soma = 0;
	int i;
	for (i = 0; i < tamanho; i++) {
		soma += vetor[i];
	}
	return soma;
}

int main() {
	//definindo vetor de inteiros
	int lista[] = { 10, 20, 30, 40, 50 };
	int tamanho = sizeof(lista) / sizeof(lista[0]); //calcula o tamanho do vetor

	//chama função para somar os elementos do vetor
	int total = soma_vetor(lista, tamanho);

	//exibir o resultado
	printf("Total da lista de compras: %d\n", total);

	float raio = 5.0;
	int larg = 6;
	int alt = 4;

	//chamando as funções
	printf("Area do circulo: ¨%.2f\n", calc_circ(raio));
	printf("Area do retangulo: %d\n", calc_ret(larg, alt));

	return 0;
}

float calc_circ(float raio) {
	return 3.14159 * raio * raio;
}

int calc_ret(int larg, int alt) {
	return larg * alt;
}