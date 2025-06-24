using UnityEngine;

public class Personagem : MonoBehaviour
{
    
    void Start()
    {
       
        Nome = "Azazel, O Mensageiro"; 
        Vida = 150;
        Ataque = 30;
        Defesa = 15;
        Asas = "Grandes e brancas";
        Purificacao = 95;

        ExibirStatusAnjo();
    }
    
    [SerializeField] private string _nome; 
    [SerializeField] private float _vida;
    [SerializeField] private float _ataque;
    [SerializeField] private float _defesa;
    [SerializeField] private string _asas;
    [SerializeField] private float _purificacao;
    
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public float Vida
    {
        get { return _vida; }
        set { _vida = value; }
    }

    public float Ataque
    {
        get { return _ataque; }
        set { _ataque = value; }
    }

    public float Defesa
    {
        get { return _defesa; }
        set { _defesa = value; }
    }

    public string Asas
    {
        get { return _asas; }
        set { _asas = value; }
    }

    public float Purificacao
    {
        get { return _purificacao; }
        set
        {
            if (value >= 0)
            {
                _purificacao = value;
            }
            else
            {
                Debug.LogWarning("Purificação não pode ser negativa.");
            }
        }
    }
    
    public string HabilidadeEspecial { get; private set; } = "Raio Celestial"; 
    public Personagem(string nome, float vida, float ataque, float defesa, string asas, float purificacao)
    {
        _nome = nome;
        _vida = vida;
        _ataque = ataque;
        _defesa = defesa;
        _asas = asas;
        _purificacao = purificacao;
        HabilidadeEspecial = "Raio Celestial"; 
    }

    protected Personagem()
    {
    }

    public void UsarRaioCelestial(Personagem alvo)
    {
        Debug.Log($"{Nome} invoca o {HabilidadeEspecial} em {alvo.Nome}!");
        float dano = Ataque * 1.5f;
        alvo.Vida -= dano;
        Debug.Log($"{alvo.Nome} sofreu {dano:F2} de dano.");
    }
    
    public void ExibirStatus()
    {
        Debug.Log($"--- Status de {Nome} ---");
        Debug.Log($"Vida: {Vida:F2}");
        Debug.Log($"Ataque: {Ataque:F2}");
        Debug.Log($"Defesa: {Defesa:F2}");
    }

    
    public void ExibirStatusAnjo()
    {
        ExibirStatus();
        Debug.Log($"Asas: {Asas}");
        Debug.Log($"Purificação: {Purificacao:F2}");
        Debug.Log($"Habilidade Especial: {HabilidadeEspecial}");
    }

}
