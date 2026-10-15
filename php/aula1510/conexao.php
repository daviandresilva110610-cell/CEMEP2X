<?php 
//Local que está rodando o servidor
$local = 'localhost';//Local onde o banco de dados foi criado

//Quem tem acesso ao banco de dados
$usuario = 'root';

//Senha
$senha = '';

//Nome do anco de dados
$banco = 'bd1510x';

//Criar a conexão com banco de dados

$conexao = new mysqli($local, $usuario, $senha, $banco);

?>