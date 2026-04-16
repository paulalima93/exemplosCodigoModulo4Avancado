/*
ATENÇÃO:
Para que este script funcione sem erros, o objeto do jogador no Unity DEVE ter:
1. O componente Sprite Renderer.
2. O componente Animator.
3. Dentro do Animator, é OBRIGATÓRIO ter um parâmetro do tipo Bool chamado "isWalking".
Se o aluno escreveu com letra minúscula ou outro nome, o código não vai achar esta animação
específica. Este código é só um exemplo, deverá ser adaptado conforme a necessidade do aluno!
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoClassico : MonoBehaviour
{
    public float velocidade = 5f;

    private Rigidbody2D rb;
    private float moveX;

    // NOVO: Variáveis para a Arte (Animação e Imagem)
    private Animator anim;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Conecta a variável 'rb' ao corpo físico do personagem no Unity
        rb = GetComponent<Rigidbody2D>();

        // NOVO: Conecta as variáveis aos componentes visuais do personagem
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // LÊ O JOGADOR: Pega o valor do eixo Horizontal (Setas ou A/D)
        // O valor será -1 (esquerda), 0 (parado) ou 1 (direita)
        moveX = Input.GetAxisRaw("Horizontal");

        // NOVO: Virar o personagem para o lado certo (Flip)
        if (moveX > 0)
        {
            spriteRenderer.flipX = false; // Olha para a direita
        }
        else if (moveX < 0)
        {
            spriteRenderer.flipX = true;  // Olha para a esquerda
        }

        // NOVO: Avisar o Animator para trocar a animação
        // Verifica se o valor de movimento é diferente de zero (ou seja, está apertando alguma tecla)
        bool estaAndando = (moveX != 0);
        anim.SetBool("isWalking", estaAndando);

        // Debug.Log("Valor do controle: " + moveX);
    }

    void FixedUpdate()
    {
        // Aplica a força da física para mover o personagem.
        rb.velocity = new Vector2(moveX * velocidade, rb.velocity.y);
    }
}
