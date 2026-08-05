import java.util.Scanner;

public class IfExercicio3 {

    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);

        int v;

        System.out.println("PROGRAMA VALOR DIVISÍVEL POR 3 E 7");
        System.out.println("==========================================");

        System.out.println("Digite um valor:");
        v = sc.nextInt();

        if(v%3==0 && v%7==0){

            System.out.println("ESTE NÚMERO É DIVISÍVEL POR 3 E 7!!!");
        }
        else{
            System.out.println("ESTE NÚMERO NÃO É DIVISÍVEL POR 3 E 7!!!");
        }

    }
}
