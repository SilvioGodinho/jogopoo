using System;


public class CriarPergunta:PerguntaJogo
{   

    public CriarPergunta():base()
    {
        
    }

    public List<PerguntaJogo> criarLista()
    {

        List<PerguntaJogo> lista = new List<PerguntaJogo>();
        lista.Add(new PerguntaJogo("O que é o que é? Passa diante do sol e não faz sombra?", "Vento"));
        lista.Add(new PerguntaJogo("O que é o que é ? Cheio de furinhos e ainda consegue reter água?", "Esponja"));
        lista.Add(new PerguntaJogo("O que é o que é que quanto mais tira mais tem?", "Foto"));
        lista.Add(new PerguntaJogo("Qual o queijo que mais sente dor?", " Queijo ralado"));
        lista.Add(new PerguntaJogo("O que é o que é? Quanto mais seca mais fica molhada?", " Toalha"));
        
        
        return lista;
    }
    


}