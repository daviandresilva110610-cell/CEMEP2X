"""O método index() funciona como o método find(), mas há uma única diferença
entre esses métodos. Ambos os métodos retornam a posição do texto de busca
se a string existir na string principal. Se o texto de busca não existir na string
principal, o método find() retorna -1, mas o método index() gera um
ValueError."""

#exemplo - procurar a posição de uma letra informada pelo usuário

texto = input("Digite um texto:")
letra = input("Digite uma letra:")

#verifica se a letra existe na string
if letra in texto:
    #o in é utilizado para vrtificar se há um elemento em uma sequencia
    posicao = texto.index(letra)
    print("A letra está na posição ",posicao)
else:
    print("A letra não foi encontrada")
