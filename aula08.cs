/*
ATENÇÃO:
Este é o script do Menu Principal, o grande momento de Lançamento!
Este script NÃO vai no Player. O aluno deve criar um objeto vazio (Empty) 
na cena do Menu chamado "MenuManager" e anexar este script nele.

A palavra "public" antes do "void" é CRÍTICA. Se não for public, o Botão 
da interface gráfica do Unity não vai conseguir encontrar este código 
na hora de configurar o "On Click ()".

O nome da fase dentro das aspas deve ser exatamente igual ao nome 
do arquivo da cena do jogo salvo na aba Project.
*/

using UnityEngine;
using UnityEngine.SceneManagement; // OBRIGATÓRIO: Para carregar a cena do jogo

public class MenuManager : MonoBehaviour
{
    // Função OBRIGATORIAMENTE pública para que o Botão UI consiga acessá-la
    public void Jogar()
    {
        // Carrega a cena onde o jogo principal acontece.
        // O aluno DEVE alterar "Fase1" para o nome exato da cena dele!
        SceneManager.LoadScene("Fase1");
    }

    // Função bônus caso o aluno queira fazer um botão de "Sair" do jogo
    public void SairDoJogo()
    {
        // O comando Quit só funciona quando o jogo já foi transformado em executável (.exe) no Build.
        // Dentro do Unity Editor, ele não tem efeito visual, mas no jogo final ele fecha a janela.
        Debug.Log("O jogo está sendo fechado...");
        Application.Quit();
    }
}
