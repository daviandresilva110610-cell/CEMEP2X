"""2. Peça ao usuário:
 Nome completo
 E-mail
Em seguida:
 Remova espaços desnecessários (inicio e fim).
 Formate o nome usando colocando todas as primeiras letras de cada palavra
em maiúsculo.
 Converta o e-mail para minúsculas.
 Exiba uma mensagem de boas-vindas centralizada com center()."""

print("="*60)
print("EXERCÍCIO 2".center(60))
print("="*60)

n = input("Digite o nome completo: ").strip().title()
e = input("E-mail: ").strip().lower()

print("\nNome: ", n)
print("E-mail: ", e)

print("\n")
print(f"Bem-vindo {n}".center(40, "*"))


print("="*60)
print("DESENVOLVIDO POR DAVI 2°X".center(60))
print("="*60)
