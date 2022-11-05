using System;

class Program {
  public static void Main (string[] args) {

    bool comecarJogo = true;
    Console.WriteLine ("Seja bem vindo ao nosso jogo de perguntas e respostas, esperamos que tenha uma boa experiencia e se diverta bastante !!");
    
    Console.WriteLine("Por favor, digite seu nome e em seguida digite sua idade !!");
   
    string nome = Console.ReadLine();
    int idade = int.Parse(Console.ReadLine());
    Personagem jogardor1 = new Personagem();

    jogardor1.Nome = nome;
    jogardor1.Idade = idade;    

    Console.Clear();

    Console.WriteLine("Legal seu nome é " + nome + " e sua idade é " + idade + " anos") ;

    Console.WriteLine("Bom antes de começar o jogo, você pode escolher até 3 personagens nesse jogo, sendo que cada um deles tem uma força compativél com a quatidade de tentativas que você vai ter para responder as questões, sendo eles: ");
    Console.WriteLine("1 = forte.\nNessa opção você tem 5 tentativas de acerto");
    Console.WriteLine("2 = superforte.\nNesa opção você tem 3 tentativas de acerto");
    Console.WriteLine("3 = extraforte.\nNessa opção você tem 1 tentativas de acerto" );

    jogardor1.qualPersonagem();
    
    
    
  }
}