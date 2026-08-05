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
            <td align="center" ><h1>Etapa 2 de 3</h1></td>
        </tr>
        <tr>
            <td>
                <form action="pagina3.php" method="post">
                    <input type="hidden" name="nome" value="<?php print $_POST["nome"]; ?>">
                    <input type="hidden" name="email" value="<?php print $_POST["email"]; ?>">
                    <input type="hidden" name="dtnasc" value="<?php print $_POST["dtnasc"]; ?>">
                    <input type="hidden" name="sexo" value="<?php print $_POST["sexo"]; ?>">
                    <input type="hidden" name="prof" value="<?php print $_POST["prof"]; ?>">
                    <br><br>
                    &nbsp;Telefone: <input type="text" name="fone" size="15">
                    <br><br>
                    &nbsp;Endereço: <input type="text" name="ender" size="30">
                    <br><br>
                    &nbsp;Cidade: <input type="text" name="cidade">
                    <br><br>
                    &nbsp;Estado:
                    &nbsp;<select name="estado">
                    <option> SP </option>
                    <option> RJ </option>
                    <option> MG </option>
                    </select>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cep: <input type="text"   name="cep" size="10">
                    <br><br>
                    <center><input type="submit" value="Prosseguir >>"> </center>
                    <br><br>
                </form>
            </td>
        </tr>
    </table>
</body>
</html>
