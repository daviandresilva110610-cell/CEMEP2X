#exemplo utilizando find
"""Faça um programa que receba uma frase e verifique se existe a palavra "Python" nela"""

frase = input("Digite uma frase:").title()
posicao = frase.find("Python")

if posicao == -1:
    print("A palavra Python não foi encontrada")
else:
    print("A palavra Python foi encontrada")
    print("E começa na posição ", posicao)

ultimaps = frase.rfind("Python")

if ultimaps == -1:
    print("A palavra Python não foi encontrada")
else:
    print("A palavra Python foi encontrada")
    print("E começa na posição ", ultimaps)
