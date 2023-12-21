using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public enum playerMode
    {
        SINGLE, MULTI   
    }

    public playerMode mode;
    //enum
    enum playerSelected
    {
        Player1, Player2, none
    }

    [Header("SoundManager")]
    [SerializeField] SoundManager sm;
    [Header("Players")]
    [SerializeField] GameObject pl1, pl2;
    [SerializeField] playerSelected plSelected;

    private void Awake()
    {
        sm = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }
    private void Start()
    {
        sm.Stop("Menu");
        sm.Play("Fase1");
    }

    private void Update()
    {
        if(plSelected == playerSelected.Player1)
        {
            pl1.GetComponent<SpriteRenderer>().color = Color.green;
            pl2.GetComponent<SpriteRenderer>().color = Color.white;
        }
        
        if(plSelected == playerSelected.Player2)
        {
            pl1.GetComponent<SpriteRenderer>().color = Color.white;
            pl2.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (plSelected == playerSelected.none)
        {
            pl1.GetComponent<SpriteRenderer>().color = Color.white;
            pl2.GetComponent<SpriteRenderer>().color = Color.white;
        }

    }

}
