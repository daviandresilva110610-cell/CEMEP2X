public class Carro {


    String modelo;
    String cor;
    double velocidade;
    //construtor
    public Carro(String modelo, String cor, double velocidade){
        this.modelo = modelo;
        this.cor = cor;
        this.velocidade = velocidade;
    }

    public void acelerar(){
        System.out.println( modelo+" está acelerando!");
    }
    public void frear(){
        System.out.println("O carro está freando!");
    }

    @Override
    public String toString() {
        return "Modelo: "+this.modelo+
                "\nCor: "+this.cor+
                "\nVelocidade: "+this.velocidade;
    }
}