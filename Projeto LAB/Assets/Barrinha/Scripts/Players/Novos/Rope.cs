using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
  public Transform player1;
    public Transform player2;
    public float ropeLength = 5f;

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        DrawRope();
    }

    void DrawRope()
    {
        // Configura a posição inicial e final da corda
        Vector3 startPos = player1.position;
        Vector3 endPos = player2.position;

        // Calcula o vetor direção entre os jogadores
        Vector3 ropeDirection = (endPos - startPos).normalized;

        // Define o comprimento da corda
        float currentRopeLength = Vector3.Distance(startPos, endPos);
        if (currentRopeLength > ropeLength)
        {
            endPos = startPos + ropeDirection * ropeLength;
        }

        // Atualiza a posição da corda visualmente
        lineRenderer.SetPosition(0, startPos);
        lineRenderer.SetPosition(1, endPos);
    }
}
