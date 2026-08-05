import java.util.Scanner;

public class ExcMedia1 {

    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);

        double a,b,c;

        System.out.println("Programa Média");

        System.out.println("Digite três números:");
        a = sc.nextInt();
        b = sc.nextInt();
        c = sc.nextInt();

        System.out.println("O produto dos números é:" + (a+c+b)/3);

    }

}
