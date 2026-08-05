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
            <td align="center"><h1>EXERCÍCIO 2</h1></td>
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

                $c = $_POST["n"];
                $i = $_POST["i"];
                $g = $_POST["g"];

                
                if($i>=18 && $i<=24 && $g=='B'){
                    print("<br>Cliente: $c");
                    print("<br>Idade: $i");
                    print("<br>Grupo de risco: $g");
                    print("<br>Código do grupo de risco: 7");
                }
                
                elseif($i>=25 && $i<=40 && $g=='B'){
                    print("<br>Cliente: $c");
                    print("<br>Idade: $i");
                    print("<br>Grupo de risco: $g");
                    print("<br>Código do grupo de risco: 4");
                }

                
                elseif($i>=41 && $i<=70 && $g=='B'){
                    print("<br>Cliente: $c");
                    print("<br>Idade: $i");
                    print("<br>Grupo de risco: $g");
                    print("<br>Código do grupo de risco: 1");
                }
                
                elseif($i>=18 && $i<=24 && $g=='M'){
                    print("<br>Cliente: $c");
                    print("<br>Idade: $i");
                    print("<br>Grupo de risco: $g");
                    print("<br>Código do grupo de risco: 8");
                }
                
                elseif($i>=25 && $i<=40 && $g=='M'){
                    print("<br>Cliente: $c");
                    print("<br>Idade: $i");
                    print("<br>Grupo de risco: $g");
                    print("<br>Código do grupo de risco: 5");
                }
                
                elseif($i>=41 && $i<=70 && $g=='M'){
                    print("<br>Cliente: $c");
                    print("<br>Idade: $i");
                    print("<br>Grupo de risco: $g");
                    print("<br>Código do grupo de risco: 2");
                }
                elseif($i>=18 && $i<=24 && $g=='A'){
                    print("<br>Cliente: $c");
                    print("<br>Idade: $i");
                    print("<br>Grupo de risco: $g");
                    print("<br>Código do grupo de risco: 9");
                }
                elseif($i>=25 && $i<=40 && $g=='A'){
                    print("<br>Cliente: $c");
                    print("<br>Idade: $i");
                    print("<br>Grupo de risco: $g");
                    print("<br>Código do grupo de risco: 6");
                }
                elseif($i>=41 && $i<=70 && $g=='A'){
                    print("<br>Cliente: $c");
                    print("<br>Idade: $i");
                    print("<br>Grupo de risco: $g");
                    print("<br>Código do grupo de risco: 3");
                }
                else
                {
                    print("<br> ERRO");
                    print("<br> Um dos dados não se encaixa no gráfico");
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