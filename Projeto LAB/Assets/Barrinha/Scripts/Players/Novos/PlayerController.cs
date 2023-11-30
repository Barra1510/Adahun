using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public string axis = "Horizontal Teclado";
    private Rigidbody2D rb;

    // public float swingForce = 5f;  // Força para balançar
    // public LayerMask collisionLayer;  // Camada para verificar colisões
    // private DistanceJoint2D distanceJoint;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // distanceJoint = GetComponent<DistanceJoint2D>();

    }

    void Update()
    {
        float inputHorizontal = Input.GetAxis(axis);
        float eixoX = inputHorizontal * moveSpeed;

        float eixoY = rb.velocity.y;

        rb.velocity = new Vector2(eixoX, eixoY);

        // Verifica se o jogador está pressionando a tecla para balançar
        if (Input.GetKey(KeyCode.Space))
        {
            // // Adiciona força ao jogador para balançar, apenas se não estiver colidindo com nada
            // if (!IsColliding())
            // {
            //     Swing();
            // }
        }

    }

    // void Swing()
    // {
    //     // Verifica se o jogador está pendurado na linha
    //     // if (hingeJoint.connectedBody != null)
    //     // {

    //     // }
    //     rb.AddForce(Vector2.up * swingForce, ForceMode2D.Impulse);
    // }

}
