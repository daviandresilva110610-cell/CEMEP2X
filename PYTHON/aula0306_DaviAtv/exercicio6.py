"""6. Faça um programa que receba uma frase e verifique se a string é um
palíndromo (lê-se igual de trás pra frente, desconsiderando espaços e
maiúsculas) . """

print("="*60)
print("EXERCÍCIO 6".center(60))
print("="*60)

frase = input("Digite uma frase: ")

limpa = frase.replace("", "").lower()

if limpa == limpa[::-1]:
    print("É um palíndromo.")
else:
    print("Não é um palíndromo.")
    
print("="*60)
print("DESENVOLVIDO POR DAVI 2°X".center(60))
print("="*60)
