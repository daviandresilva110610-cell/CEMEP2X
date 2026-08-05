import java.util.Scanner;

public class Exercicio4 {

    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);

        int id,ano,mes,dia,ano2,mes2,sobra,sobraid;

        System.out.println("Escreva sua idade em dias:");
        id=sc.nextInt();

        ano=id/365;
        mes=(id-ano*365)/30;
        dia=(id-ano*365-mes*30);

        System.out.println("Sua idade é:"+ano+" ano, "+mes+" mês e "+dia+" dias");

    }

}
