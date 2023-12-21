using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject title;
    [SerializeField] float animTime;
    [SerializeField] SoundManager sm;
    
    private void Start()
    {
        sm.Play("Menu");
        StartCoroutine(TextAnimation());
    }

    IEnumerator TextAnimation()
    {
        title.transform.localScale = new Vector3(0, 0, 0);        
        yield return new WaitForSeconds(animTime*Time.deltaTime);
        title.transform.localScale = new Vector3(2.826476f, 2.826476f, 2.826476f);
        
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
