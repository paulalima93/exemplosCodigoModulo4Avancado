/*ATENÇÃO:
Este é apenas um exemplo de como implementar a movimentação do personagem
Caso o aluno faça um jogo plataforma, esse é perfeito, pois pula e move apenas no X
Caso o aluno faça um Top-Down, visto de cima, ele moverá no X e no Y, então o instrua a 
implementar o moveX E o moveY!!

Esta forma de mover o personagem é o padrão do Unity com editores 2022 e 2023
O Unity 6 usa o novo Input Maganer, e a movimentação é configurada de forma 
diferente por padrão, parecido com o feito no módulo do jogo mobile do curso 
Intermediário

Para utilizar este exemplo abaixo com editores Unity 6, basta seguir o caminho:
Edit > Project Settings > Player > Active Input Handling
Escolha a opção "Both". Ao fazer isso, o projeto vai reiniciar e o input 
novo e antigo funcionarão perfeitamente.
*/


using UnityEngine;

public class MovimentoClassico : MonoBehaviour
{
    public float velocidade = 5f;
    
    private Rigidbody2D rb;
    private float moveX;

    void Start()
    {
        // Conecta a variável 'rb' ao corpo físico do personagem no Unity
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // LÊ O JOGADOR: Pega o valor do eixo Horizontal (Setas ou A/D)
        // O valor será -1 (esquerda), 0 (parado) ou 1 (direita)
        moveX = Input.GetAxisRaw("Horizontal");

        // Use a linha abaixo se precisar investigar se o teclado está funcionando
        // Debug.Log("Valor do controle: " + moveX);
    }

    void FixedUpdate()
    {
        // Aplica a força da física.
        // Multiplicamos o eixo pela velocidade. 
        // O eixo Y continua com 'rb.velocity.y' para a gravidade funcionar normalmente (caso seja jogo de plataforma).
        rb.velocity = new Vector2(moveX * velocidade, rb.velocity.y);
    }
}

/*
Se o aluno estiver fazendo um jogo Top-Down (visto de cima, onde a gravidade do Rigidbody2D é zero e ele pode andar para cima e para baixo), 
é só adicionar o moveY no código. No FixedUpdate, a linha de movimento passaria a ser:
rb.velocity = new Vector2(moveX * velocidade, moveY * velocidade);
*/
