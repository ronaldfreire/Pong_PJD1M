using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb; //Guarda o RigidBod, declaração de uma classe que pode ser acessada por qualquer outro script ou parte do projeto
    [SerializeField] private float ballSpeed;

    void Start() //Aparece assim que começa o jogo
    {
        rb = GetComponent<Rigidbody2D>(); //Pega o componente e especifica no <>
        Launch();
    }

    private void Launch()
    {
        Vector2 direction = Vector2.zero;

        if (Random.value <= 0.5f)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.right;
        }

        rb.linearVelocity = direction * ballSpeed;
    }
}
