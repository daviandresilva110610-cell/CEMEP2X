"""Faça jum programa de cadastro de alunos.
O programa deverá ter:
1.Perguntar quantos alunos serão cadastrados.
2.Para cada aluno, solicitar:
    -nome
    -idade
    -nota
3.Informar se o aluno foi aprovado ou reprovado.
    -Aprovado nota deve ser >=6 e <=10.
4.Ao final mostrar:
    -quantidades de alunos
    -quantidade de aprovados
    -quantidade de reprovados."""

print("="*50)
print("Cadastro de Aluno")
print("="*50)

quantidade = int(input("Quantos alunos serão cadastrados"))

aprovados = 0
reprovados = 0

for i in range(qunatidade):

    nome = input("Nome: ")
    idade = int(input("Idade: "))
    nota = int(input("Nota: "))

    if ota >=6:
        print(nome,"- Aprovado")
        aprovados = aprovados + 1
    else:
        print(nome,"- Reprovado")
        reprovados = reprovados + 1

print()
print("Total de alunos:", quantidade)
print("Alunos reprovados:", aprovados)
print("Alunos reprovados:", reprovados)
        
