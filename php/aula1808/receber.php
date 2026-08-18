<?php
require_once 'funcoes.php';

function exibir($nome, $n1, $n2) {
    print("Nome: $nome<br><br>");
    print("Nota 1: $n1<br><br>");
    print("Nota 2: $n2<br>");
}

function media($n1, $n2) {
    $media = ($n1 + $n2) / 2;

    if ($media >= 6 && $media <= 10) {
        print("Média: $media<br>");
        print("APROVADO!!!");
    }
    else {
        print("Média: $media<br>");
        print("<br>REPROVADO!!!");
    }
}

$nome  = $_POST["nome"];
$n1 = $_POST["n1"];
$n2 = $_POST["n2"];

?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Cadastro de Aluno</title>

</head>
<body>

<table border="1" align="center" width="50%">
    <tr class="header">
        <th>
            CADASTRO DE ALUNO<br>
            <small><?php data(); ?></small>
        </th>
    </tr>
    <tr>
        <td>          
            <?php
            exibir($nome, $n1, $n2);
            print("<br>");
            media($n1, $n2);
            ?>

            <br>
        </td>
    </tr>
    <tr class="footer">
        <td>Desenvolvido por: Davi Andre &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp  &nbsp &nbsp
            <?php exibirHoraSistema(); ?></td>
    </tr>
</table>

</body>
</html>