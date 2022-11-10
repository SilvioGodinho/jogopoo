using System;


public class CriarPergunta:PerguntaJogo
{   
    
public string gerarPergunta(){
  string ret = "";
  Random r = new Random();
  int x= r.Next(10);//Max range
  switch (x) 
{
  case 1:
   ret ="1 - O que é o que é? Passa diante do sol e não faz sombra?";
  break;
  case 2:
     ret ="2 - O que é o que é ? Cheio de furinhos e ainda consegue reter água?";
  break;
  case 3:
     ret ="3 -O que é o que é que quanto mais tira mais tem?";
  break;
  case 4:
      ret ="4 -  O que é o que é? Quanto mais seca mais fica molhada?";
  break;
  case 5:
     ret ="5 - o que é o que é que para ser usado precisa ser quebrado?";
  break;
  case 6:
     ret ="6 - O que é o que é ? Alto quando é novo e baixo quando é usado?";
  break;
  case 7:
      ret ="7 - O pai de Maria tem 5 filhas nana, nenê nini nono e…?";
  break;
  case 8:
      ret ="8 - O que é o que é? Uma planta e todos tem na mão?";
  break;
  default:
      ret ="9 - O que é o que é? Cai em pe e corre deitada?";
  break;
}
  return ret;
      
  }

}