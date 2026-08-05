<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
<meta charset="utf-8">
<title></title>
</head>
<body>
<table border="1" align="center" width="80%">
    <tr>
        <td align="center" ><h1>Hospedagem - Etapa 2 de 3</h1></td>
    </tr>
    <tr>
        <td>
            <form action="etapa3.php" method="post">
                <br><br>

                <input type="hidden" name="nome" value="<?php print $_POST["nome"]; ?>">
                <input type="hidden" name="idd" value="<?php print $_POST["idd"]; ?>">
                <input type="hidden" name="email" value="<?php print $_POST["email"]; ?>">
                <input type="hidden" name="pdi" value="<?php print $_POST["pdi"]; ?>">
                <input type="hidden" name="tdp" value="<?php print $_POST["tdp"]; ?>">

                Tipo de Hospedagem:
                    <br><br>
                    <input type="radio" name="hosp" value="Casa de família" > Casa de família
                    <br><br>
                    <input type="radio" name="hosp" value="Dormitório estudantil" > Dormitório estudantil
                    <br><br>
                    <input type="radio" name="hosp" value="Apartamento compartilhado" > Apartamento compartilhado
                    <br><br>
                Tipo de alimentação<select name="alimen">
                        <option value="Sem alimentação">Sem alimentação</option>
                        <option value="Café da manhã">Café da manhã</option>
                        <option value="Meia pensão">Meia pensão</option>
                        <option value="Pensão completa">Pensão completa</option>
                    </select>
                    <br><br>

                <center><input type="submit" value="Próxima Etapa >>">
                
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