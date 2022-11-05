using System;

public class Premio:Premiacao{

public void quantidadeAcerto(int QuantidadeAcertos){
    if(QuantidadeAcertos <= 3){
      Console.WriteLine("Seu Premio é 100 pontos !!!");
    }
  else if(QuantidadeAcertos > 3 ){
    Console.WriteLine("Seu Premio é 250 pontos!!! Muito bom!!");
  }else if(QuantidadeAcertos == 5){
    Console.WriteLine("Seu premio é 1000 pontos Você é um genio!!");
  }

}
}