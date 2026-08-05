import java.util.Scanner;

public class Exemplo03X{

    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);

        int a,b;
        System.out.println("Digite 2 números:");
        a = sc.nextInt();
        b = sc.nextInt();

        System.out.println("X = " + (a+b));

    }
}
