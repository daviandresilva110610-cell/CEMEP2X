<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
<meta charset="utf-8">
<title></title>
</head>
<body>
<table border="1" align="center" width="50%">
    <tr>
        <td align="center" ><h1>Cadastro - Etapa 2 de 3</h1></td>
    </tr>
    <tr>
        <td align="center" ><h2>SPA - BEM ESTAR</h2></td>
    </tr>
    <tr>
        <td align="center" ><h1>DADOS DO CLIENTE</h1></td>
    </tr>
    <tr>
        <td>
            <form action="etapa3.php" method="post">
                <br><br>

                <input type="hidden" name="c" value="<?php print $_POST["c"]; ?>">
                <input type="hidden" name="cpf" value="<?php print $_POST["cpf"]; ?>">
                <input type="hidden" name="rg" value="<?php print $_POST["rg"]; ?>">
                <input type="hidden" name="sexo" value="<?php print $_POST["sexo"]; ?>">
                <input type="hidden" name="dtnasc" value="<?php print $_POST["dtnasc"]; ?>">
                <input type="hidden" name="ender" value="<?php print $_POST["ender"]; ?>">
                <input type="hidden" name="cdd" value="<?php print $_POST["cdd"]; ?>">
                <input type="hidden" name="estd" value="<?php print $_POST["estd"]; ?>">
                <input type="hidden" name="cep" value="<?php print $_POST["cep"]; ?>">
                <input type="hidden" name="fone" value="<?php print $_POST["fone"]; ?>">
                <input type="hidden" name="email" value="<?php print $_POST["email"]; ?>">

                Plano Adotado:
                    <select name="pl_adt">
                        <option value="Plano reeducação alimentar">Plano reeducação alimentar</option>
                        <option value="Plano Emagrecimento">Plano Emagrecimento</option>
                        <option value="Plano obesidade">Plano obesidade</option>
                    </select>
                <br><br>

                Valor por Dia: <input type="text" name="vpd" size="50">
                <br><br>

                Quantidade de Dias: <input type="text" name="qtddias" size="15">
                <br><br>

                Obs:<br>
                <textarea name="obs" rows="10" cols="50"></textarea>
                <br><br>

                <center><input type="submit" value="Prosseguir >>">
                
                <br><br><input  type="reset" name="limpar" value="Limpar"> </center>

                <br>

            </form>
        </td>
    </tr>
    <tr>
        <td align="center" ><h3>DESENVOLVIDO POR DAVI 2ºX</h3></td>
    </tr>
</table>
</body>
</html>