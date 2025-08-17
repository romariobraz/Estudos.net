#include <stdio.h>
#include <stdlib.h>
int main() {
	//Defino as vari�veis e ponteiros.
	int numero = 10;
	int* ponteiroInt = &numero; //Ponteiro para inteiro.

	//Exibindo valor e o endere�o
	printf("Valor do numero: %d\n", numero);
	printf("Endereco do numero: %p\n", ponteiroInt);
	printf("Valor apontado do ponteiro: %d\n", *ponteiroInt);
	//Alterando o valor da vari�vel atrav�s do ponteiro.
	*ponteiroInt = 15;
	printf("Novo valor do numero: %d\n", numero);

	//Caracteristicas especificas dos ponteiros
	//Aloca��o dinamica
	int* ponteirodinamico;
	ponteirodinamico = (int*)malloc(sizeof(int));
	//valida��o da aloca��o
	if (ponteirodinamico == NULL) {
		printf("Erro ao alocar na mem�ria!\n");
		return 1; //sa� do programa se a aloca��o falhar.
	}

	//Inicializando o valor alocado dinamicamente
	*ponteirodinamico = 50;
	printf("Valor armazenado na memoria alocado dinamicamente: %d\n", *ponteirodinamico);

	//Uso correto dos ponteiros
	//Exemplo de uso seguro com verifica��o e libera��o
	free(ponteirodinamico); //libera
	ponteirodinamico = NULL; //invalida o ponteiro

	//testando ap�s libera��o
	if (ponteirodinamico == NULL) {
		printf("Memoria liberada e ponteiro invalidado");
	}
	return 0;

}