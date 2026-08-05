print("="*65)
print("PROGRAMA - FATIAMENTO NOME - 06/05/2026")
print("="*65)


nome = input("Digite seu nome: ")
cd = input("Digite sua cidade de nascimento:")

#item a - verificar o nome da cidade com o nome Santo
inicio = cd[:5]
if inicio == "Santo" or inicio == "SANTO" or inicio == "santo":
    print("A cidade começa com a palavra Santo")
    print("Nome da cidade:",cd)
else:
    print("A cidade não começa com a palavra Santo")
    print("Nome da cidade:",cd)

#item b - verificar se  nome da pessoa termina com Silva
fim = nome[-5:]
if fim == "Silva" or fim == "SILVA" or fim == "silva":
    print("O nome informado tem o sobre nome Silva")
    print("O nome é:",nome)
else:
    print("O nome informado não tem o sobrenome Silva")
    print("O nome é:",nome)
