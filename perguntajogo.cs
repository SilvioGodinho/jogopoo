using System;

public class PerguntaJogo{

    public PerguntaJogo(){
        this.Pergunta = "";
        this.Resposta = "";
    }

    public PerguntaJogo(String pergunta, String resposta){
        this.Pergunta = pergunta;
        this.Resposta = resposta;
    }
    
    public String Pergunta {get; set;}

    public String Resposta {get; set;}



}