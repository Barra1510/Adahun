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
    [SerializeField] GameObject SS, playButton, config, credit;
    [SerializeField] Slider volumeSlider;
    [SerializeField] Button fase1, fase2;
    
    private void Start()
    {
        if(PlayerPrefs.HasKey("Volume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
        }
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

    public void StageSelection(bool state)
    {
        SS.SetActive(state);
        playButton.SetActive(!state);
        if(state)
        {
            sm.Stop("Menu");
            sm.Play("MenuFases");
        }
        else
        {
            sm.Play("Menu");
            sm.Stop("MenuFases");
        }
    }

    public void Configuration(bool state)
    {
        config.SetActive(state);
    }
    public void Credits(bool state)
    {
        credit.SetActive(state);
    }

    public void SetMusicVolume()
    {
        sm.MusicVolume(volumeSlider.value);
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
    }
    public void LoadVolume()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
        SetMusicVolume();
    }

    public void OnMusicEnter(string music)
    {
        sm.Stop("MenuFases");
        sm.Play(music);
    }
    public void OnMusicExit(string music)
    {
        sm.Stop(music);
        sm.Play("MenuFases");
    }
}
