using System;

public class Jogador{

    public Jogador(){
      this.Nome = "";
      this.Idade = 0;
    }

    public Jogador(String nome, int idade){
        this.Nome = nome;
        this.Idade = idade;
    }
  
    public String Nome {get; set;}

    public int Idade {get; set;}

  
}