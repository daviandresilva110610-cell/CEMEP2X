import java.util.Scanner;

public class Exc1 {

    public static void main(String[] args) {

        Scanner sc= new Scanner(System.in);

        int I=1, J=60;

        while (J>=0){

            System.out.println("I= "+I+" J= "+J);
            I=I+4;
            J=J-5;
        }

    }
}
