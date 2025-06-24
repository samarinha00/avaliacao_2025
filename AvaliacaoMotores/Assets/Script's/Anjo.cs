using UnityEngine;

public class Anjo : Personagem
{
    public string tipoAsa = "Grandes e brancas";
    public bool podeVoar = true;
    
    private string nome;
    private float vida;
    private float ataque;
    private float defesa;
    private string asas;
    private float purificacao;

    void Start()
    {
        Nome = "Azazel, O Mensageiro"; 
        Vida = 150;
        Ataque = 30;
        Defesa = 15;
        Asas = "Grandes e brancas";
        Purificacao = 95;

        ExibirStatusAnjo();
        
        tipoAsa = "Asas Grandes e brancas";
        podeVoar = true;
        
        Debug.Log($"Detalhes do Anjo (Específicos)");
        Debug.Log($"Tipo de Asa: {tipoAsa}");
        Debug.Log($"Pode Voar: {podeVoar}");
        
        VerificarArmazenamento();
    }

    void VerificarArmazenamento()
    {
        Debug.Log($"Verificação de Armazenamento");

        
        Debug.Log($"Verificando 'nome': Valor atual é '{Nome}'.");
        string novoNome = "Azazel, O Mensageiro";
        Nome = novoNome;
        Debug.Log($"'nome' atualizado para '{Nome}'. Armazenado.");

        Debug.Log($"Verificando 'nivel': Valor atual é '{Vida}'.");
        Vida = 150;
        Debug.Log($"'Vida' atualizado para '{Vida}'. Armazenado.");

       
        Debug.Log($"Verificando 'tipoAsa': Valor atual é '{tipoAsa}'.");
        tipoAsa = "Asas de Luz Cristalina";
        Debug.Log($"'tipoAsa' atualizado para '{tipoAsa}'. Armazenado.");

        Debug.Log($"Verificando 'podeVoar': Valor atual é '{podeVoar}'.");
        podeVoar = false; 
        Debug.Log($"'podeVoar' atualizado para '{podeVoar}'. Armazenado.");

        Debug.Log($"Fim da Verificação");
    }

}
