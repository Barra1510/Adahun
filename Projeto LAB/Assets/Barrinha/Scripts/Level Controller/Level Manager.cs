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
    void Start()
    {
        ChangePosition(0);
        TypeOfGame(false);
    } 

    public void ChangePosition(int i)
    {
        Debug.Log("foi");
        playersPos.transform.position = initialPos[i].transform.position;
    }

    public void TypeOfGame(bool estaPresa)
    {
        if(estaPresa)
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
