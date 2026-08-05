<!--1. O custo ao consumidor de um carro novo é a soma do custo de fábrica com
a porcentagem do distribuidor e dos impostos (aplicados ao custo de
fábrica). Supondo que a porcentagem do distribuidor seja de 28% e os
impostos de 45%, escrever um programa que leia o custo de fábrica de um
carro e exiba: o custo ao consumidor e o valor dos impostos.--> 
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
     <table border="1" align="center" width="50%">
        <tr><!--PRIMEIRA LINHA-->
            <td align="center"> <h1>EXERCÍCIO 1</h1> </td>
        </tr>
        <tr><!--SEGUNDA LINHA-->
            <td align="center"> <h2> AULA DS - 03/03/2026 </h2> </td>
        </tr>
        <tr><
            <td> <h2>
                <?php

                    $custf=20000;
                    $d=$custf*0.28;
                    $ip=$custf*0.45;
                    $custc=$custf+$d+$ip;

                    print("Custo da fabrica:$custf <br>");
                    print("Valor porcentagem Distribuidor :$d<br>");
                    print("Valor porcentagem Imposto:$ip<br>");
                    print("Custo ao Consumidor:$custc");
                ?>

                </h2> 
            </td>
        </tr>
        <tr>
            <td align="center"> <h2> Desenvolvido por DAVI</h2>
        </tr>
    


</body>
</html>