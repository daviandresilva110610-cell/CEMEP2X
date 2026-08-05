import java.util.Scanner;

public class Exc2 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("PROGRAMA MÉIDA WHILE");

        double i=1,a=0,m,c=0;

        while(i==1){

            System.out.println("Digite o número:");
            double n = sc.nextDouble();

            a=a+n;

            System.out.println("Quer continuar?");
            System.out.println("Sim[1]  Não[2]");
            i = sc.nextDouble();

            c++;

        }

        System.out.println("Foram digitados "+c+" valores");

        m=a/c;
        System.out.println("Média é:"+m);


    }
}
