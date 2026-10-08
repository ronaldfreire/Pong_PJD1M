using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 directionInput;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector2.up * directionInput * speed * Time.deltaTime); //A multiplicação faz o jogador andar 
    }

    public void OnMove(InputValue value) 
    {
        directionInput = value.Get<Vector2>();
    }
}
