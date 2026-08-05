import java.util.Scanner;

public class Exc2 {

    public static void main(String[] args) {

        Scanner sc= new Scanner (System.in);

        System.out.println("PROGRAMA DDD");

        System.out.println("Digite o seu DDD:");
        int d = sc.nextInt();

        if (d==61){
            System.out.println("A cidade é Brasília");
        }
        else if (d==71){
            System.out.println("A cidade é Salvador");
        }
        else if (d==11){
            System.out.println("A cidade é São Paulo");
        }
        else if (d==21){
            System.out.println("A cidade é Rio de Janeiro");
        }
        else if (d==32){
            System.out.println("A cidade é Juiz de Fora");
        }
        else if (d==19){
            System.out.println("A cidade é Campinas");
        }
        else if (d==27){
            System.out.println("A cidade é Vitória");
        }
        else if (d==31){
            System.out.println("A cidade é Belo Horizonte");
        }
        else{
            System.out.println("DDD não cadastrado!!!");
        }

    }
}
