using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletaveis : MonoBehaviour
{
    GM gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GM>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {            
            gm.coleta++;
            Destroy(this.gameObject);
        }
    }
}
