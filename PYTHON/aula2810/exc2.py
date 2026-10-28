def cadastrar_funcionario(nome, cargo, salario):
    print("\n--- Dados do Funcionário Cadastrado ---")
    print(f"Nome: {nome}")
    print(f"Cargo: {cargo}")
    print(f"Salário: R$ {salario:.2f}")

def calcular_aumento(nome, salario_atual, percentual_aumento):
    valor_aumento = salario_atual * (percentual_aumento / 100)
    novo_salario = salario_atual + valor_aumento
    print("\n--- Cálculo de Aumento Salarial ---")
    print(f"Funcionário: {nome}")
    print(f"Salário Atual: R$ {salario_atual:.2f}")
    print(f"Percentual de Aumento: {percentual_aumento}%")
    print(f"Valor do Aumento: R$ {valor_aumento:.2f}")
    print(f"Novo Salário: R$ {novo_salario:.2f}")

def calcular_desconto(salario, percentual_desconto):
    valor_desconto = salario * (percentual_desconto / 100)
    salario_liquido = salario - valor_desconto
    print("\n--- Cálculo de Desconto Salarial ---")
    print(f"Salário Bruto: R$ {salario:.2f}")
    print(f"Percentual de Desconto: {percentual_desconto}%")
    print(f"Valor do Desconto: R$ {valor_desconto:.2f}")
    print(f"Salário após Desconto: R$ {salario_liquido:.2f}")

def menu():
    print("\n========== SISTEMA DE FUNCIONÁRIOS ==========")
    print("1 - Cadastrar funcionário")
    print("2 - Calcular aumento salarial")
    print("3 - Calcular desconto salarial")
    print("4 - Sair")

def cabecalho():
    print("=" * 68)
    print("                    SISTEMA GERENCIAMENTO DE FUNCIONÁRIOS")
    print("=" * 68)
    print("                        DESENVOLVIDO POR DAVI 2X")
    print("=" * 68)

# Programa Principal
cabecalho()

opcao = 0
while opcao != 4:
    menu()
    opcao = int(input("Escolha uma opção: "))

    if opcao == 1:
        nome = input("Digite o nome do funcionário: ")
        cargo = input("Digite o cargo do funcionário: ")
        salario = float(input("Digite o salário do funcionário: "))
        cadastrar_funcionario(nome, cargo, salario)
    elif opcao == 2:
        nome = input("Digite o nome do funcionário: ")
        salario_atual = float(input("Digite o salário atual: "))
        percentual = float(input("Digite o percentual de aumento (%): "))
        calcular_aumento(nome, salario_atual, percentual)
    elif opcao == 3:
        salario = float(input("Digite o salário do funcionário: "))
        percentual = float(input("Digite o percentual de desconto (%): "))
        calcular_desconto(salario, percentual)
    elif opcao == 4:
        print("Programa encerrado com sucesso. Até logo!")
    else:
        print("Opção escolhida não existe. Tente novamente!")
