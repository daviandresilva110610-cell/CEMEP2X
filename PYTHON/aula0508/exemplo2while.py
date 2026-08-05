"""Faça um programa para cadastrar os nomes dos clientes de uma loja,
inserir no programa uma mensagem para se quer continuar ou não"""

print("="*50)
print("Cadastrar Cliente".center(50))
print("="*50)

resp = input("Deseja uiniciar o cadastro? [S/N]:").upper()

while resp == "S":
    nome = input("Nome do cliente:")
    resp = input("Deseja cadastrar outro? [S/N]:").upper()

print("Fim do Programa")
