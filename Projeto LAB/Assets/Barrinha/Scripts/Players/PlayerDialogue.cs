using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerDialogue : MonoBehaviour
{
    public Sprite[] listOfDialogues;
    public Image playerDialogue;

    private void Start()
    {
        playerDialogue.enabled = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {        
        if (collision.gameObject.tag == "1")
        {
            Debug.Log("foi");
            playerDialogue.enabled = true;
            playerDialogue.sprite = listOfDialogues[0];
        }        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "1")
        {
            playerDialogue.enabled = false;            
        }
        
    }

}
