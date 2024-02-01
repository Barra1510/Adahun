using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscenes : MonoBehaviour
{
    public int players = 0;
    [SerializeField] GameObject cutsceneImage;

    private void Start()
    {
        cutsceneImage.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            players++;            
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            players--;
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if(players >= 2)            
                cutsceneImage.SetActive(true);            
            else
                cutsceneImage.SetActive(false);            


        }
    }
}
