using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxossiScript : MonoBehaviour
{
    [SerializeField] LevelManager lvl;
    SoundManager sm;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sm = GameObject.Find("SoundManager").GetComponent<SoundManager>();
            sm.Stop("Fase1");
            sm.Play("Fase2");
            lvl.ChangePosition(1);
            lvl.TypeOfGame(true);
        }
    } 
}
