/*
ATENÇÃO:
Este script é a evolução da Aula 05. A lógica do sensor é a mesma, mas a consequência muda!
Aqui, ensinamos o jogador a ganhar pontos e atualizar a interface (HUD).
O script deve ser anexado ao PLAYER.

Para que funcione:
1. O aluno deve ter criado um Canvas com um TextMeshPro.
2. É OBRIGATÓRIO importar a biblioteca "TMPro" no topo do script.
3. No Inspector do Player, o aluno precisará arrastar o Texto da tela para o campo "Texto Placar".
*/

using UnityEngine;
using TMPro; // OBRIGATÓRIO: Biblioteca necessária para usar os textos do TextMeshPro

public class ColetarMoeda : MonoBehaviour
{
    // Variável que guarda a quantidade de moedas (ou itens) coletadas
    public int placar = 0;
    
    // Referência ao texto do Canvas que vai mostrar a pontuação na tela
    public TextMeshProUGUI textoPlacar;

    private void Start()
    {
        // Atualiza o texto assim que o jogo começa para não ficar escrito "Text" na tela
        AtualizarPlacar();
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        // Verifica se o objeto que encostou no jogador possui a Tag "Moeda"
        if (colisao.CompareTag("Moeda"))
        {
            // Soma +1 ao placar (o mesmo que placar = placar + 1)
            placar++;
            
            // Chama a função que atualiza a tela
            AtualizarPlacar();
            
            // Destrói a moeda coletada para dar a ilusão de que foi para o inventário
            Destroy(colisao.gameObject);
        }
    }

    // Função criada por nós para organizar o código e evitar repetição
    private void AtualizarPlacar()
    {
        // Envia o valor matemático do placar para o texto visual do Canvas
        // O aluno pode mudar a palavra "Moedas" para "Estrelas", "Chaves", etc.
        textoPlacar.text = "Moedas: " + placar;
    }
}
