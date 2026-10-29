using System.Runtime.CompilerServices;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb; //Guarda o RigidBody,declaração de uma classe que pode ser acessada por qualquer outro script ou parte do projeto
    [SerializeField] private float ballSpeed;
    [SerializeField] private float rotationBallSpeed = 360f;

    void Start() //Aparece assim que começa o jogo
    {
        rb = GetComponent<Rigidbody2D>(); //Pega o componente e especifica no <>
        Launch();
    }
    private void Update()
    {
        transform.Rotate(xAngle: 0, yAngle: 0, zAngle:rotationBallSpeed * Time.deltaTime);
    }

    private void Launch()
    {
        Vector2 direction = Vector2.zero;

        if (Random.value <= 0.5f) //Sorteia um valor aleatório que decide para que lado a bola irá se lançar inicialmente
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.right;
        }

        direction.y = Random.Range(-0.5f, 0.5f); //Valor máximo para Y
        rb.linearVelocity = direction * ballSpeed;
    }
        
}
