import java.util.concurrent.atomic.AtomicBoolean;

public class Onibus {
    String nome;
    int passageiros;
    public Onibus(String nome, int passageiros)
    {
        this.nome = nome;
        this.passageiros = passageiros;
    }

    public void exibir(){
        System.out.println("O ônibus da marca "+nome+" tem "+passageiros+" passageiros");
        System.out.println("O ônibus da marca "+nome+" está cheio");

    }

}
