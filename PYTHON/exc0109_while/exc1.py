"""1. Foi feita uma pesquisa entre os habitantes de uma
região para coletar os seguintes dados: sexo (0 -
feminino, 1 - masculino), idade e altura. Faça um
programa que leia as informações coletadas e mostre as
seguintes informações: (use o comando while) . Utilizar
mensagem para iniciar e continuar o programa. 
a) média da idade do grupo;
b) A maior e a menor idade do grupo
c) média da altura das mulheres;
d) média da idade dos homens;
e) percentual de pessoas com idade entre 35 e 60
anos (inclusive)."""

print("="*60)
print("EXERCÍCIO 1".center(60))
print("="*60)

soma_idades = 0
total_pessoas = 0
maior_idade = 0
menor_idade = 99999

soma_altura_mulheres = 0
total_mulheres = 0

soma_idade_homens = 0
total_homens = 0

pessoas_35_a_60 = 0


while True:

    print("--- Sistema de Pesquisa de Habitantes ---")
    continuar = input("Deseja fazer o registro de dados? [S]Sim [N]Não): ").upper()

    if(continuar == "N"):
        break
    
    else:
    
        sexo = int(input("Digite seu sexo [0]Feminino [1]Masculino:"))

        idade = int(input("Digite sua idade:"))

        altura = float(input("Digite sua ltura"))


        soma_idades += idade
        total_pessoas += 1

        if idade > maior_idade:
            maior_idade = idade
        
        if idade < menor_idade:
            menor_idade = idade
            
        if sexo == 0:
            soma_altura_mulheres += altura
            total_mulheres += 1
            
        elif sexo == 1:
            soma_idade_homens += idade
            total_homens += 1
              
        if 35 <= idade <= 60:
            pessoas_35_a_60 += 1
            
        print("-" * 30)

        
print("\n" + "=" * 45)
print("RESULTADOS DA PESQUISA")
print("=" * 45)

if total_pessoas > 0:
    
    media_idade_grupo = soma_idades / total_pessoas
    print("Média da idade do grupo: {media_idade_grupo:.2f} anos")
    
    print("Maior idade: {maior_idade} | Menor idade: {menor_idade}")
    
    if total_mulheres > 0:
        media_altura_mulheres = soma_altura_mulheres / total_mulheres
        print("Média da altura das mulheres: {media_altura_mulheres:.2f} m")
    else:
        print("Média da altura das mulheres: Nenhuma mulher registrada.")
        
    if total_homens > 0:
        media_idade_homens = soma_idade_homens / total_homens
        print("Média da idade dos homens: {media_idade_homens:.2f} anos")
    else:
        print("Média da idade dos homens: Nenhum homem registrado.")
        
    percentual_35_60 = (pessoas_35_a_60 / total_pessoas) * 100
    print("Percentual de pessoas com idade entre 35 e 60 anos: {percentual_35_60:.2f}%")
else:
    print("Nenhum dado foi inserido na pesquisa.")


print("="*60)
print("DESENVOLVIDO POR DAVI 2°X".center(60))
print("="*60)




