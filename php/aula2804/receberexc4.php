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
            <td align="center"><h1>EXERCÍCIO 4</h1></td>
        </tr>

        <tr>
            <td align="center"><h2>Paulínia, DS-28/04/2026</h2></td>
        </tr>

        <tr>
            <td align="center"><h2></h2></td>
        </tr>

        <tr>
            <td>
                <?php

                $n = $_POST["n"];
                $c = $_POST["c"];
                $q = $_POST["q"];

                switch($c)
                {
                    case 100:
                        $v = $q*10;
                        $t = $v*0.10;
                        $vt = $t+$v;
                        print("Cliente: $n.");
                        print("<br>Valor a pagar: $v");
                        print("<br>Taxa de serviço: $t");
                        print("<br>Valor a pagar com taxa: $vt");
                        break;

                        
                    case 101:
                        $v = $q*12;
                        $t = $v*0.10;
                        $vt = $t+$v;
                        print("Cliente: $n");
                        print("<br>Valor a pagar: $v");
                        print("<br>Taxa de serviço: $t");
                        print("<br>Valor a pagar com taxa: $vt");
                        break;
    

                    case 102:
                        $v = $q*14;
                        $t = $v*0.10;
                        $vt = $t+$v;
                        print("Cliente: $n.");
                        print("<br>Valor a pagar: $v");
                        print("<br>Taxa de serviço: $t");
                        print("<br>Valor a pagar com taxa: $vt");
                        break;
    
                        
                    case 103:
                        $v = $q*15.50;
                        $t = $v*0.10;
                        $vt = $t+$v;
                        print("Cliente: $n.");
                        print("<br>Valor a pagar: $v");
                        print("<br>Taxa de serviço: $t");
                        print("<br>Valor a pagar com taxa: $vt");
                        break;
                    case 104:
                        $v = $q*17.80;
                        $t = $v*0.10;
                        $vt = $t+$v;
                        print("Cliente: $n.");
                        print("<br>Valor a pagar: $v");
                        print("<br>Taxa de serviço: $t");
                        print("<br>Valor a pagar com taxa: $vt");
                        break;
                    case 105:
                        $v = $q*5;
                        $t = $v*0.10;
                        $vt = $t+$v;
                        print("Cliente: $n.");
                        print("<br>Valor a pagar: $v");
                        print("<br>Taxa de serviço: $t");
                        print("<br>Valor a pagar com taxa: $vt");
                        break;
                    
                    default:
                        print("Código inválido!!!");
                }

                ?>
            </td>   
        </tr>
        <tr>
             <td align="center"><h2>DESENVOLVIDO POR DAVI</h2></td>
        </tr>

    </table>
</body>
</html>