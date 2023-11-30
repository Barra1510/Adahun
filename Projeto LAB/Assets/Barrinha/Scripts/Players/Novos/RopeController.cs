using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeController : MonoBehaviour
{

    public Transform player1;
    public Transform player2;

    private DistanceJoint2D distanceJoint;

    public float maxDistance = 2f; // Distância máxima permitida entre os jogadores
    public float swingForce = 5f; // Força de balanço



    void Start()
    {
        // Configuração inicial da corda
        distanceJoint = gameObject.AddComponent<DistanceJoint2D>();
        distanceJoint.enableCollision = true;
        distanceJoint.connectedBody = player2.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Atualiza a posição do ponto de conexão para o meio entre os dois jogadores
        distanceJoint.anchor = (player1.position + player2.position) / 2f;

        // Verifica se a distância entre os jogadores é maior que o permitido
        float currentDistance = Vector2.Distance(player1.position, player2.position);
        if (currentDistance > maxDistance)
        {
            Vector2 direction = ((Vector2)player1.position - (Vector2)player2.position).normalized;
            Vector2 newPosition = (Vector2)player2.position + direction * maxDistance;

            // Move o jogador 1 para a nova posição
            player1.position = new Vector3(newPosition.x, newPosition.y, player1.position.z);
        }
                // Simulação de gravidade e balanço
        // SimulateSwing();


    }
    // void SimulateSwing()
    // {
    //     Vector2 ropeDirection = ((Vector2)player1.position - (Vector2)player2.position).normalized;

    //     // Adiciona uma força de balanço apenas se os jogadores estiverem acima da corda
    //     if (player1.position.y > player2.position.y)
    //     {
    //         player1.GetComponent<Rigidbody2D>().AddForce(-ropeDirection * swingForce);
    //     }
    // }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class RopeController : MonoBehaviour
// {

//     public Transform player1;
//     public Transform player2;

//     public float maxDistance = 4f; // Distância máxima permitida entre os jogadores
//     public float swingForce = 5f; // Força de balanço
//     public LayerMask groundLayer; // Máscara de camada para verificar o solo
//     public float jumpForce = 10f; // Força de pulo ao balançar

//     private DistanceJoint2D distanceJoint;

//     void Start()
//     {
//         // Configuração inicial da corda
//         distanceJoint = gameObject.AddComponent<DistanceJoint2D>();
//         distanceJoint.enableCollision = true;
//         distanceJoint.connectedBody = player2.GetComponent<Rigidbody2D>();
//     }

//     void Update()
//     {
//         // Atualiza a posição do ponto de conexão para o meio entre os dois jogadores
//         distanceJoint.anchor = (player1.position + player2.position) / 2f;

//         // Verifica se a distância entre os jogadores é maior que o permitido
//         float currentDistance = Vector2.Distance(player1.position, player2.position);
//         if (currentDistance > maxDistance)
//         {
//             // Ajusta a posição do jogador 1 apenas se a distância for maior que o permitido
//             Vector2 direction = ((Vector2)player1.position - (Vector2)player2.position).normalized;
//             Vector2 newPosition = (Vector2)player2.position + direction * maxDistance;

//             // Move o jogador 1 para a nova posição
//             player1.position = new Vector3(newPosition.x, newPosition.y, player1.position.z);
//         }

//         // Simulação de balanço e pulo
//         SimulateSwingAndJump();
//     }

//     void SimulateSwingAndJump()
//     {
//         // Verifica se o jogador 1 está em um ponto mais alto
//         bool isPlayer1Higher = player1.position.y > player2.position.y;

//         // Adiciona uma força de balanço apenas se os jogadores estiverem acima da corda
//         if (isPlayer1Higher)
//         {
//             player1.GetComponent<Rigidbody2D>().AddForce(-distanceJoint.right * swingForce);
//         }

//         // Verifica se o jogador 1 está no solo
//         bool isGrounded = Physics2D.Raycast(player1.position, Vector2.down, 0.1f, groundLayer);

//         // Aplica força de pulo se o jogador 1 pressionar a barra de espaço e estiver no solo
//         if (isPlayer1Higher && isGrounded && Input.GetKeyDown(KeyCode.Space))
//         {
//             player1.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
//         }
//     }
// }
