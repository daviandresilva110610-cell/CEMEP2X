"""Função input: usada para receber dados do usuário pelo teclado.
Ou seja , enquanto o print() mostra algo, o input()
espera o usuário digitar algo"""
#entrada

nome=input("Digite seu nome:")
idade=input("Digite sua idade:")
peso=input("Digite seu peso:")

#Verificando variáveis

print(type(nome))
print(type(idade))
print(type(peso))


"""Comando input(), sempre vai retornar uma string.
Nesse caso, para retornar dados do tipo inteiro ou float,
é preciso converter o tipo do valor lido."""

nome=input("Digite seu nome:")
idade=int(input("Digite sua idade:"))
peso=float(input("Digite seu peso:"))

#verificando variáveis

print(type(nome))
print(type(idade))
print(type(peso))
