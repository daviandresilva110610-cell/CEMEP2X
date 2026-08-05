public class Midia {
     private String nome;
     private String genero;
     private String atorp;
     private String classificacao;
     private String tipo;

    public Midia(String nome, String genero, String atorp, String classificacao, String tipo){

        this.nome = nome;
        this.genero = genero;
        this.atorp = atorp;
        this.classificacao = classificacao;
        this.tipo = tipo;

    }

    public String getNome(){return this.nome;}
    public String getGenero(){return this.genero;}
    public String getAtorp(){return this.atorp;}
    public String getClassificacao(){return this.classificacao;}
    public String getTipo(){return this.tipo;}

    public void setNome(String nome){this.nome = nome;}
    public void setGenero(String genero){this.genero = genero;}
    public void setAtorp(String atorp){this.atorp = atorp;}
    public void setClassificacao(String classificacao){this.classificacao = classificacao;}
    public void setTipo(String tipo){this.tipo = tipo ;}

    @Override
    public String toString() {
        return "\n Nome: "+nome+
                "\n Gênero: "+genero+
                "\n Ator principal: "+atorp+
                "\n Classificação: "+classificacao+
                "\n Tipo:"+tipo+
                "\n----------------------------------------------";
    }
}



