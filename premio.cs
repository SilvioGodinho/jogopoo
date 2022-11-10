using System;

public class Premio:Premiacao{

public string quantidadeAcerto(int QuantidadeAcertos){
    string ret = "";
    
    if(QuantidadeAcertos <= 3){
      Console.WriteLine("Seu Premio é 100 pontos !!!");
    }
  else if(QuantidadeAcertos > 3 ){
    Console.WriteLine("Seu Premio é 250 pontos!!! Muito bom!!");
  }else if(QuantidadeAcertos == 5){
    Console.WriteLine("Seu premio é 1000 pontos Você é um genio!!");
  }
    return ret;
}
}