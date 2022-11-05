using System;

public class Avaliacao{

  public Avaliacao(){
    
    this.OpiniaoJogador = "";
    
  }
  public Avaliacao(string opiniaojogador){

    this.OpiniaoJogador = opiniaojogador;
    
  }

  public String OpiniaoJogador{get; set;}
}