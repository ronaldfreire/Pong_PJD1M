using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : MonoBehaviour
{
    [SerializeField] private float speed; // Esta variável é privada, mas vai aparecer no Inspetor da Unity
    private Vector2 directionInput; // Esta variável é totalmente invisível no Inspetor


    void Update() //Atualiza a lógica do jogo, como nas movimentações ou entradas de teclado em tempo real
    {
        transform.Translate(translation: Vector2.up * directionInput * speed * Time.deltaTime); //A multiplicação faz o jogador andar 
    }

    public void OnMove(InputValue value) 
    {
        directionInput = value.Get<Vector2>(); //Ele vai pegar (get) o valor de Vector2 e jogar (input) na variável
        //Vector2.up = (0, 1)
        //directionInput = (0, 0)
        //O translate move o paddle na Position do Transform
        //transform.Translate((0, 1) * (0, 1) * 5 * delta) - Significa mover o objeto: direção para cima, outro vetor, velocidade do movimento e 
    }
}
