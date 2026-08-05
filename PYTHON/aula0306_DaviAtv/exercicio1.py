"""1. Peça ao usuário uma palavra e exiba:
 Os três primeiros caracteres.
 Os três últimos caracteres.
 A palavra invertida."""

print("="*60)
print("EXERCÍCIO 1".center(60))
print("="*60)

plvr = input("Digite uma palavra: ")
plvr1 = plvr[:3]
print (plvr1)

plvr2 = plvr[-3:]
print (plvr2)

plvr3 = plvr[::-1]
print (plvr3)

print("="*60)
print("DESENVOLVIDO POR DAVI 2°X".center(60))
print("="*60)

