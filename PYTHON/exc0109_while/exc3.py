"""3. Uma loja utiliza os seguintes códigos para as transações de cada
dia:
V – para compras à vista
P – para compras à prazo
É dada uma lista de transações contendo o valor de cada
compra e o respectivo código da transação. Faça um programa
que calcule e exiba:
 Valor total das compras à vista
 Valor total das compras à prazo
 Valor total das compras efetuadas
 Valor a receber pelas compras a prazo, isto é, primeira
parcela, sabendo que estas serão pagas em três vezes
(use o comando while) . Utilizar while True"""



total_vista = 0.0

total_prazo = 0.0


while True:


    print("="*60)
    print("EXERCÍCIO 1".center(60))
    print("="*60)

    

    print("\n--- Cadastro de Transação ---")

    
    continuar = input("\nDeseja uma transação? (S/N): ").upper()

    if continuar == 'N':

        break
    
    else:

        codigo = input("Código da transação (V - À vista / P - À prazo): ").upper()

        valor = float(input("Valor da compra: "))


        if codigo == 'V':

            total_vista += valor

        else:

            total_prazo += valor



total_compras = total_vista + total_prazo

primeira_parcela = total_prazo / 3.0


print("\n" + "=" * 50)

print("RESULTADOS DAS TRANSAÇÕES")

print("=" * 50)

print("Valor total das compras à vista:", total_vista)

print("Valor total das compras à prazo:", total_prazo)

print("Valor total das compras efetuadas:", total_compras)

print("Valor a receber pelas compras a prazo (1ª parcela de 3x):", primeira_parcela)


print("="*60)
print("DESENVOLVIDO POR DAVI 2°X".center(60))
print("="*60)
