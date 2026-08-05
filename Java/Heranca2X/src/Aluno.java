public class Aluno extends Pessoa{

    private int matricula;

    public Aluno(String nome, String cidade, int matricula){
        super(nome, cidade);
        this.matricula = matricula;
    }

    public int getMatricula() {
        return matricula;
    }

    public void setMatricula(int matricula) {
        this.matricula = matricula;
    }
}
