import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) throws ArithmeticException{

        int a, b;

        Scanner sc = new Scanner(System.in);


        try {
            System.out.println("Digite 2 números:");
            a = sc.nextInt();
            b = sc.nextInt();
            System.out.println("Soma:" + (a + b));
            System.out.println("Divisão:" + (a / b));
        }
        catch (ArithmeticException e){
            System.out.println("VOCÊ0 É BURRO???");
            System.out.println("NÃO DÁ PRA DIVIDIR POR ZERO ENERGÚMENO ):<");
        }
        catch (InputMismatchException e){
            System.out.println("É SÓ NUMERO INSETO ASQUEROSO ):<");
        }
        sc.close();
    }
}
