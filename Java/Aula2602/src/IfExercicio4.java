import java.util.Scanner;

public class IfExercicio4 {

    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);

        double x, y;

        System.out.println("PROGRAMA PPLANO CARTESIANO");
        System.out.println("==========================================");

        System.out.println("Digite o valor do eixo x:");
        x = sc.nextDouble();
        System.out.println("Digite o valor do eixo y");
        y = sc.nextDouble();

        if(x>0 && y>0)
        {

            System.out.println("Está no Q1");
        }
        else if(x<0 && y>0)
        {
            System.out.println("Está no Q2");
        }
        else if(x>0 && y<0 )
        {
            System.out.println("Está no Q3");
        }
        else if(x>0 && y<0)
        {
            System.out.println("Está no Q4");
        }
        else if(x==0 || y==0)
        {
            System.out.println("Esté na origem");
        }

    }
}
