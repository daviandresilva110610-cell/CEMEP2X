"""2. Foi realizada uma pesquisa de algumas características físicas da
população de uma certa região. Foram entrevistadas um grupo
pessoas e coletados os seguintes dados:  
a- sexo: M (masculino) e F (feminino)
b- cor dos olhos: A (azuis), V (verdes) e C (castanhos)
c- cor dos cabelos: L (louros), C (castanhos) e P (pretos)
d- idade
Deseja-se saber:
o Quantidade de pessoas do sexo feminino
o Quantidade de pessoas do sexo masculino
o A maior idade do grupo
o A média da idade dos homens
o A media da idade das mulhres
o A quantidade de indivíduos do sexo feminino, cuja idade
está entre 18 e 35 anos e que tenham olhos verdes e
cabelos louros.
o Quantidade de pessoas com cabelos castanhos e olhos
castanhos

o Porcentagem de homens com cabelos castanhos e olhos
azuis sobre o total de homens
o Porcentagem de mulheres com cabelos pretos e olhos
verdes sobre o total de mulheres
(use o comando while) . Utilizar while True"""





total_feminino = 0

total_masculino = 0

maior_idade = 0

soma_idade_homens = 0

soma_idade_mulheres = 0

mulheres_especificas = 0

cabelo_c_olho_c = 0

homens_castanho_azul = 0

mulheres_preto_verde = 0


print("="*60)
print("EXERCÍCIO 2".center(60))
print("="*60)


while True:

    print("\n--- Cadastro de Entrevistado ---")

    continuar = input("\nDeseja cadastrar uma pessoa? (S/N): ").upper()

    if continuar == 'N':

        break

    else:

    

        sexo = input("Sexo (M - Masculino / F - Feminino): ").upper()

        olhos = input("Cor dos olhos (A - Azuis / V - Verdes / C - Castanhos): ").upper()

        cabelos = input("Cor dos cabelos (L - Louros / C - Castanhos / P - Pretos): ").upper()

        entrada_idade = input("Idade: ")

        idade = int(entrada_idade)


        if idade > maior_idade:

            maior_idade = idade



        if sexo == 'M':

            total_masculino += 1

            soma_idade_homens += idade

            if cabelos == 'C' and olhos == 'A':

                homens_castanho_azul += 1


        else:

            total_feminino += 1

            soma_idade_mulheres += idade

            if 18 <= idade <= 35 and olhos == 'V' and cabelos == 'L':

                mulheres_especificas += 1



            if cabelos == 'P' and olhos == 'V':

                mulheres_preto_verde += 1




        if cabelos == 'C' and olhos == 'C':

            cabelo_c_olho_c += 1



total_pessoas = total_masculino + total_feminino

if total_pessoas > 0:

    media_idade_grupo = (soma_idade_homens + soma_idade_mulheres) / total_pessoas

    if total_masculino > 0:

        media_idade_homens = soma_idade_homens / total_masculino

        pct_homens_castanho_azul = (homens_castanho_azul / total_masculino) * 100

    else:

        media_idade_homens = 0.0

        pct_homens_castanho_azul = 0.0


    if total_feminino > 0:

        media_idade_mulheres = soma_idade_mulheres / total_feminino

        pct_mulheres_preto_verde = (mulheres_preto_verde / total_feminino) * 100

    else:

        media_idade_mulheres = 0.0

        pct_mulheres_preto_verde = 0.0


    print("\n" + "=" * 50)

    print("RESULTADOS DA PESQUISA")

    print("=" * 50)

    print("Quantidade de pessoas do sexo feminino:", total_feminino)

    print("Quantidade de pessoas do sexo masculino:", total_masculino)

    print("A maior idade do grupo:", maior_idade)

    print("A média da idade de todo o grupo:", media_idade_grupo)

    print("A média da idade dos homens:", media_idade_homens)

    print("A média da idade das mulheres:", media_idade_mulheres)

    print("Quantidade de mulheres entre 18 e 35 anos com olhos verdes e cabelos louros:", mulheres_especificas)

    print("Quantidade de pessoas com cabelos castanhos e olhos castanhos:", cabelo_c_olho_c)

    print("Porcentagem de homens com cabelos castanhos e olhos azuis (sobre o total de homens):", pct_homens_castanho_azul)

    print("Porcentagem de mulheres com cabelos pretos e olhos verdes (sobre o total de mulheres):", pct_mulheres_preto_verde)

else:

    print("\nNenhum dado foi registrado.")



print("="*60)
print("DESENVOLVIDO POR DAVI 2°X".center(60))
print("="*60)
