<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lanchonete Divina Refeição</title>
</head>
<body>
    <table border="1" width="60%" align="center">

        <tr>
            <td align="center"><h1>EXERCÍCIO</h1></td>
        </tr>

        <tr>
            <td align="center"><h2>Aula 12/03/2026</h2></td>
        </tr>

        <tr>
            <td align="center"><h2>Pedido Feito🥔☕</h2></td>
        </tr>

        <tr>
            <td>
                <?php
                print("Resumo do Pedido:<br>");
                $nome = $_POST["nome"];
                $lan = $_POST["lanche"];
                $preco= $_POST["preco"];
                $quant = $_POST["quant"];

                $vt = $preco * $quant;

                print("Nome Cliente: $nome <br>");
                print("Nome lanche: $lan <br>");
                print("Preço do Lanche: $preco <br>");
                print("Quantidade comprada: $quant <br>");
                print("Valor total a pagar: $vt <br>");
                ?>
            </td>   
        </tr>
        <tr>
             <td align="center"><h2>DESENVOLVIDO POR DAVI</h2></td>
        </tr>

    </table>
</body>
</html>