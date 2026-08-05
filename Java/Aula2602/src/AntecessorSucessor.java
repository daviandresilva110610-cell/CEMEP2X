import java.util.Scanner;

public class AntecessorSucessor {

    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);

        int num,ant,suc;

        System.out.println("Programa Antecessor Sucessor");
        System.out.println("==============================");


        System.out.println("Digite um número:");
        num = sc.nextInt();
        ant = num-1;
        suc = num+1;

        System.out.println("O número"+num+"tem como antecessro"+ant+"e como sucessor"+suc);
    }

}
