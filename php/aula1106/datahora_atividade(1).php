<html>
<head>
<meta charset="utf-8">
<title></title>
</head>
<body>
    <table align="center" border="1" width="50%">
        <tr>
            <td align="center"><h1> Data e hora do Sistema</h1></td>
        </tr>
        <tr>
            <td align="center">
                <?php 
                date_default_timezone_set('America/Sao_Paulo');

                print("Data: ");
                print date("d/M/Y");
                print"<br />";
                print("Mês: ");
                print date("m");
                print"<br/>";
                print("Hora: ");
                print date("h:i:s");
                print"<br />";
                $dia = date("d");
                $mes = date("m");
                $ano = date("Y");
                $semana = date("N");
                $horaat = date("s");

                if($mes =="01")
                    $mes2 = "Janeiro";
                else if($mes =="02")
                    $mes2 = "Fevereiro";
                else if($mes =="03")
                    $mes2 = "Março";
                else if($mes =="04")
                    $mes2 = "Abril";   
                else if($mes =="05")
                    $mes2 = "Maio";   
                else if($mes =="06")
                    $mes2 = "Junho";
                else if($mes =="07")
                    $mes2 = "Julho"; 
                else if($mes =="08")
                    $mes2 = "Agosto"; 
                else if($mes =="09")
                    $mes2 = "Setembro";
                else if($mes =="10")
                    $mes2 = "Outubro"; 
                else if($mes =="11")
                    $mes2 = "Novembro";
                else
                    $mes2 = "Dezembro";  
                
                print"<br />";

                if($semana == "0"){
                    $semana2="Domingo";
                }
                else if($semana == "1"){
                    $semana2="Segunda";
                }
                else if($semana == "2"){
                    $semana2="Terça";
                }
                else if($semana == "3"){
                    $semana2="Quarta";
                }
                else if($semana == "4"){
                    $semana2="Quinta";
                }
                else if($semana == "5"){
                    $semana2="Sexta";
                }
                else{
                    $semana2="Sábado";
                }

                if($horaat >= 00 || $horaat <= 11)
                    print("BOM DIA!");
                elseif($horaat >=12 || $horaat <=17)
                    print("BOA TARDE!");
                else
                    print("BOA NOITE!");
                    
                
                print"<br/>";


                if($semana2 == "Sábado")
                    print("Hoje é Sábado");
                else if($semana2 == "Domingo")
                    print("Hoje é Domingo");
                else
                    print("Hoje é um dia útil");

                
                print"<br/>";


                if($mes2 == "Janeiro"||$mes2 == "Fevereiro"||$mes2 == "Março")
                    print("1° TRIMESTRE");

                

                
                print"<br/>";
                print("Paulínia, $semana2 $dia de $mes2 de $ano");

                ?>
            </td>
        </tr>
    </table>
</body>
</html>

