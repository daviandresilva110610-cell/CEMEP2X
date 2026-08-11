<?php 

    date_default_timezone_set('America/Sao_Paulo');
    $dia = date("d");
    $mes - date("m");
    $ano = date("Y");
    $semana = date("w");

    if($mes == "01")
        $mes2 = "Janeiro";
    else if($mes == "02")
        $mes2 = "Fevereiro";
    else if($mes == "03")
        $mes2 = "Março";
    else if($mes == "04")
        $mes2 = "Abril";
    else if($mes == "05")
        $mes2 = "Maio";
    else if($mes == "06")
        $mes2 = "Junho";
    else if($mes == "07")
        $mes2 = "Julho";
    else if($mes == "08")
        $mes2 = "Agosto";
    else if($mes == "09")
        $mes2 = "Setembro";
    else if($mes == "10")
        $mes2 = "Outubro";
    else if($mes == "11")
        $mes2 = "Novembro";
    else if($mes == "12")
        $mes2 = "Dezembro";

    if($semana == "0")
        $semana2="Domingo";
    else if($semana == "1")
        $semana2="Segunda";
    else if($semana == "2")
        $semana2="Terça";
    else if($semana == "3")
        $semana2="Quarta";
    else if($semana == "4")
        $semana2="Quinta";
    else if($semana == "5")
        $semana2="Sexta";
    else
        $semana2="Sábado";

    print("Paulínia, $dia de $mes2 de $ano - $semana2");


?>