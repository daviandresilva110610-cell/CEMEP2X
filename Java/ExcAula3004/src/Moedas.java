public class Moedas {

    public double conversor(int op, double vReais){
        double vFinal = 0;
        if (op == 1) {
            vFinal = vReais / 5;
        } else if (op == 2) {
            vFinal = vReais / 5.85;
        } else if (op == 3) {
            vFinal = vReais / 0.032;
        }
    }
}