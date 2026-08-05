"""Faça um programa que receba a média de um aluno e verifique se ele
foi aprovado ou reprovado."""
#entrada
media=float(input("Digite a média do aluno:"))

#processamento
if media>=6 and media<=10:
    print("Aluno APROVADO")
else:
    print("Aluno REPROVADO")

print("Fim do programa")
