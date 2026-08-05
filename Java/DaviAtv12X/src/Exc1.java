import java.util.Scanner;

public class Exc1 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        System.out.println("PROGRAMA IDADE E NOME");
        System.out.println("Digite seu nome:");
        String n = sc.nextLine();

        System.out.println("Digite sua idade:");
        int i = sc.nextInt();

        System.out.println(n+" tem "+i+" anos de idade.");
    }
}
