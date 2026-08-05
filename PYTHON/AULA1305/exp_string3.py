#Exemplo1:
#justificando o texto à esquerda em 50 espaços
texto = "Linguagem de Programação"
x = texto.ljust(50)
print(x)

#Exemplo2:
texto = "Linguagem de Programação"
#preenchendo os espaços em branco com o caracter "="
x = texto. ljust(50,"=")
print(x)

#Exemplo3:
#justificando o texto à esquerda em 50 espaços
print("Linguagem de Programação". ljust (50))



#rjust()
O método rjust alinhará a string à direita, usando um caracter especificado (espaço é o padrão) como caracter de preenchimento.
#Exemplo1:
#justificando o texto à direita em 50 espaços
texto = "Linguagem de Programação"
x = texto.rjust(50)
print(x)

#Exemplo2:
texto = "Linguagem de Programação"
#preenchendo os espaços em branco com o caracter "="
x = texto. rjust(50,"=")
print(x)

#Exemplo3:
#justificando o texto à direita em 50 espaços
print("Linguagem de Programação". rjust (50))
