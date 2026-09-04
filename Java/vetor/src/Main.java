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

        System.out.println("Exibindo inverso: ");
        for (i = vetor.length-1; i>=0; i--){
            System.out.println("0" + (i+1) + "° valor é: "+ vetor[i]);
        }

        //Pedir um elemento qualquer
        System.out.println("Digite um índice para ser exibido: ");
        int indice = sc.nextInt();
        System.out.println("Índice solicitado : "+vetor[indice]);

        //Procurar um valor
        System.out.println("Digite um valor para ser procurado: ");
        int busca = sc.nextInt();
        int encontrado = 0;//Vamos assumir o zero como não encontrado

        for (i = 0; i< vetor.length;i++){
            if(vetor[i] == busca){
                encontrado = 1;
            }

        }
        if(encontrado == 0){
            System.out.println("Valor não encontrado");
        }
        else{
            System.out.println("Valor encontrado");
        }

    }

}
