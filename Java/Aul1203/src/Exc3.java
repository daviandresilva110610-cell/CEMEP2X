import java.util.Scanner;

public class Exc3 {

    public static void main(String[] args) {
         Scanner sc= new Scanner(System.in);

         int i=1,cont,acumi=0,acump=0,acumz=0;
         double r;

        System.out.println("Digite a quantidade de números para digitar:");
        int a= sc.nextInt();

        while(i<=a){

            System.out.println("Digite o "+i+"° valor");
            double v=sc.nextDouble();

            r=v%2;

            if(v==0){
                acumz=acumz+1;
            }
            else if(r==0){
                acump=acump+1;
            }
            else if(r==1){
                acumi=acumi+1;
            }

            i++;

        }

        System.out.println(acump+" númetos pares, "+acumi+" números ímpares, "+acumz+" zeros.");

    }
}
