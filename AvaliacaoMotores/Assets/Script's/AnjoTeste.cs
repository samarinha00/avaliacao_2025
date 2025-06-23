using UnityEngine;

public class AnjoTeste : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Iniciando Teste");

        
        GameObject anjoGO = GameObject.Find("AnjoTeste");
        Personagem anjo = null;

        if (anjoGO != null)
        {
            anjo = anjoGO.GetComponent<Personagem>();
            if (anjo != null)
            {
                
                anjo.Nome = "Ariel, o Guardião";
                anjo.Vida = 150f;
                anjo.Ataque = 30f;
                anjo.Defesa = 15f;
                anjo.Asas = "Penas douradas e iridescentes";
                anjo.Purificacao = 95f;

                anjo.ExibirStatusAnjo();
            }
            else
            {
                Debug.LogError("O GameObject 'AnjoTeste' não possui o componente Personagem.");
            }
        }
        else
        {
            
            Debug.LogWarning("GameObject 'AnjoTeste' não encontrado. Criando Personagem dinamicamente.");
            GameObject novoAnjoGO = new GameObject("NovoAnjoCriado");
            anjo = novoAnjoGO.AddComponent<Personagem>();

            anjo.Nome = "Gabriel, o Mensageiro";
            anjo.Vida = 120f;
            anjo.Ataque = 25f;
            anjo.Defesa = 12f;
            anjo.Asas = "Asas de luz etérea";
            anjo.Purificacao = 80f;

            anjo.ExibirStatusAnjo();
        }

        Debug.Log("---");

        
        GameObject demonioGO = new GameObject("Demônio da Sombra");
        Personagem demonio = demonioGO.AddComponent<Personagem>();

        demonio.Nome = "Azazel, o Caído";
        demonio.Vida = 200f;
        demonio.Ataque = 40f;
        demonio.Defesa = 20f;
        demonio.Asas = "Asas coriáceas e rasgadas";
        demonio.Purificacao = 0f;

        demonio.ExibirStatusAnjo();

        Debug.Log("---");

        
        if (anjo != null && demonio != null)
        {
            Debug.Log($"Confronto: {anjo.Nome} vs {demonio.Nome}");
            anjo.UsarRaioCelestial(demonio);
            Debug.Log($"{demonio.Nome} vida restante: {demonio.Vida:F2}");

            
            float danoDemonio = demonio.Ataque - (anjo.Defesa * 0.5f); 
            danoDemonio = Mathf.Max(0, danoDemonio); 
            anjo.Vida -= danoDemonio;
            Debug.Log($"{demonio.Nome} ataca {anjo.Nome} causando {danoDemonio:F2} de dano.");
            Debug.Log($"{anjo.Nome} vida restante: {anjo.Vida:F2}");
        }

        Debug.Log("Teste Concluído");
    }
}
