import java.util.Scanner;

public class Conversor {

    public static void main(String[] args) {

        double r,c;
        int e;

        Scanner sc = new Scanner(System.in);
        Moedas m = new Moedas();

        System.out.println("Digite a quantidade de reais:");
        r = sc.nextDouble();
        System.out.println("\n1-Dólar||2-Euro||3-Yen");
        System.out.println("\n Escolha o número da conversão de moeda:");
        e = sc.nextInt();
        switch(e)
        {
            case(1):
               c=m.dolar(r);
                System.out.println("\nO valor de reais é:"+c+"Dólar");
                break;
            case(2):
                c=m.euro(r);
                System.out.println("\nO valor de reais é:"+c+"Euros");
                break;
            case(3):
                c=m.yen(r);
                System.out.println("\nO valor de reais é:"+c+"Yen");
                break;

        }
    }
}
