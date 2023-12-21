using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    [SerializeField] LevelManager lvl;
    [SerializeField] int fim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            lvl.ChangePosition(fim);            
        }
    }
}
