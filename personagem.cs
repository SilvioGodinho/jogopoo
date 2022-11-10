using System;


public class Personagem:Jogador{
    
    string p1 = "1 - Doutor Sabe Tudo";
    string p2 = "2 - Doutura experta";
    string p3 = "3 - Chuta e acerta";
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
          Console.WriteLine("aaaaaaaaaaa");
          break;
        case "2":
          Console.WriteLine("bbbbbbbbbbb");
          break;
        case "3":
          Console.WriteLine("ccccccccccccc");
          break;
        case "4":
          Console.WriteLine("ddddddddddddddd");
          break;
        default:
          Console.WriteLine("Entrada Invalida !!!!");
          break;
      }
      return personagem;
    }
    public int qualPersonagem()
    {
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