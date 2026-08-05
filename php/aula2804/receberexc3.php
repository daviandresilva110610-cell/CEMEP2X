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
            <td align="center"><h1>EXERCÍCIO 3</h1></td>
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
                $p = $_POST["p"];
                $s = $_POST["s"];
                $b = $_POST["b"];
                $calp = 0;
                $cals = 0;
                $calb = 0;


                if($p==1){
                    $calp = $calp+180;
                    print("Prato: Vegetariano<br>");
                }
                    elseif($p==2){
                        $calp = $calp+230;
                        print("Prato: Peixe<br>");

                    }
                    elseif($p==3){
                        $calp = $calp+250;
                        print("Prato: Frango<br>");
                    }
                    elseif($p==4){
                        $calp = $calp+350;
                        print("Prato: Carne<br>");
                    }


                if($s==1){
                    $cals = $cals+75;
                    print("Sobremesa: Abacaxi<br>");
                }
                    elseif($s==2){
                        $cals = $cals+110;
                        print("Sobremesa: Sorvete diet<br>");
                    }
                    elseif($s==3){
                        $cals = $cals+170;
                        print("Sobremesa: Mousse diet<br>");
                    }
                    elseif($s==4){
                        $cals = $cals+200;
                        print("Sobremesa: Mousse de chocolate<br>");
                    }


                if($b==1){
                    $calb=$calb+20;
                    print("Bebida: Chá<br>");
                }
                    elseif($b==2){
                        $calb=$calb+70;
                        print("Bebida: Chá<br>");
                    }
                    elseif($b==3){
                        $calb=$calb+100;
                        print("Bebida: Suco de Laranja<br>");
                    }
                    elseif($b==4){
                        $calb=$calb+65;
                        print("Bebida: Refrigerante<br>");
                    }

                    $tc = $calp+$calb+$cals;

                    print("Total de calorias: $tc")




                ?>
            </td>   
        </tr>
        <tr>
             <td align="center"><h2>DESENVOLVIDO POR DAVI</h2></td>
        </tr>

    </table>
</body>
</html>