using System;

class Program {
  public static void Main (string[] args) {
    
    int pontuacao = 0;

    Premio premio = new Premio();
    
    Avaliacao avaliacao = new Avaliacao();
    
    try{
    //bool comecarJogo = true;
    Console.WriteLine ("Seja bem vindo ao nosso jogo de perguntas e respostas, esperamos que tenha uma boa experiencia e se diverta bastante !!");
    
    Console.WriteLine("Por favor, digite seu nome e em seguida digite sua idade !!");
   
    string nome = Console.ReadLine();
    int idade = int.Parse(Console.ReadLine());
    Personagem jogardor1 = new Personagem();

    jogardor1.Nome = nome;
    jogardor1.Idade = idade;    

    Console.Clear();

    Console.WriteLine("Legal seu nome é " + nome + " e sua idade é " + idade + " anos") ;


    jogardor1.persongens();
    jogardor1.qualPersonagem();

    CriarPergunta pj = new CriarPergunta();
    string perg = pj.gerarPergunta();
    int numPerg = 0;

    Console.WriteLine(perg);

    pj.Pergunta = Console.ReadLine().ToLower();

    numPerg = Convert.ToInt32(perg.Substring(0, 1));
    if(numPerg ==1){
      if(pj.Pergunta =="vento" ){
      //Acertou
      pontuacao = pontuacao +1;
    }
    }
    if(numPerg ==2){
    if(pj.Pergunta =="esponja" ){
    //Acertou
    pontuacao = pontuacao +1;
    }
    }
    if(numPerg ==3){
    if(pj.Pergunta =="foto" ){
    //Acertou
    pontuacao = pontuacao +1;
    }
    }
    if(numPerg ==4){
    if(pj.Pergunta =="toalha" ){
    //Acertou
    pontuacao = pontuacao +1;
    }
    }
    if(numPerg ==5){
    if(pj.Pergunta =="ovo" ){
    //Acertou
    pontuacao = pontuacao +1;
    }
    }
    if(numPerg ==6){
    if(pj.Pergunta =="vela" ){
    //Acertou
    pontuacao = pontuacao +1;
    }
    }
    if(numPerg ==7){
    if(pj.Pergunta =="maria" ){
    //Acertou
    pontuacao = pontuacao +1;
    }
    }
    if(numPerg ==8){
    if(pj.Pergunta =="palma" ){
    //Acertou
    pontuacao = pontuacao +1;
    }
    }
    if(numPerg ==9){
    if(pj.Pergunta =="chuva" ){
    //Acertou
    pontuacao = pontuacao +1;
    }
    }


    Console.WriteLine("Sua pontuação é: " + pontuacao);

    Console.WriteLine(premio.quantidadeAcerto(pontuacao));
    //avaliaçao
    Console.WriteLine("Por favor, avalie o jogo gostou? 1- sim 2- não:");
    int avaliacaoJogador = int.Parse(Console.ReadLine());
    Console.WriteLine(avaliacao.calcularAvaliacao(avaliacaoJogador));
    
    
    }   
    catch(FormatException e){
    Console.Write("Opção inválida, tente novamente");

  
    }
    }
    }