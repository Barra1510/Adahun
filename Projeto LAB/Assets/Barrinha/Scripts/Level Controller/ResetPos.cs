using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    [SerializeField] GM lvl;
    [SerializeField] string scene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            lvl.ChangeScene(scene);           
        }
    }
}
