using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OxossiScript : MonoBehaviour
{
    [SerializeField] LevelManager lvl;
    SoundManager sm;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Fase2();
        }
    } 

    public void Fase2()
    {
        sm = GameObject.Find("SoundManager").GetComponent<SoundManager>();        
        sm.Stop("Fase1");
        SceneManager.LoadScene("LVL2");

    }
}
