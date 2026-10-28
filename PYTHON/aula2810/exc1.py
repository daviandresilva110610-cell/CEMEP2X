def somar(n1, n2):
    resultado = n1 + n2
    print(f"Resultado da Soma: {resultado}")

def subtrair(n1, n2):
    resultado = n1 - n2
    print(f"Resultado da Subtração: {resultado}")

def multiplicar(n1, n2):
    resultado = n1 * n2
    print(f"Resultado da Multiplicação: {resultado}")

def dividir(n1, n2):
    if n2 != 0:
        resultado = n1 / n2
        print(f"Resultado da Divisão: {resultado}")
    else:
        print("Erro: Não é possível dividir por zero!")

def menu():
    print("\n========== MENU DE OPERAÇÕES ==========")
    print("1 - Somar")
    print("2 - Subtrair")
    print("3 - Multiplicar")
    print("4 - Dividir")
    print("5 - Sair")

def cabecalho():
    print("=" * 68)
    print("                     SISTEMA OPERAÇÕES MATEMÁTICAS")
    print("=" * 68)
    print("                        DESENVOLVIDO POR DAVI 2X")
    print("=" * 68)

# Programa Principal
cabecalho()

opcao = 0
while opcao != 5:
    menu()
    opcao = int(input("Escolha uma opção: "))

    if opcao == 1:
        num1 = float(input("Digite o primeiro número: "))
        num2 = float(input("Digite o segundo número: "))
        somar(num1, num2)
    elif opcao == 2:
        num1 = float(input("Digite o primeiro número: "))
        num2 = float(input("Digite o segundo número: "))
        subtrair(num1, num2)
    elif opcao == 3:
        num1 = float(input("Digite o primeiro número: "))
        num2 = float(input("Digite o segundo número: "))
        multiplicar(num1, num2)
    elif opcao == 4:
        num1 = float(input("Digite o primeiro número: "))
        num2 = float(input("Digite o segundo número: "))
        dividir(num1, num2)
    elif opcao == 5:
        print("Programa encerrado com sucesso. Até logo!")
    else:
        print("Opção inválida! Por favor, escolha uma opção existente no menu.")
