<!--Faça um programa que receba um salario de um funcionário e o nome do mesmo.
Calcule: o salario reajustado + 30% e o valor do imposto de renda a ser pago 5% do salário reajustado.
Exibir: O nome do funcionário, salário, salário reajustado e o valor do imposto de renda-->

<?php

$func="Márcio";
$s=5000;
$sr=$s*1.3;
$ip=$sr*0.05;

print("Nome:$func <br>");
print("Salário:$s<br>");
print("Salário reajustado:$sr<br>");
print("Imposto de renda:$ip");




?>