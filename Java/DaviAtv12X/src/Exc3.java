import java.util.Scanner;

public class Exc3 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        System.out.println("PROGRAMA NÚMERO ENTRE");
        System.out.println("Digite um número inteiro:");
        int n = sc.nextInt();

        if (n>0 && n<=50) {

            System.out.println("Esse número está entre 0 e 50 !!!");

        }

        if (n>50 && n<=100) {

            System.out.println("Esse número está entre 51 e 100 !!!");

        }
    }
}
