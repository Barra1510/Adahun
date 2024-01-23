using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    private float lenght;
    // Largura do sprite do cenário
    private float StartPos;
    //Posição inicial do sprite

    private Transform cam;
    //Localização da câmera

    public float ParallaxEffect;
    //Valor para cada objeto


    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
        // Pega o tamanho do sprite no eixo X para o objeto "lenght"
        cam = Camera.main.transform;


    }

    // Update is called once per frame
    void Update()
    {
        float RePos = cam.transform.position.x * (1-ParallaxEffect);
        // Faz com que a câmera retorne ao início da série de sprites antes do fim da sequência
        float Distance = cam.transform.position.x * ParallaxEffect;

        transform.position = new Vector3(StartPos + Distance, transform.position.y, transform.position.z);
        // Isola os eixos Y e Z da movimentação

        if(RePos > StartPos + lenght)
        {
            StartPos += lenght;
        }

        else if(RePos < StartPos - lenght)
        {
            StartPos -= lenght;
        }
    }
}
