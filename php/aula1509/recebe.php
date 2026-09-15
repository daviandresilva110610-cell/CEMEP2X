<<?php 

include 'func.php';

$nome = $_POST['nome'];
$preco = $_POST['preco'];
$quantidade = $_POST['quantidade'];

$valorTotal = calculartotal($nome, $preco, $quantidade);

if ($valorTotal >= 500.00) {
    $percentualDesconto = 15;
} elseif ($valorTotal >= 200.00) {
    $percentualDesconto = 10;
} else {
    $percentualDesconto = 0;
}

    $valorDesconto = ($valorTotal * ($percentualDesconto/100));
    $valorFinal = $valorTotal - $valorDesconto;

?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Resultado</title>

</head>
<body>

<table border="1" align="center" width="49%">
    <tr class="header">
        <th>
            Resultado<br>
            <?php data(); ?>
        </th>
    </tr>
    <tr>
        <td>          
            <?php
            print("Produto: $nome<br>");
            print("Quantidade: $quantidade<br>");
            print("Preço Unitário: $preco<br>");
            print("Subtotal: $valorTotal<br>");
            print("Desconto: $valorDesconto<br>");
            print("Valor final: $valorFinal<br>");
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