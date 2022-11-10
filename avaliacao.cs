using System;

public class Avaliacao{

  public Avaliacao(){
    
    this.OpiniaoJogador = "";
    
  }
  public Avaliacao(string opiniaojogador){

    this.OpiniaoJogador = opiniaojogador;
    
  }

  public string calcularAvaliacao(int qtde){
  string ret = "";
    
  if(qtde == 1)
  ret="Seu Premio por avaliação é 50 pontos!!!";
  else
  ret="Agradeço sua avaliaçao.";
  return ret;
    } 

  public String OpiniaoJogador{get; set;}
}