<?php 
include "conexao.php";


$descricao = $_POST['desc'];
$valor_compra = $_POST['vc'];
$valor_venda = $_POST['vv'];
$qtd = $_POST['qtd'];


$cadastro = "INSET INTO
produto
Values('','$descricao','$valor_c','$valor_v','$quantidade')";

$querry = mysqli_query($conexao, $cadastro);
header('location:form.php');

?>