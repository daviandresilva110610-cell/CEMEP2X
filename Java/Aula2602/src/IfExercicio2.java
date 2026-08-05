import java.util.Scanner;

public class IfExercicio2 {

    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);

        int v;

        System.out.println("PROGRAMA ÍMPAR OU PAR");
        System.out.println("==========================================");

        System.out.println("Digite um Valor:");
        v = sc.nextInt();



        if(v%2==0){

            System.out.println("O NÚMERO É PAR");

        }
        else{

            System.out.println("O NÚMERO É ÍMPAR");
        }

    }
}
