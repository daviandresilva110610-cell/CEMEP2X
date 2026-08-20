package Exempro;

public class Medic extends Funcionario implements Plantonista{
    public Medic(String nome, String cpf, double salarioBase) {super(nome, cpf, salarioBase);}
    public double calculoPagamento(){
        super.salarioBase = super.salarioBase * 1.2;

    }
}
