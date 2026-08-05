<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
<meta charset="utf-8">
<title></title>
</head>
<body>
<table border="1" align="center" width="80%">
    <tr>
        <td align="center" ><h1>Serviços Extras - Etapa 3 de 3</h1></td>
    </tr>
    <tr>
        <td>
            <form action="inserir.php" method="post">
                <br><br>

                <input type="hidden" name="nome" value="<?php print $_POST["nome"]; ?>">
                <input type="hidden" name="idd" value="<?php print $_POST["idd"]; ?>">
                <input type="hidden" name="email" value="<?php print $_POST["email"]; ?>">
                <input type="hidden" name="pdi" value="<?php print $_POST["pdi"]; ?>">
                <input type="hidden" name="tdp" value="<?php print $_POST["tdp"]; ?>">
                <input type="hidden" name="hosp" value="<?php print $_POST["hosp"]; ?>">
                <input type="hidden" name="alimen" value="<?php print $_POST["alimen"]; ?>">

                Serviços disponíveis:
                <br><br>
                    Seguro viagem:
                    <br>
                    <input type="radio" name="sv" value="Sim">Sim
                    <br><br>
                    <input type="radio" name="sv" value="Não">Não
                    <br><br>
                    Curso de inglês istensivo:
                    <br>
                    <input type="radio" name="ci" value="Sim">Sim
                    <br><br>
                    <input type="radio" name="ci" value="Não">Não
                    <br><br>
                    Passeio turístico:
                    <br>
                    <input type="radio" name="pat" value="Sim">Sim
                    <br><br>
                    <input type="radio" name="pat" value="Não">Não
                    <br><br>
                    Transporte aeroporto/hotel:
                    <br>
                    <input type="radio" name="tah" value="Sim">Sim
                    <br><br>
                    <input type="radio" name="tah" value="Não">Não
                    <br><br>
                    Chip internacional:
                    <br>
                    <input type="radio" name="chip" value="Sim">Sim
                    <br><br>
                    <input type="radio" name="chip" value="Não">Não
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