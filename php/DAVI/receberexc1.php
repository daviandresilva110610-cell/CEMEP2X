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
            <td align="center"><h1>EXERCÍCIO 1</h1></td>
        </tr>
        <tr>
            <td align="center"><h2>DS-17/03/2026</h2></td>
        </tr>

        <tr>
            <td align="center"><h2></h2></td>
        </tr>

        <tr>
            <td>
                <?php
                $nome = $_POST["nome"];
                $data = $_POST["data"];
                $v1= $_POST["v1"];
                $v2 = $_POST["v2"];
                $v1p = $_POST["v1p"];
                $v2p = $_POST["v2p"];
                $vend = $_POST["vend"];

                $vt = $v1+$v2;
                $vtp = $v1p+$v2p;
                $vd = $vt-($vt*0.15);
                $vjp = $vtp*1.10;

                print("Nome do cliente: $vt <br>");
                print("Data: $vt <br>");
                print("Nome vendedor: $vend <br>");
                print("Valor 1°compra à vista: $v1 <br>");
                print("Valor °compra à vista: $v2 <br>");
                print("Valor 1°compra à prazo: $v1p <br>");
                print("Valor 2°compra à prazo: $v2p <br>");
                print("Total compras à vista: $vt <br>");
                print("Total compras à prazo: $vtp <br>");
                print("Total à vista com 15% de desconto: $vd <br>");
                print("Total à prazo com 10% de juros: $vjp <br>");

                ?>
            </td>   
        </tr>
        <tr>
             <td align="center"><h2>DESENVOLVIDO POR DAVI</h2></td>
        </tr>

    </table>
</body>
</html>