import java.util.Scanner;

public class Soma3Num {

    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);

        int a,b,c;
        System.out.println("Digite três números:");
        a = sc.nextInt();
        b = sc.nextInt();
        c = sc.nextInt();

        System.out.println("Produto da operação é:" + (a*b*c));
    }
}
