import java.sql.SQLOutput;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int[] vetor = new int[5];//Array tem 5 elementos
        int i;

        System.out.println("Digite os valores no vetor: ");
        for (i = 0; i< vetor.length;i++){

            vetor[i] = sc.nextInt();

        }

        System.out.println("Exibindo o vetor: ");
        for (i = 0; i < vetor.length; i++){
            System.out.println("0" + (i+1) + "° valor é: "+ vetor[i]);
        }

    }

}
