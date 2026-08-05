"""faça um programa que receba a média de um aluno e verifique se ele
foi aprovado, recuperação, reprovado ou foi digitado uma média inválida"""

media=float(input("Digite a média do aluno:"))

if media>=6 and media<=10:
    print("ALUNO APROVADO")
elif media>=4 and media<6:
    print("ALUNO DE RECUPERAÇÃO")
elif media>4:
    print("ALUNO REPROVADO")
else:
    print("MÉDIA INVÁLIDA")

print("Fim do progrma")
