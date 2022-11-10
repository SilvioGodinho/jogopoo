using System;


public class Personagem:Jogador{
    
    string p1 = "1 - Doutor Sabe Tudo";
    string p2 = "2 - Doutora Experta";
    string p3 = "3 - Chuta e Acerta";
    string p4 = "4 - Super QI";
    public int numeroTentativas;
    public string persongens()
    {

      Console.WriteLine("Temos os seguintes personagnes para você escolher !!");
      
      Console.WriteLine(p1 + "\n" + p2 + "\n" + p3 + "\n" + p4);

      Console.WriteLine("Qual Personagem você escolhe ?");

      string personagem = Console.ReadLine();

      switch (personagem)
      {
        case "1":
          Console.WriteLine("Você então é o Doutor Sabe tudo, bom vamos ver se é isso mesmo...");
          break;
        case "2":
          Console.WriteLine("Você então é o Doutora Experta, bom vamos ver se é isso mesmo");
          break;
        case "3":
          Console.WriteLine("Você pelo menos é sincero, bom esperamos que tenha um bom jogo");
          break;
        case "4":
          Console.WriteLine("Então você tem um SuperQI vamos ve se é isso mesmo !!!!");
          break;
        default:
          Console.WriteLine("Entrada Invalida !!!!");
          break;
      }
      return personagem;
    }
    public int qualPersonagem()
    {

      Console.WriteLine("Bom antes de começar o jogo, você pode escolher até 3 personagens nesse jogo, sendo que cada um deles tem uma força compativél com a quatidade de tentativas que você vai ter para responder as questões, sendo eles: ");
      Console.WriteLine("1 = forte.\nNessa opção você tem 5 tentativas de acerto");
      Console.WriteLine("2 = superforte.\nNesa opção você tem 3 tentativas de acerto");
      Console.WriteLine("3 = extraforte.\nNessa opção você tem 1 tentativas de acerto" );



      Console.WriteLine("Qual você personagem você escolhe ?");

        string forca = qualForca();
        int numeroTentativas = 0;
        
        if(forca=="forte")
        {
        numeroTentativas = 5;
        Console.WriteLine("Muito bem você escolheu forte, você terá {0} chances para acerta a pergunta",numeroTentativas);
        }
        else if(forca=="superforte")
        {
        numeroTentativas = 3;
        Console.WriteLine("Muito bem você escolheu superforte, você terá {0} chances para acerta a pergunta",numeroTentativas);
        }  
        else if (forca == "extraforte")
        {
        numeroTentativas = 1;
        Console.WriteLine("Muito bem você escolheu extraforte, você terá {0} chances para acerta a pergunta",numeroTentativas);
        } 
        else
        {
          Console.WriteLine("Entrada Invalida, Tente novamente !!!");
        }
      return numeroTentativas;
    }
}