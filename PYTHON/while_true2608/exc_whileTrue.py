"""Faça umj programa que receba a idade e o estado civil
(C - casado, S - solteiro, V - viuvo e eD - desquitado/separado)
de um grupo de pessoas. Calcule:

Quantidade de pessoas

Quantidade de pessoas solteiras

A média das idades das pessoas viúvas

A porcentagem de pessoas desquitadas/separadas dentre as outras

Inserir uma mensagem ao usuário
se ele deseja continuar ou finalizar o programa - while True"""

total_pessoas = 0
total_solteiros = 0
soma_idade_viuvos = 0
total_viuvos = 0
total_desquitados = 0

while True:

    idade = int(input("Digite a idade da pessoa: "))
    
    print("Estado Civil:")
    print("[C] Casado")
    print("[S] Solteiro")
    print("[V] Viúvo")
    print("[D] Desquitado/Separado")

    estado_civil = input("Digite o estado civil (C/S/V/D): ").upper()


    if estado_civil == 'S':
        total_solteiros += 1
        total_pessoas += 1
                
    elif estado_civil == 'V':
        soma_idade_viuvos += idade
        total_pessoas += 1
        total_viuvos += 1
        
    elif estado_civil == 'D':
        total_desquitados += 1
        total_pessoas += 1
                
    else:
        print("Estado civil inválido! Tente novamente.")
            
    continuar = input("\nDeseja cadastrar outra pessoa? (S - Sim / N - Não): ").upper()
    if continuar == 'N':
        break
print("-" * 30)


print("\n" + "=" * 30)
print("RESULTADOS FINAIS:")
print("=" * 30)


print(f"Total de pessoas cadastradas: {total_pessoas}")


print(f"Quantidade de pessoas solteiras: {total_solteiros}")


if total_viuvos > 0:
    media_viuvos = soma_idade_viuvos / total_viuvos
    print(f"Média de idade das pessoas viúvas:",media_viuvos," anos")


if total_pessoas > 0:
    porcentagem_desquitados = (total_desquitados / total_pessoas) * 100
    print(f"Porcentagem de pessoas desquitadas/separadas:",porcentagem_desquitados,"%")
