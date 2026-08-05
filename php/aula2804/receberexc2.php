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
                <table border="1" align="center" width="60%">

                    <tr>
                        <td align="center"><h4>IMC</h4></td>
                        <td align="center"><h4 >Faixa de risco</h4></td>
                    </tr>

                    <tr>
                        <td align="center">Abaixo de 20</td>
                        <td align="center">Abaixo do peso</td>
                    </tr>

                    <tr>
                        <td align="center">Acima de 20 até 25</td>
                        <td align="center">Normal</td>
                    </tr>
                    
                    <tr>
                        <td align="center">Acima de 25 até 30</td>
                        <td align="center">Excesso de peso</td>
                    </tr>

                    <tr>
                        <td align="center">Acima de 30 até 35</td>
                        <td align="center">Obesidade</td>
                    </tr>
                    <tr>
                        <td align="center">Acima de 35</td>
                        <td align="center">Obesidade MÓRBIDA</td>
                    </tr>

                </table>

            </td>
        </tr>

        <tr>
            <td>
                <?php

                $n = $_POST["n"];
                $p = $_POST["p"];
                $a = $_POST["a"];

                $i = $p/($a*$a);

                
                if($i<20){
                    print("<br>Nome: $n");
                    print("<br>Peso: $p");
                    print("<br>Altura: $a");
                    print("<br>IMC: $i");
                    print("<br>Faixa de risco: Abaixo do peso");
                }
                
                elseif($i>=20 && $i<=25){
                    print("<br>Nome: $n");
                    print("<br>Peso: $p");
                    print("<br>Altura: $a");
                    print("<br>IMC: $i");
                    print("<br>Faixa de risco: Normal");
                }

                
                elseif($i>=25 && $i<=30){

                    print("<br>Nome: $n");
                    print("<br>Peso: $p");
                    print("<br>Altura: $a");
                    print("<br>IMC: $i");
                    print("<br>Faixa de risco: Excesso de peso");
                }
                
                elseif($i>=30 && $i<=35){
                    print("<br>Nome: $n");
                    print("<br>Peso: $p");
                    print("<br>Altura: $a");
                    print("<br>IMC: $i");
                    print("<br>Faixa de risco: Obesidade");
                }
                
                elseif($i>35){
                    print("<br>Nome: $n");
                    print("<br>Peso: $p");
                    print("<br>Altura: $a");
                    print("<br>IMC: $i");
                    print("<br>Faixa de risco: Obesidade mórbida");
                }
                
                else
                    print("Erro");


                ?>
            </td>   
        </tr>
        <tr>
             <td align="center"><h2>DESENVOLVIDO POR DAVI</h2></td>
        </tr>

    </table>
</body>
</html>