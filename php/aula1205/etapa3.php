<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
<meta charset="utf-8">
<title></title>
</head>
<body>
<table border="1" align="center" width="50%">
    <tr>
        <td align="center" ><h1>Cadastro - Etapa 3 de 3</h1></td>
    </tr>
    <tr>
        <td align="center" ><h2>SPA - BEM ESTAR</h2></td>
    </tr>
    <tr>
        <td align="center" ><h1>DADOS DO CLIENTE</h1></td>
    </tr>
    <tr>
        <td>
            <form action="inserir.php" method="post">
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
                <input type="hidden" name="pl_adt" value="<?php print $_POST["pl_adt"]; ?>">
                <input type="hidden" name="vpd" value="<?php print $_POST["vpd"]; ?>">
                <input type="hidden" name="qtddias" value="<?php print $_POST["qtddias"]; ?>">
                <input type="hidden" name="obs" value="<?php print $_POST["obs"]; ?>">

                Forma de Pagamento:
                    <select name="fp">
                        <option value="A Vista">A Vista</option>
                        <option value="A Prazo">A Prazo</option>
                    </select>
                <br><br>

                Data Pagamento: <input type="date" name="dtp" size="50">
                <br><br>

                <center><input type="submit" value="Finalizar >>">
                
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