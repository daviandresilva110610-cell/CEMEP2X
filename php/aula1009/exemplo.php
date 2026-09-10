<?php 

function aluno()
{
    global $nome;
    global $media;
    $nome = "Maria";
    $media = (10 + 6) / 2;
    print("Méida: $media");
    print("<br>Nome: $nome");
}

//Programa principal
aluno();
if($media>+6 and $media<=10)
    print("<br>$nome aluno aprovado");
else
    print("<br>$nome aluno reprovado");

?>