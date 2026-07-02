/*
ATENÇÃO:
Este script gerencia o Game Over e as armadilhas.
No exemplo abaixo, o script deve ser anexado ao PLAYER. Ele verifica se o 
objeto no qual o jogador encostou tem a tag "Enemy" (Inimigo) ou "Armadilha".
Se o aluno quiser anexar o script na ARMADILHA em vez do Player, a tag a ser 
verificada no IF deve ser a tag do jogador (ex: "Player").

Lembre o aluno de que o objeto que recebe o encosto precisa ter o 
Collider2D marcado com a opção "Is Trigger" no Inspector!

Para reiniciar a fase, precisamos importar a biblioteca de cenas 
(UnityEngine.SceneManagement) lá no topo.
*/

using UnityEngine;
using UnityEngine.SceneManagement; // OBRIGATÓRIO: Biblioteca usada para trocar ou recarregar cenas

public class GameOverTrigger : MonoBehaviour
{
    // Método nativo do Unity acionado automaticamente quando o jogador entra em um Trigger
    private void OnTriggerEnter2D(Collider2D colisao)
    {
        // Verifica se o objeto que encostou no sensor possui a Tag "Enemy" (Inimigo)
        // O aluno DEVE mudar "Enemy" para o nome exato da Tag que ele criou no projeto dele!
        if (colisao.CompareTag("Enemy"))
        {
            // O que acontece quando bate no inimigo? O GDD do aluno dita as regras.
            // Sugestão simples: Recarrega a cena atual, criando o efeito de Game Over clássico.
            
            // GetActiveScene().name pega o nome da cena em que o jogador está agora.
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
            /* DICA PARA A PROFESSORA:
            Se o aluno tiver um sistema de vidas, em vez de recarregar a cena, 
            você pode subtrair uma vida aqui, ou reposicionar o Player no início da fase 
            mudando o 'transform.position'. Siga o GDD dele!
            */
        }
    }
}
