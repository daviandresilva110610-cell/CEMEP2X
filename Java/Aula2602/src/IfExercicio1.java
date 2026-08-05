import java.util.Scanner;

public class IfExercicio1 {

    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);

        double v1, v2, v3, m;

        System.out.println("PROGRAMA MÉDIA");
        System.out.println("==========================================");

        
        System.out.println("Digite a primeira nota:");
        v1 = sc.nextDouble();
        System.out.println("Digite a segunda nota:");
        v2 = sc.nextDouble();
        System.out.println("Digite a terceira nota:");
        v3 = sc.nextDouble();

        m=(v1+v2+v3)/3;

         System.out.println("Nota 1:"+v1);
         System.out.println("Nota 2:"+v2);
         System.out.println("Nota 3:"+v3);
         System.out.println("Média"+m);

        if(m>=7){
            System.out.println("ALUNO APROVADO :) UHUUULLLL!!!");
        }
        else{
            System.out.println("ALUNO REPROVADO :( NÃOOOOO");
        }

    }
}
