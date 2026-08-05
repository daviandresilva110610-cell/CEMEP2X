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
            <td align="center"><h2>Paulínia, DS-28/04/2026</h2></td>
        </tr>

        <tr>
            <td align="center"><h2></h2></td>
        </tr>

        <tr>
            <td>
                <?php

                $o = $_POST["o"];
                $p = $_POST["p"];
                $s = $_POST["s"];

                switch($o)
                {
                    case 1:
                        $r = $p+$s;
                        print("Valores digitados:$p e $s.");
                        print("<br>A operação escolhida foi soma.");
                        print("<br>Resultado foi: $r");
                        break;

                        
                    case 2:
                        $r = $p-$s;
                        print("<br>Valores digitados:$p,$s.");
                        print("<br>A operação escolhida foi subtração.");
                        print("<br>Resultado foi: $r");
                        break;

                    case 3:
                        $r = $p/$s;
                        print("<br>Valores digitados:$p,$s.");
                        print("<br> A operação escolhida foi divisão.");
                        print("<br> Resultado foi: $r");
                        break;
                        
                    case 4:
                        $r = $p*$s;
                        print("<br>Valores digitados:$p,$s.");
                        print("<br>A operação escolhida foi multiplicação.");
                        print("<br>Resultado foi: $r");
                        break;
                    
                    default:
                        print("Comando inválido!!!");
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