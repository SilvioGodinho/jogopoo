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

    public string qualForca(){
        string forca = Console.ReadLine().ToLower();

        return forca;
  }
  
    public String Nome {get; set;}

    public int Idade {get; set;}

  
}