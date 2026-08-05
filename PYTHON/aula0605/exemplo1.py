#Ftiaamento de string significa pegar um pedaço dela
frase = "Linguagem de Prpgramação Python"

#Exemplo de fatiamento, armazenando os resultados em uma variável
print("=" * 65)
print("Frase Utilizada no fatiamento:", frase)
print("="*65)
fatia1 = frase[0] #retornado o primeiro caracter da string
print("Exibindo o primeiro caracter:",fatia1) #exibindo L

fatia2 = frase[-1] #retornando o último caracter da string
print("Exibindo o último caracter:", fatia2) #exibindo N

fatia3 = frase[2:5] #fatiando do caracter 2 até 4 (cinco não exibe)
#exibindo os caracteres NGU
print("Exibindo os caracteres das posições 2, 3 e 4:", fatia3)
