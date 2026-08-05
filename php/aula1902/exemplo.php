<?php

//entrada
$produto ='caderno';
$valor='20';

//processamento
$quantidade=10;
$total=$quantidade*20;
$desconto=$total-($total*0.10);
$juros=$total+($total*0.10);

//saída
print("O nome do produto é: $produto");
print("<br>O valor do produto é: $valor");
print("<br>A quantidade do produto é: $quantidade ");
print("<br>O total a pagar do produto é: $total ");
print("<br>O total com desconto do produto é: $desconto ");
print("<br>O total com juros do produto é: $juros ");


?>