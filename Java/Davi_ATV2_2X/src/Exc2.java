import java.util.Scanner;

public class Exc2 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int A=0, B=0, c=1;

        while(c==1){

            System.out.println("Incrementar à variável A em 1 unidade?[1]");
            System.out.println("Incrementar à variável A em 2 unidadeS?[2]");
            System.out.println("Decrementar à variável A em 1 unidade?[3]");
            System.out.println("Incrementar à variável B em 1 unidade?[4]");
            System.out.println("Incrementar à variável B em 2 unidadeS?[5]");
            System.out.println("Decrementar à variável B em 1 unidade?[6]");
            System.out.println("Digite o número da opção:");
            int r = sc.nextInt();

            if (r == 1) {
                A=A+1;
            }

            else if (r == 2) {
                A=A+2;
            }

            else if (r == 3) {
                A=A-1;
            }

            else if (r == 4) {
                B=B+1;
            }

            else if (r == 5) {
                B=B+2;
            }

            else if (r == 6) {
                B=B-1;
            }

            System.out.println("Você deseja terminar o programa?");
            System.out.println("SIM[0] NÃO[1]");
            c = sc.nextInt();

        }

        System.out.println("O valor de A é: "+A);
        System.out.println("O valor de B é: "+B);

    }

}
