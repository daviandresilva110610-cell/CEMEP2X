<?php 

    include 'conexao.php';

    $nome = $_POST['nome'];
    $cpf = $_POST['cpf'];
    $endereco = $_POST['endereco'];
    $cidade = $_POST['cidade'];
    $estado = $_POST['estado'];
    $telefone = $_POST['telefone'];
    $email = $_POST['email'];
    $cargo = $_POST['cargo'];
    $dataAdmissao = $_POST['dataAdmissao'];


    $cadastro = "INSERT INTO
    funcionario
    Values('','$nome','$cpf','$endereco','$cidade', '$estado', '$telefone', '$email', '$cargo', '$dataAdmissao')";

    $querry = mysqli_query($conexao, $cadastro);
    header('location:formfun.php');


?>