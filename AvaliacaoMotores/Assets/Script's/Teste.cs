using UnityEngine;

public class Teste : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Iniciando Teste");

        
        GameObject anjoGO = GameObject.Find("Teste");
        Personagem anjo = null;

        if (anjoGO != null)
        {
            anjo = anjoGO.GetComponent<Personagem>();
            if (anjo != null)
            {
                
                anjo.Nome = "Azazel, O Mensageiro";
                anjo.Vida = 150f;
                anjo.Ataque = 30f;
                anjo.Defesa = 15f;
                anjo.Asas = "Grandes e brancas";
                anjo.Purificacao = 95f;

                anjo.ExibirStatusAnjo();
            }
            else
            {
                Debug.LogError("O GameObject 'Teste' não possui o componente Personagem.");
            }
        }
        else
        {
            
            Debug.LogWarning("GameObject 'Teste' não encontrado. Criando Personagem dinamicamente.");
            GameObject novoAnjoGO = new GameObject("NovoAnjoCriado");
            anjo = novoAnjoGO.AddComponent<Personagem>();

            anjo.Nome = "Azazel, O Mensageiro";
            anjo.Vida = 150f;
            anjo.Ataque = 30f;
            anjo.Defesa = 15f;
            anjo.Asas = "Grandes e brancas";
            anjo.Purificacao = 95f;

            anjo.ExibirStatusAnjo();
        }

        Debug.Log("Teste Concluído");
    }
}
