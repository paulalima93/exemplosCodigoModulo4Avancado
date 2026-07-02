/*
ATENÇÃO:
A Aula 07 foca em Game Feel e Áudio. O maior erro comum aqui é colocar o 
AudioSource na moeda. Se a moeda for destruída pelo Destroy(), o som é 
deletado junto e não toca! 

Por isso, o script abaixo (que pode ser misturado com o da Aula 06) fica 
no PLAYER. Usamos o comando 'PlayOneShot' para garantir que o som toque até 
o fim, mesmo que o objeto da moeda já tenha desaparecido.

No Inspector do Player, o aluno precisará:
1. Adicionar um componente "Audio Source".
2. Arrastar o Audio Source para o campo "Audio Source" do script.
3. Arrastar o arquivo de som (mp3/wav) para o campo "Som Moeda".
*/

using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    // Alto-falante que fica preso no Player
    public AudioSource audioSource;
    
    // O arquivo de som (clipe) tocado quando o jogador coleta o item
    public AudioClip somMoeda;

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        // Verifica se o jogador encostou no item
        if (colisao.CompareTag("Moeda"))
        {
            // Toca o som de coleta imediatamente, uma única vez.
            // Desta forma, o som continua tocando mesmo depois da moeda ser destruída na linha de baixo.
            audioSource.PlayOneShot(somMoeda);
            
            // Código da aula anterior para destruir a moeda
            // Destroy(colisao.gameObject);
        }
    }
}
