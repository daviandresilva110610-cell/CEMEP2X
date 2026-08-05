<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>

<head>
<meta charset="utf-8">
<title></title>
</head>

    <body>
        <table border="1" align="center" width="500">
            <tr>
                <td align="center" ><h1>Cadastro</h1></td>
            </tr>
            <tr>
                <td align="center" ><h1>Etapa 3 de 3</h1></td>
            </tr>
            <tr>
                <td>
                    <form action="cadastrar.php" method="post" >
                        <input type="hidden" name="nome" value="<?php print $_POST["nome"]; ?>">
                        <input type="hidden" name="email" value="<?php print $_POST["email"]; ?>">
                        <input type="hidden" name="dtnasc" value="<?php print $_POST["dtnasc"]; ?>">
                        <input type="hidden" name="sexo" value="<?php print $_POST["sexo"]; ?>">
                        <input type="hidden" name="prof" value="<?php print $_POST["prof"]; ?>">
                        <input type="hidden" name="fone" value="<?php print $_POST["fone"]; ?>">
                        <input type="hidden" name="ender" value="<?php print $_POST["ender"]; ?>">
                        <input type="hidden" name="cidade" value="<?php print $_POST["cidade"]; ?>">
                        <input type="hidden" name="estado" value="<?php print $_POST["estado"]; ?>">
                        <input type="hidden" name="cep" value="<?php print $_POST["cep"]; ?>">
                        <br><br>
                        &nbsp;Usuario: <input type="text" name="usu" size="30">
                        <br><br>
                        &nbsp;Senha: <input type="password" name="senha" size="8">
                        <br><br>
                        &nbsp;Confirme sua Senha: <input type="password" name="csenha" size="8">
                        <br><br>
                        <center><input type="submit" value="Finalizar Cadastro"> </center>
                        <br><br>
                    </form>
                </td>
            </tr>
        </table>
    </body>
</html>
