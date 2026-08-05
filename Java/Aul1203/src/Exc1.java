import java.util.Scanner;

public class Exc1 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("PROGRAMA TABUADA WHILE");

        int i=0,t;

        System.out.println("Digite o número  q vc quer a tabuada:");
        int n = sc.nextInt();

        while(i<=10){

            t=n*i;
            System.out.println(n+"x"+i+"="+t);
            i++;

        }

    }
}
