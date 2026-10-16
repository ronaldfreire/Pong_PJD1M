using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb; //Guarda o RigidBod, declaração de uma classe que pode ser acessada por qualquer outro script ou parte do projeto
    

    void Start() //Aparece assim que começa o jogo
    {
        rb = GetComponent<Rigidbody2D>(); //Pega o componente e especifica no <>
        Launch();
    }

    private void Launch()
    {

    }
}
