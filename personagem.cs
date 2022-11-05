using System;


public class Personagem:Jogador{
  
    public int quantidadeAcertos;
    public string qualPersonagem()
    {
      Console.WriteLine("Qual você personagem você escolhe ?");
      string personagem = Console.ReadLine();
    
  
    switch(personagem)
    {
      case "forte":
          quantidadeAcertos = 5;
          Console.WriteLine("Muito bem você escolheu forte, você terá {0} chances",quantidadeAcertos);
        break;
      case "superforte":
          quantidadeAcertos = 3;
          Console.WriteLine("Muito bem você escolheu superforte, você terá {0} chances",quantidadeAcertos);
        break;
      case "extraforte":
          quantidadeAcertos = 1;
          Console.WriteLine("Muito bem você escolheu extraforte, você terá {0} chances",quantidadeAcertos);
        break;
      default:
        Console.WriteLine("Entrada Invalida !!! Tente novamente");
        Console.Clear();
        break;
    }
    return personagem;
    }
}