public class Veiculo {
    String placa, modelo;
    int ano;
    double capacidadeTanque, quilometragem, nivelCombustivel, quilometragemUltimaRevisao, consumoMedio;

    public Veiculo(String placa, String modelo, int ano, double capacidadeTanque, double consumoMedio) {
        this.placa = placa;
        this.modelo = modelo;
        this.ano = ano;
        this.capacidadeTanque = capacidadeTanque;
        this.consumoMedio = consumoMedio;

        this.nivelCombustivel = 0.0;
        this.quilometragem = 0.0;
        this.quilometragemUltimaRevisao = 0.0;
    }

    public String getPlaca() {
        return placa;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }

    public String getModelo() {
        return modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public int getAno() {
        return ano;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }

    public double getCapacidadeTanque() {
        return capacidadeTanque;
    }

    public void setCapacidadeTanque(double capacidadeTanque) {
        this.capacidadeTanque = capacidadeTanque;
    }

    public double getQuilometragem() {
        return quilometragem;
    }

    public void setQuilometragem(double quilometragem) {
        this.quilometragem = quilometragem;
    }

    public double getNivelCoombustivel() {
        return nivelCombustivel;
    }

    public void setNivelCoombustivel(double nivelCoombustivel) {
        this.nivelCombustivel = nivelCoombustivel;
    }

    public double getQuilometragemUltimaRevisao() {
        return quilometragemUltimaRevisao;
    }

    public void setQuilometragemUltimaRevisao(double quilometragemUltimaRevisao) {
        this.quilometragemUltimaRevisao = quilometragemUltimaRevisao;
    }

    public double getConsumoMedio() {
        return consumoMedio;
    }

    public void setConsumoMedio(double consumoMedio) {
        this.consumoMedio = consumoMedio;
    }

    //MÉTODOS A MÃO

    public double caulcularAutonomia() {
        return this.nivelCombustivel * this.consumoMedio;
    }

    public boolean Abastecer(double litros) {

        if (litros <= 0 || (this.nivelCombustivel + litros) > this.capacidadeTanque) {
            System.out.println("Operação inválida: quantidade de litros incorreta ou ultrapassa a capacidade do tanque.");

            return false;
        }
        this.nivelCombustivel = nivelCombustivel + litros;
        return true;
    }

    public boolean registrarViagem(double distanciaPercorrida) {

        if (distanciaPercorrida <= this.caulcularAutonomia()) {
            this.quilometragem = quilometragem + distanciaPercorrida;

            double combustivelGasto = distanciaPercorrida / this.consumoMedio;
            this.nivelCombustivel = nivelCombustivel - combustivelGasto;
            System.out.println("Viagem registrada!");
            return true;
        } else {
            System.out.println("Combustível insuficiente!");
            return false;
        }
    }

    public boolean precisaManutencao() {

        if (quilometragem > 10000 && quilometragemUltimaRevisao > 10000) {
            System.out.println("O carro precisa de manutenção!");
            return true;
        } else {
            System.out.println("O carro não precisa de manutenção!");
            return false;
        }
    }

    public void realizaManutencao() {
        this.quilometragemUltimaRevisao = this.quilometragem;
        System.out.println("Manutenção realizada. Quilometragem de revisão atualizada.");
    }

    @Override
    public String toString() {
        return "Veiculo" +
                "placa='" + placa + '\'' +
                ", modelo='" + modelo + '\'' +
                ", ano=" + ano +
                ", capacidadeTanque=" + capacidadeTanque +
                ", quilometragem=" + quilometragem +
                ", nivelCombustivel=" + nivelCombustivel +
                ", quilometragemUltimaRevisao=" + quilometragemUltimaRevisao +
                ", consumoMedio=" + consumoMedio;

    }
}
