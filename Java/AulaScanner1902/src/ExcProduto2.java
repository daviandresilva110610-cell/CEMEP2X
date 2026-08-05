import java.util.Scanner;

public class ExcProduto2 {

    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);


        System.out.println("Digite três números");
        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();

         System.out.println(a+" x "+b+" = "+a*b);
         System.out.println(a+" x "+c+" = "+a*c);
         System.out.println(b+" x "+c+" = "+c*b);
    }
}
