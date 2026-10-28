def realizar_venda(nome_produto, preco_unitario, quantidade):
    valor_total = preco_unitario * quantidade
    print("\n--- Detalhes da Venda ---")
    print(f"Nome do Produto: {nome_produto}")
    print(f"Preço Unitário: R$ {preco_unitario:.2f}")
    print(f"Quantidade Comprada: {quantidade}")
    print(f"Valor Total da Venda: R$ {valor_total:.2f}")

def calcular_desconto(valor_total, percentual_desconto):
    valor_desconto = (valor_total * percentual_desconto) / 100
    valor_final = valor_total - valor_desconto
    print("\n--- Cálculo de Desconto ---")
    print(f"Valor Original da Compra: R$ {valor_total:.2f}")
    print(f"Percentual de Desconto: {percentual_desconto}%")
    print(f"Valor do Desconto: R$ {valor_desconto:.2f}")
    print(f"Valor Final a Pagar: R$ {valor_final:.2f}")

def calcular_troco(valor_total, valor_pago):
    print("\n--- Cálculo de Troco ---")
    if valor_pago > valor_total:
        troco = valor_pago - valor_total
        print(f"Troco a ser devolvido: R$ {troco:.2f}")
    elif valor_pago == valor_total:
        print("Não há troco.")
    else:
        print("Valor pago é insuficiente para quitar a compra.")

def menu():
    print("\n========== SISTEMA DE VENDAS ==========")
    print("1 - Realizar venda")
    print("2 - Calcular desconto")
    print("3 - Calcular troco")
    print("4 - Sair")

def cabecalho():
    print("=" * 68)
    print("                        SISTEMA DE VENDAS")
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
        produto = input("Digite o nome do produto: ")
        preco = float(input("Digite o preço unitário: "))
        qtd = int(input("Digite a quantidade comprada: "))
        realizar_venda(produto, preco, qtd)
    elif opcao == 2:
        valor = float(input("Digite o valor total da compra: "))
        desconto = float(input("Digite o percentual de desconto (%): "))
        calcular_desconto(valor, desconto)
    elif opcao == 3:
        valor_compra = float(input("Digite o valor total da compra: "))
        valor_pago = float(input("Digite o valor pago pelo cliente: "))
        calcular_troco(valor_compra, valor_pago)
    elif opcao == 4:
        print("Programa encerrado com sucesso. Até logo!")
    else:
        print("Opção inválida! Por favor, escolha uma opção existente no menu.")
