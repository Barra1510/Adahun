using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] Transform[] initialPos;
    [SerializeField] Transform playersPos;
    [SerializeField] GameObject[] players;
    [SerializeField] GameObject rope;
    [SerializeField] bool tied;

    private void Start()
    {
        TypeOfGame();
    }

    public void TypeOfGame()
    {        
        if(tied)
        {
            for(int i = 0; i < players.Length; i++) 
            {
                players[i].gameObject.GetComponent<DistanceJoint2D>().enabled = true;
                rope.gameObject.SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < players.Length; i++)
            {
                players[i].gameObject.GetComponent<DistanceJoint2D>().enabled = false;
                rope.gameObject.SetActive(false);
            }
        }
    }

   
}
